using System;

namespace CoinCombos.Methods
{
  public class Combos
  {
    public int[] Change {get;set;} = {0,0,0,0};
    public Combos(int pennies)
    {
      Change[3] = pennies;
    }
    public void MakeChange()
    {
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