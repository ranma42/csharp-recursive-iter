using System.Collections.Generic;

namespace Stackless;

public class EnumeratorAdaptor<T>(IEnumerable<T> source, INestedEnumerator<T>? continuation) : INestedEnumerator<T>
{
    private readonly IEnumerator<T> e = source.GetEnumerator();

    public void Dispose() => e.Dispose();

    INestedEnumerator<T>? INestedEnumerator<T>.TryMoveNext(ref T item)
    {
        if (e.MoveNext())
        {
            item = e.Current;
            return this;
        }

        return continuation?.TryMoveNext(ref item);
    }
}
