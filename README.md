# Nested iteration experiments

This repo contains some experiments on nested iteration, with the coal of
finding an implementation suitable for [C# Recursive Iterators
(non-quadratic)](https://github.com/dotnet/csharplang/discussions/378).

The implementations currently tested are in the `src` folder:
 - `Current`, i.e. the current implementation of enumerable/enumerators; these
   are quite efficient in the non-recursive case, but nesting them in the
   straightforward way makes them require a quadratic cost.
 - `Paper`, i.e. an implementation directly based on "Iterators revisited: proof
   rules and implementation" by Bart Jacobs, Erik Meijer, Frank Piessens and
   Wolfram Schulte; this implementation scales well, but has a significant
   overhead.
 - `Stackless`, is an implementation of the paper, but aimed at good
   performance; it avoids the stack allocation and takes advantage of tail calls
   to perform "internal iteration" in the `MoveNext` operation; this approach is
   in part inspired by F#
   [`GeneratedSequenceBase`](https://github.com/dotnet/fsharp/blob/b73be1584c2a4ea3228b80cc1569e3b1b741cf33/src/FSharp.Core/seqcore.fs#L472),
   but it has been extended to also support efficient recursion in non-tail
   position (you can see what F# does
   [here](https://sharplab.io/#v2:EYLgxg9gTgpgtADwGwBYA0AbEAzAzgHwxgBcACASwBMYBDDU4UmUgXlNxgEdSBvAWABQpYaSJkAtgFdiNYEVIJWDQSNIB3ABbl5igDxtmlCCtUiAnuRgZKCk6YWldcBwGpSARkEBfQYLGlYMFIZbQYmJQ5ufiERcmww/XDiDRgAOztTCysbYAzVLOsAQmCaUIAKYBd3AEomb18Bf0DSFJoc8LZI3gy4hINglPSY+wLKYtb2svgavPNLazqBHwEgA))

`Current/OriginalExamples.cs` contains 3 cases that have been automatically
desugared by Roslyn, decompiled with ILSpy and (after replacing
([^A-Za-z])<([^>]*)?> with $1__gen$2__ to have valid identifiers) saved as
`Current/DecompiledExamples.cs`.

`Paper/Examples.cs` and `Stackless/Examples.cs` contain the same cases; they
have been implemented starting from `Current/DecompiledExamples.cs` with
(ideally) only the changes needed to switch implementation.

See the other files for:
 - some [notes](NOTES.md) on some implementation choices to get good performance
 - the results of some basic [micro-benchmarks](BENCHMARKS.md)
 - an [implementation strategy](IMPLEMENTATION_STRATEGY.md) that satisfies
   several requirements meant to prevent regressions and compatibility issues

### Future work

This is currently some hack to get the feeling of how much recursive enumeration
would degrade performance.

Several issues still needs to be investigated and/or fixed:
 - where does `Decompiled` differ from `Original`? how hard would it be to have
   a `Decompiled` implementation that is compiled to the same IL as `Original`?
 - handling of exceptions should be fixed (some parts have been left in/changed
   to align to something reasonable, but many parts are still missing)
 - is the interface acceptable? IEnumerator uses `Current`; is it ok (maybe even
   "better") to use a `ref`/`out` instead?
 - only some trivial comparisons have been made; more interesting cases could
   be investigated too, for example:
    - adapter overhead (`RootEnumerator` and `EnumeratorAdaptor`)
    - inlining/devirtualization when the type of the enumerable is known
    - how do `Append`/`Prepend`/`Concat` perform?
