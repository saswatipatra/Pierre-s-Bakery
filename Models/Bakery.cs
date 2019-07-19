using System;
namespace PierreBakery.Models
{
  class Bread
  {
    private string _breadName;
    private int _breadPrice;

    public Bread(string breadName, int breadPrice)
    {
      _breadName = breadName;
      _breadPrice = breadPrice;
    }
    public static void Bill(int bread, int pastry)
    {
      int bill=0;
      if (bread!=0)
      {
        bill= bill + (bread*5);
      }
      if (pastry!=0)
      {
        bill= bill + (pastry*2);
      }
      Console.WriteLine("your total bill is: "+ bill);
    }
  }
  class Pastry
  {
    private string _pastryName;
    private int _pastryPrice;

    public Pastry(string pastryName, int pastryPrice)
    {
      _pastryName = pastryName;
      _pastryPrice = pastryPrice;
    }
    public static void Bill(int bread, int pastry)
    {
      int bill=0;
      if (bread!=0)
      {
        bill= bill + (bread*5);
      }
      if (pastry!=0)
      {
        bill= bill + (pastry*2);
      }
      Console.WriteLine("your total bill is: "+ bill);
    }
  }
}
