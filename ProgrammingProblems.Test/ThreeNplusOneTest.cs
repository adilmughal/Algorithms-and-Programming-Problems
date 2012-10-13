using NUnit.Framework;
using ProgrammingProblems;

[TestFixture]
public class ThreeNplusOneTest
{
    [Test]
    public void ThreeNplusOneTest1()
    {
        int actualMaxCycleLength = Adhoc.ThreeNplusOne(1, 10);
        Assert.AreEqual(20, actualMaxCycleLength);
    }


    [Test]
    public void ThreeNplusOneTest2()
    {
        int actualMaxCycleLength = Adhoc.ThreeNplusOne(100, 200);
        Assert.AreEqual(125, actualMaxCycleLength);
    }


    [Test]
    public void ThreeNplusOneTest3()
    {
        int actualMaxCycleLength = Adhoc.ThreeNplusOne(201, 210);
        Assert.AreEqual(89, actualMaxCycleLength);
    }
}