using System;
using PierreBakery.Models;
namespace PierreBakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcom to Pierre Bakery, Pierre offers the following deals: ");
      Console.WriteLine("\u25C9" + " Bread: Buy 2, get 1 free. A single loaf costs $5.");
      Console.WriteLine("\u25C9" + "Pastry: Buy 1 for $2 or 3 for $5.");
      Console.WriteLine("Enter no. of Bread Loaf you want: ");
      int breadNum= int.Parse(Console.ReadLine());
      Console.WriteLine("Enter no. of Pastry you want: ");
      int pastryNum= int.Parse(Console.ReadLine());
      Bakery.Bill(breadNum,pastryNum);
    }
  }
}
