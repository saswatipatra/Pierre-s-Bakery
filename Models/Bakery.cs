using System;
namespace PierreBakery.Models
{
  class Bakery
  {
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
