using System.Collections;
using System.Collections.Generic;

namespace Paper;

public interface INestedEnumerable<T> : IEnumerable<T>
{
    INestedEnumerator<T> GetNestedEnumerator();
    IEnumerator<T> IEnumerable<T>.GetEnumerator() => new RootEnumerator<T>(GetNestedEnumerator());
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
