using Current;

namespace test;

public class LinqTests
{
    private readonly int[] referenceData = OriginalExamples.FromToIdeal(0, 10).ToArray();

    [Fact]
    public void TestSelectIdeal()
    {
        Assert.Equal(
            referenceData.Select(x => x + 1),
            Stackless.Examples.FromToIdeal(0, 10).Select(x => x + 1));
    }

    [Fact]
    public void TestSelectHead()
    {
        Assert.Equal(
            referenceData.Select(x => x + 1),
            Stackless.Examples.FromToHead(0, 10).Select(x => x + 1));
    }

    [Fact]
    public void TestSelectTail()
    {
        Assert.Equal(
            referenceData.Select(x => x + 1),
            Stackless.Examples.FromToTail(0, 10).Select(x => x + 1));
    }

    [Fact]
    public void TestWhereIdeal()
    {
        Assert.Equal(
            referenceData.Where(x => x % 2 == 0),
            Stackless.Examples.FromToIdeal(0, 10).Where(x => x % 2 == 0));
    }

    [Fact]
    public void TestWhereHead()
    {
        Assert.Equal(
            referenceData.Where(x => x % 2 == 0),
            Stackless.Examples.FromToHead(0, 10).Where(x => x % 2 == 0));
    }

    [Fact]
    public void TestWhereTail()
    {
        Assert.Equal(
            referenceData.Where(x => x % 2 == 0),
            Stackless.Examples.FromToTail(0, 10).Where(x => x % 2 == 0));
    }
}
