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
    public int GetBreadPrice()
    {
      return _breadPrice;
    }
    public static int BreadBill(int breadNum, string name)
    {
      int bill=0;
      if(name=="Whole-Wheat" || name=="whole-wheat")
      {
        bill= bill + (breadNum*5);
        return bill;
      }
      else if (name=="Rye"||name=="rye")
      {
        bill= bill + (breadNum*6);
        return bill;
      }
      else if (name=="Multigrain"||name=="multigrain")
      {
        bill= bill + (breadNum*7);
        return bill;
      }
      else
      {
        bill= bill + (breadNum*4);
        return bill;
      }
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
      if (pastry%3==0){
        int cost= pastry/3;
        pastryBill= pastryBill + (cost*5);
        return pastryBill;
      }
      else if (pastry==1)
      {
        pastryBill= pastryBill + (pastry*2);
        return pastryBill;
      }
      else
      {
        int three=pastry/3;
        int remaining= (pastry-(three*3));
        pastryBill= pastryBill + (three*5) + (remaining*2);
        return pastryBill;
      }
    }
  }
}
