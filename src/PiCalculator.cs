
using System.Diagnostics;

namespace src
{
  public class PiCalculator
  {
    readonly decimal HighestPrecisionPiConstant = 3.1415926535897932384626433833m;

    public static void Main(string[] args) { }

    public static (ulong Iterations, decimal Value) Calculate(decimal constant, decimal precision)
    {
      var stopwatch = Stopwatch.StartNew();

      if (constant <= 0 || precision <= 0)
      {
        throw new ArgumentException("Invalid Argument: cannot be negative");
      }

      decimal calculatedValue = 4m;
      decimal oddDenominator = 3m;
      var positiveSign = false;
      ulong iterationCounter = 1;
      while (Math.Abs(calculatedValue - constant) > precision)
      {
        if (iterationCounter % 10000000 == 0)
        {
          Console.WriteLine($"Calculated for {iterationCounter} iterations in {stopwatch.Elapsed.TotalSeconds} seconds. Currently calculated value {calculatedValue} is within {Math.Abs(calculatedValue - constant)}");
        }

        var nextTerm = 4m / oddDenominator;
        calculatedValue = positiveSign ? calculatedValue + nextTerm : calculatedValue - nextTerm;

        positiveSign = !positiveSign;
        oddDenominator += 2;
        iterationCounter++;
      }

      Console.WriteLine($"{iterationCounter} iterations in {stopwatch.Elapsed.TotalSeconds} seconds needed to calculate Pi value {calculatedValue} to within {precision} of constant");

      return (iterationCounter, calculatedValue);
    }
  }
}