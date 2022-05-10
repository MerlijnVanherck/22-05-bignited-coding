using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HarmonicSeries.Test;

[TestClass]
public class HarmonicSeriesTest
{
    [TestMethod]
    public void TestSum5()
    {
        Assert.AreEqual("2.2833", HarmonicSeries.Sum(5));
    }

    [TestMethod]
    public void TestSum20()
    {
        Assert.AreEqual("3.5977", HarmonicSeries.Sum(20));
    }

    [TestMethod]
    public void TestSum0()
    {
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => HarmonicSeries.Sum(0));
    }

    [TestMethod]
    public void TestSumNegative()
    {
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => HarmonicSeries.Sum(-1));
    }
}
