using BenchmarkDotNet.Attributes;
using Stackless;
using T = int;

public class StacklessBenches
{
    [Params(10, 100, 1000)]
    public int N;

    [ParamsAllValues]
    public IterStyle Iter;

    INestedEnumerable<T> source = default!;

    [GlobalSetup]
    public void GlobalSetup()
    {
        source = Iter switch
        {
            IterStyle.Ideal => Examples.FromToIdeal(0, N),
            IterStyle.Tail => Examples.FromToTail(0, N),
            IterStyle.Head => Examples.FromToHead(0, N),

            _ => throw new ArgumentException("Unsupported combination"),
        };
    }

    [Benchmark]
    public T Sum()
    {
        T sum = 0;
        var enumerator = source.GetNestedEnumerator(null);
        T item = default!;
        while (enumerator.TryMoveNext(ref item) is { } newEnum)
        {
            sum += item;
            enumerator = newEnum;
        }

        return sum;
    }
}
