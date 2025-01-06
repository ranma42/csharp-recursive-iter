using System.Collections;
using System.Collections.Generic;

namespace Stackless;

public interface INestedEnumerable<T> : IEnumerable<T>
{
    INestedEnumerator<T> GetNestedEnumerator(INestedEnumerator<T>? src);

    IEnumerator<T> IEnumerable<T>.GetEnumerator() => new RootEnumerator<T>(GetNestedEnumerator(null));
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
