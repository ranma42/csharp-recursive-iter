# How to keep things fast

These are just a bunch of observations I made while working on this repo.
Ideally I should clean them up and explain them mre in depth.

## Use `null` as guard value
Using `null` to terminate the iteration basically matches what
`IEnumerator.MoveNext()` does; specifically, the resulting code is actually
testing whether the return value is a known constant, that is also particularly
efficient to compare in most CPUs (for example on `x86` the `test` opcode can
check if a register is `null`/`false`/`0`).

## Avoid an explicit stack
The paper proposes an implementation in which nested iterators are pushed into a
stack and then the top of the stack is used for element iteration.

This is conceptually simple, but a more efficient implementation is possible,
that removes additional allocations and even enables further optimizations: the
values of the stack can be held implicitly within each enumerator, by creating
them with an optional "continuation", i.e. the enumerator that will be used
after the one being created completes.

## Return only when you are ready
Assuming that each enumerator has access to its continuation, it is possible to
avoid returning a `Done` state (which in the `Paper` implementation is used to
command the switch to the next enumerator in the stack) and instead immediately
jump into the continuation.

This is particularly effective when the call is tail optimized, as it basically
amounts to jumping to the next `TryMoveNext` implementation.

## Set `Current` where it is needed
Accesses to the `Current` property are quite fast, but setting the value
directly from `TryMoveNext` is faster as it avoids another indirect call.
