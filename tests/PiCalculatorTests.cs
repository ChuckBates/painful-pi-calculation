using NUnit.Framework;
using src;

namespace tests
{
  public class Tests
  {
    [Test]
    public void When_making_sure_bad_things_dont_happen()
    {
      Assert.DoesNotThrow(() => PiCalculator.Calculate(0.001));
    }
  }
}