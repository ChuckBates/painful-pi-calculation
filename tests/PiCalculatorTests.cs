using System;
using NUnit.Framework;
using src;

namespace tests
{
  public class Tests
  {
    readonly decimal PiConstant = (decimal)Math.PI;

    [Test]
    public void When_evaluating_with_ultra_low_precision()
    {
      var expected = 1;
      var results = PiCalculator.Calculate(PiConstant, 1m);

      Assert.That(results, Is.Not.Null);
      Assert.That(results.Iterations, Is.Not.Null);
      Assert.That(results.Iterations, Is.EqualTo(expected));
      Assert.That(results.Value, Is.EqualTo(4m));
    }

    [Test]
    public void When_evaluating_with_low_precision()
    {
      var precision = 0.01m;
      var expected = 100;
      var results = PiCalculator.Calculate(PiConstant, precision);

      Assert.That(results.Iterations, Is.EqualTo(expected));
      Assert.That(results.Value, Is.EqualTo(PiConstant).Within(precision));
    }

    [Test]
    public void When_evaluating_with_moderate_precision()
    {
      var precision = 0.00001m;
      var expected = 100000;
      var results = PiCalculator.Calculate(PiConstant, precision);

      Assert.That(results.Iterations, Is.EqualTo(expected));
      Assert.That(results.Value, Is.EqualTo(PiConstant).Within(precision));
    }

    [Test]
    public void When_evaluating_with_moderate_high_precision()
    {
      var precision = 0.0000001m;
      var expected = 10000000;
      var results = PiCalculator.Calculate(PiConstant, precision);

      Assert.That(results.Iterations, Is.EqualTo(expected));
      Assert.That(results.Value, Is.EqualTo(PiConstant).Within(precision));
    }

    [Test]
    public void When_evaluating_with_invalid_constant()
    {
      Assert.Throws<ArgumentException>(() => PiCalculator.Calculate(-3.14m, 0.01m));
    }

    [Test]
    public void When_evaluating_with_invalid_precision()
    {
      Assert.Throws<ArgumentException>(() => PiCalculator.Calculate(3.14m, -0.01m));
    }
  }
}