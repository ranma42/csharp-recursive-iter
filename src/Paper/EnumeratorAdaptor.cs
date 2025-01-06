using System.Collections.Generic;

namespace Paper;

public class EnumeratorAdaptor<T>(IEnumerable<T> c) : INestedEnumerator<T>
{
    private readonly IEnumerator<T> e = c.GetEnumerator();

    public T Current => e.Current;

    public INestedEnumerator<T> CurrentEnumerator => throw new System.NotImplementedException();

    public void Dispose() => e.Dispose();

    public NestedEnumState NestedMoveNext() => e.MoveNext() ? NestedEnumState.Value : NestedEnumState.Done;
}
