using System;
using System.Collections.Generic;
using PierreBakery.Models;
namespace PierreBakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcom to Pierre Bakery, Pierre offers the following deals: ");
      Console.WriteLine("Would you like to buy some Bread Loaf, enter yes/Y/y for yes: ");
      string userBread= Console.ReadLine();
      Console.WriteLine("Would you like to buy some Pastry, enter yes/Y/y for yes: ");
      string userPastry= Console.ReadLine();
      if (userBread=="yes" || userBread=="Yes"|| userBread=="y"|| userBread=="Y")
      {
        Console.WriteLine("\u25A0 Bread: Buy any 2, get 1 free. A single loaf costs $5.");
        Console.WriteLine("Below is the list of bread loaf we have:");
        Bread bread1 = new Bread("Whole-Wheat", 5);
        Bread bread2 = new Bread("Sourdough", 5);
        Bread bread3 = new Bread("Rye", 5);
        Bread bread4 = new Bread("Multigrain", 5);
        List<Bread> Breads = new List<Bread>() { bread1, bread2, bread3, bread4 };
        foreach(Bread allbread in Breads)
        {
          Console.WriteLine("----------------------");
          Console.WriteLine(allbread.GetBreadName());
        }
        Console.WriteLine("Enter no. of bread loaf you want: ");
        int numBread= int.Parse(Console.ReadLine());
        if (numBread!= 0)
        {
          int breadAmt= Bread.BreadBill(numBread);
          Console.WriteLine("No. of bread you order: " + numBread + " your bill: " + breadAmt + "$");
        }
      }
      if (userPastry=="yes" || userPastry=="Yes"|| userPastry=="y"|| userPastry=="Y")
      {
        Console.WriteLine("\u25A0 Pastry: Buy 1 for $2 or 3 for $5.");
        Console.WriteLine("Below is the list of Pastry we have:");
        Pastry pastry1 = new Pastry("Chocolate", 2);
        Pastry pastry2 = new Pastry("vanilla", 2);
        Pastry pastry3 = new Pastry("strawberry", 2);
        Pastry pastry4 = new Pastry("blackforest", 2);
        List<Pastry> Pastrys = new List<Pastry>() { pastry1, pastry2, pastry3, pastry4 };
        foreach(Pastry allpastry in Pastrys)
        {
          Console.WriteLine("----------------------");
          Console.WriteLine(allpastry.GetPastryName());
        }
        Console.WriteLine("Enter no. of Pastry you want: ");
        int numPastry= int.Parse(Console.ReadLine());
        if (numPastry!= 0)
        {
          int pastryAmt= Pastry.PastryBill(numPastry);
          Console.WriteLine("No. of bread you order: " + numPastry + " your bill: " + pastryAmt + "$");
        }
      }
    }
  }
}
