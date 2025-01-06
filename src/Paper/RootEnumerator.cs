using System;
using System.Collections;
using System.Collections.Generic;

namespace Paper;

public class RootEnumerator<T> : IEnumerator<T>
{
    private readonly Stack<INestedEnumerator<T>> stack = new();

    public RootEnumerator(INestedEnumerator<T> e)
    {
        stack.Push(e);
    }

    public T Current { get; private set; }

    object IEnumerator.Current => Current!;

    public void Dispose()
    {
        while (stack.TryPop(out var e))
        {
            e.Dispose();
        }
    }

    public bool MoveNext()
    {
        while (stack.TryPeek(out var e))
        {
            switch (e.NestedMoveNext())
            {
                case NestedEnumState.Value:
                    Current = e.Current;
                    return true;
                case NestedEnumState.Enumerator:
                    stack.Push(e.CurrentEnumerator!);
                    break;
                case NestedEnumState.Done:
                    stack.Pop();
                    break;
                case NestedEnumState.TailEnumerator:
                    stack.Push(stack.Pop().CurrentEnumerator!);
                    break;
            }
        }

        return false;
    }

    public void Reset() => throw new NotSupportedException();
}
