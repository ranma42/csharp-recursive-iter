# Risks (and how to handle them)

Changing and/or extending the implementation of the translation of `yield`-ing
methods poses several risks around compatibility and regressions. Some have been
explicitly mentioned as requirements (see
[here](https://github.com/dotnet/csharplang/discussions/378#discussioncomment-11753184)),
such as:

- No ABI changes to existing APIs.
- No need to duplicate all APIs to have a version that takes in/out a new interface
- No performance impact whatsoever on any existing code; this must be true for
  every permutation, specifically:
  - where a referenced dll is recompiled, but referencing code is not recompiled;
  - where referencing code is recompiled, but referenced code is not recompiled;
  - where both sides are recompiled.

Additionally, the implementation should make it clear to users when they are
effectively getting the expected linear scaling (vs the quadratic one). For
example, allowing the following code to compile would be a bad idea:
```csharp
public static IEnumerable<int> NumbersBad()
{
    yield return 0;
    yield each NumbersBad().Select(x => x + 1);
}
```
as it would not be clear to users that they would get the quadratic scaling even
though there is no explicit loop. This happens regardless of the efficiency of
the `yield each` implementation, because the n-th element is obtained by
performing n additions (the chain of `Select` calls keeps getting deeper).

## A strategy that might work

One possible strategy would have all of the desired properties is the following:
1. introduce a new interface `INestedEnumerable<T>` which is a specialization of
   `IEnumerable<T>`
2. `yield each` is only allowed in the body of methods that return an
   `INestedEnumerable<>`; these methods are lowered in a way designed to
   implement this operation efficiently (see, for example, the `Paper` or
   `Stackless` implementation in this repository)
3. the "argument" of `yield each` must be an `INestedEnumerable<>`

> [!IMPORTANT]  
> Only methods that return `INestedEnumerable<T>` use the code translation that
> supports `yield each`. Other methods (specifically those that use `yield` but
> return `IEnumerable<T>`) keep using the existing translation.

### No ABI changes to existing APIs

None of the existing APIs are affected by this change. Their ABI does not change
as the introduction of a new specialization of `IEnumerable<T>` is perfectly
normal and poses no unusual risk.

### No need to duplicate APIs

Since `INestedEnumerable<T>` is a specialization of `IEnumerable<T>`, the APIs
that can currently accept an `IEnumerable<T>` are trivially compatible with
`INestedEnumerable<T>`.

> [!NOTE]  
> New APIs that are defined to accept `INestedEnumerable<T>` will not accept
> `IEnumerable<T>` values without an explicit adapter; this is desirable, as it
> prevents users from accidentally introducing quadratic scaling as in the
> `NumbersBad` example.

### No performance impact on existing code

Existing code would not be translated in a different way: only methods that are
defined to return `INestedEnumerable<T>` would be translated in a way that also
allows `yield each` (existing code contains no such method).

This guarantees that all combinations of references/referenced and
recompiled/not recompiled do not change at all.

This strategy ensures compiling existing code introduces no changes to the IL.
This implies that performance is not affected by this new feature in the
compiler, and it also provides strong compatibility guarantees for reflection
and/or code inspection/post-processing tools.

### Preventing careless misuse

As mentioned above, `yield each` requires an `INestedEnumerable<T>` argument and
no implicit conversion from `IEnumerable<T>` is provided. This is intentional as
it helps developers keep a path that ensures good scaling and makes it very
explicit when they are stepping out of that.

For example, `NumbersBad` as written above would not compile:
```csharp
public static IEnumerable<int> NumbersBadV1()
{
    yield return 0;
    yield each NumbersBadV1().Select(x => x + 1);
    // ERROR: yield each can only be used within methods that return INestedEnumerable<T>
    // ERROR: cannot yield each IEnumerable<int>
}
```

Marking the method as `INestedEnumerable<int>` would only fix the first error:
```csharp
public static INestedEnumerable<int> NumbersBadV2()
{
    yield return 0;
    yield each NumbersBadV2().Select(x => x + 1);
    // ERROR: cannot yield each IEnumerable<int>
}
```
> [!IMPORTANT]  
> This code is using the fact that `INestedEnumerable<T>` is a specialization of
> `IEnumerable<T>`, hence you can use `.Select` on it; on the other hand it
> shows why it is convenient that the conversion from `IEnumerable<T>` to
> `INestedEnumerable<T>` is explicit. If this was not the case, developers might
> be misled into thinking that this code scales linearly, while it actually
> scales quadratically.

In order to get this second error fixed, one of several options could be used:
```csharp
public static INestedEnumerable<int> NumbersBadV3()
{
    yield return 0;
    foreach (var item in NumbersBadV3().Select(x => x + 1)) {
        yield return item;
    }
}
```
> [!WARNING]  
> `NumbersBadV3` is bad (it scales quadratically), but developers would see the
> loop explicitly. This is in fact the very same code they would currently write
> (without `yield each`) if they were ignoring scalability issues.

```csharp
// This might even be provided by the runtime with a sufficiently descriptive name
public static INestedEnumerable<T> AdaptorThatMightIntroduceQuadraticScaling(this IEnumerable<T> source)
{
    foreach (var item in source) {
        yield return item;
    }
}

public static INestedEnumerable<int> NumbersBadV4()
{
    yield return 0;
    yield each NumbersBadV4().Select(x => x + 1).AdaptorThatMightIntroduceQuadraticScaling();
}
```
> [!WARNING]  
> `NumbersBadV4` is still bad (it scales quadratically), but the developers are
> being explicit in accepting quadratic scaling.

```csharp
public static INestedEnumerable<int> NumbersOk(int start = 0)
{
    yield return start;
    yield each NumbersOk(start + 1);
}
```
This is ok: is scales linearly, as expected.
