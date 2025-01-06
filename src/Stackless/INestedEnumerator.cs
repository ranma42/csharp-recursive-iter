using System;

namespace Stackless;

public interface INestedEnumerator<T> : IDisposable
{
    INestedEnumerator<T>? TryMoveNext(ref T item);
}
