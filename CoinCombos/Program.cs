using System;
using CoinCombos.Methods;

namespace CoinCombos
{
  public class Program
  {
    public static void Main()
    {
      Console.Write("How much cash you got?!  ");
      int changeAmount = (int)(float.Parse(Console.ReadLine()) * 100);
      Combos newCombo = new Combos(changeAmount);
      newCombo.MakeChange();
      Console.WriteLine("Quarters: " + newCombo.Change[0]);
      Console.WriteLine("Dimes: " + newCombo.Change[1]);
      Console.WriteLine("Nickles: " + newCombo.Change[2]);
      Console.WriteLine("Pennies: " + newCombo.Change[3]);
    } 
  }
}