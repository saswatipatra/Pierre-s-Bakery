using System;
using System.Collections.Generic;
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
    public string GetBreadName()
    {
      return _breadName;
    }
    public static int BreadBill(int breadNum)
    {
      int bill=0;
      bill= bill + (breadNum*5);
      return bill;
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
    public string GetPastryName()
    {
      return _pastryName;
    }
    public static int PastryBill(int pastry)
    {
      int pastryBill=0;
      pastryBill= pastryBill + (pastry*2);
      return pastryBill;
    }
  }
}
