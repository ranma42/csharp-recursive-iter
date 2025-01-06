using System.Collections.Generic;

namespace Current;

public static class OriginalExamples
{
    public static IEnumerable<int> FromToIdeal(int b, int e)
    {
        for (var x = b; x <= e; x++)
        {
            yield return x;
        }
    }

    public static IEnumerable<int> FromToTail(int b, int e)
    {
        if (b > e)
            yield break;

        yield return b;

        foreach (var item in FromToTail(b + 1, e))
        {
            yield return item;
        }
    }

    public static IEnumerable<int> FromToHead(int b, int e)
    {
        if (b > e)
            yield break;

        foreach (var item in FromToHead(b, e - 1))
        {
            yield return item;
        }

        yield return e;
    }
}