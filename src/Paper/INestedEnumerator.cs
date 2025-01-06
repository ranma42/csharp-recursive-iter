using System;

namespace Paper;

public interface INestedEnumerator<T> : IDisposable
{
    T Current { get; }
    INestedEnumerator<T>? CurrentEnumerator { get; }
    NestedEnumState NestedMoveNext();
    // public static NestedEnumerator<T> GetNestedEnumerator(IEnumerable<T> c)
    // {
    //     NestedEnumerable<T>? nc = c as NestedEnumerable<T>;
    //     return nc == null ? new EnumeratorAdaptor<T>(c) : nc.GetNestedEnumerator();
    // }
}
