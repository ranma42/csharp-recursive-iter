using Current;

namespace test;

public class UnitTests
{
    private readonly int[] referenceData = OriginalExamples.FromToIdeal(0, 10).ToArray();

    [Fact]
    public void TestOriginalFromToIdeal()
    {
        Assert.Equal(referenceData, OriginalExamples.FromToIdeal(0, 10));
    }

    [Fact]
    public void TestOriginalFromToHead()
    {
        Assert.Equal(referenceData, OriginalExamples.FromToHead(0, 10));
    }

    [Fact]
    public void TestOriginalFromToTail()
    {
        Assert.Equal(referenceData, OriginalExamples.FromToTail(0, 10));
    }

    [Fact]
    public void TestDecompiledFromToIdeal()
    {
        Assert.Equal(referenceData, DecompiledExamples.FromToIdeal(0, 10));
    }

    [Fact]
    public void TestDecompiledFromToHead()
    {
        Assert.Equal(referenceData, DecompiledExamples.FromToHead(0, 10));
    }

    [Fact]
    public void TestDecompiledFromToTail()
    {
        Assert.Equal(referenceData, DecompiledExamples.FromToTail(0, 10));
    }

    [Fact]
    public void TestPaperFromToIdeal()
    {
        Assert.Equal(referenceData, Paper.Examples.FromToIdeal(0, 10));
    }

    [Fact]
    public void TestPaperFromToHead()
    {
        Assert.Equal(referenceData, Paper.Examples.FromToHead(0, 10));
    }

    [Fact]
    public void TestPaperFromToTail()
    {
        Assert.Equal(referenceData, Paper.Examples.FromToTail(0, 10));
    }

    [Fact]
    public void TestStacklessFromToIdeal()
    {
        Assert.Equal(referenceData, Stackless.Examples.FromToIdeal(0, 10));
    }

    [Fact]
    public void TestStacklessFromToHead()
    {
        Assert.Equal(referenceData, Stackless.Examples.FromToHead(0, 10));
    }

    [Fact]
    public void TestStacklessFromToTail()
    {
        Assert.Equal(referenceData, Stackless.Examples.FromToTail(0, 10));
    }
}
