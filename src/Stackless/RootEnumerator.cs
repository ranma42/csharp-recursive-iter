using System;
using System.Collections;
using System.Collections.Generic;

namespace Stackless;

public class RootEnumerator<T>(INestedEnumerator<T> source) : IEnumerator<T>
{
    private INestedEnumerator<T>? _source = source;

    private T _current;

    public T Current => _current;

    object IEnumerator.Current => Current!;

    public bool MoveNext()
    {
        _source = _source?.TryMoveNext(ref _current);
        return _source != null;
    }

    public void Dispose() => _source?.Dispose();

    public void Reset() => throw new NotSupportedException();
}
