using BenchmarkDotNet.Attributes;
using Current;

using T = int;

public class Benches
{
    [Params(10, 100, 1000)]
    public int N;

    [ParamsAllValues]
    public ImplStyle Impl;

    [ParamsAllValues]
    public IterStyle Iter;

    IEnumerable<T> source = [];

    [GlobalSetup]
    public void GlobalSetup()
    {
        source = (Impl, Iter) switch
        {
            (ImplStyle.Original, IterStyle.Ideal) => OriginalExamples.FromToIdeal(0, N),
            (ImplStyle.Original, IterStyle.Tail) => OriginalExamples.FromToTail(0, N),
            (ImplStyle.Original, IterStyle.Head) => OriginalExamples.FromToHead(0, N),

            (ImplStyle.Decompiled, IterStyle.Ideal) => DecompiledExamples.FromToIdeal(0, N),
            (ImplStyle.Decompiled, IterStyle.Tail) => DecompiledExamples.FromToTail(0, N),
            (ImplStyle.Decompiled, IterStyle.Head) => DecompiledExamples.FromToHead(0, N),

            (ImplStyle.Paper, IterStyle.Ideal) => Paper.Examples.FromToIdeal(0, N),
            (ImplStyle.Paper, IterStyle.Tail) => Paper.Examples.FromToTail(0, N),
            (ImplStyle.Paper, IterStyle.Head) => Paper.Examples.FromToHead(0, N),

            (ImplStyle.Stackless, IterStyle.Ideal) => Stackless.Examples.FromToIdeal(0, N),
            (ImplStyle.Stackless, IterStyle.Tail) => Stackless.Examples.FromToTail(0, N),
            (ImplStyle.Stackless, IterStyle.Head) => Stackless.Examples.FromToHead(0, N),

            _ => throw new ArgumentException("Unsupported combination"),
        };
    }

    [Benchmark]
    public T Sum()
    {
        T sum = 0;
        using var enumerator = source.GetEnumerator();
        while (enumerator.MoveNext())
        {
            var item = enumerator.Current;
            sum += item;
        }
        return sum;
    }
}
