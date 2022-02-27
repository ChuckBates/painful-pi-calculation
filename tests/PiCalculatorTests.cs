using NUnit.Framework;
using src;

namespace tests;

public class Tests
{
    PiCalculator ClassUnderTest;
    
    [SetUp]
    public void Setup()
    {
        ClassUnderTest = new PiCalculator();
    }

    [Test]
    public void When_making_sure_bad_things_dont_happen()
    {
        Assert.DoesNotThrow(() => ClassUnderTest.Calculate(0.001));
    }
}