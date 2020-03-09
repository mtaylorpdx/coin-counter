using System;

namespace CoinCombos.Models
{
  public class Combos
  {
    public int[] Change {get;set;} = {0,0,0,0};
    public Combos(string pennies)
    {
      Change[3] = (int)(float.Parse(pennies) * 100);
      int[] coinAmounts = {25, 10, 5};
      for(int i = 0; i <3; i++)
      {
        while (Change[3] >= coinAmounts[i])
        {
          Change[3] -= coinAmounts[i];
          Change[i]++;
        }
      }
    }
  }
}