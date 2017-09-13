using System;

namespace NoforNoIf
{
  internal static class Program
  {
    private static int _i;

    private static void Main(string[] args)
    {
      Action<string> display = Console.WriteLine;
      display("Display all numbers from 1 to 100 without using for loop nor if");
      _i = 1;
      SixtyFour();
      ThirtyTwo();
      Four();
      display("Press any key to exit:");
      Console.ReadKey();
    }

    private static void One() { Console.WriteLine(_i++); }
    private static void Two() { One(); One(); }
    private static void Four() { Two(); Two(); }
    private static void Eight() { Four(); Four(); }
    private static void Sixteen() { Eight(); Eight(); }
    private static void ThirtyTwo() { Sixteen(); Sixteen(); }
    private static void SixtyFour() { ThirtyTwo(); ThirtyTwo(); }
  }
}