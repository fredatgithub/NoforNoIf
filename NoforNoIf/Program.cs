using System;


namespace NoforNoIf
{
  class Program
  {
    public int i = 1;
    static void Main(string[] args)
    {
      sixtyFour();
      thirtyTwo();
      four();
      Console.ReadKey();
    }

    public static void one() { Console.WriteLine(i++); }
    public void two() { one(); one(); }
    public void four() { two(); two(); }
    public void eight() { four(); four(); }
    public void sixteen() { eight(); eight(); }
    public void thirtyTwo() { sixteen(); sixteen(); }
    public void sixtyFour() { thirtyTwo(); thirtyTwo(); }
  }
}