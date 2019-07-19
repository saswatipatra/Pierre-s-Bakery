using System;
using PierreBakery.Models;
namespace PierreBakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcom to Pierre Bakery, Pierre offers the following deals: ");
      Console.WriteLine("\u25A0 Pastry: Buy 1 for $2 or 3 for $5.");
      Console.WriteLine("Would you like to buy some Bread Loaf, enter yes/Y/y for yes: ");
      int userBread= Console.ReadLine();
      Console.WriteLine("Would you like to buy some Pastry, enter yes/Y/y for yes: ");
      int userBread= Console.ReadLine();
      // int userPastry= int.Parse(Console.ReadLine());
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
          Console.WriteLine(allbread.GetName());
        }

        Bakery.bread(call...)
      }
      if (userPastry=="yes" || userPastry=="Yes"|| userPastry=="y"|| userPastry=="Y")
      {
      Bakery.Bill(breadNum,pastryNum);
      }
    }
  }
}
