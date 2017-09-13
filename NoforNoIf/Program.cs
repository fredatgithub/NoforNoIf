using System;

namespace NoforNoIf
{
  internal class Program
  {
    public int I = 1;

    private static void Main(string[] args)
    {
      SixtyFour();
      ThirtyTwo();
      Four();
      Console.ReadKey();
    }

    private void One() { Console.WriteLine(I++); }
    private void Two() { One(); One(); }
    private void Four() { Two(); Two(); }
    private void Eight() { Four(); Four(); }
    private void Sixteen() { Eight(); Eight(); }
    private void ThirtyTwo() { Sixteen(); Sixteen(); }
    private void SixtyFour() { ThirtyTwo(); ThirtyTwo(); }
  }
}