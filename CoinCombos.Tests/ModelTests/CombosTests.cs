using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using CoinCombos.Methods;

namespace CoinCombos.Tests
{
  [TestClass]
  public class CombosTests
  {
    [TestMethod]
    public void ComboConstructor_SetsPennies_56()
    {
      Combos newCombo = new Combos(56);
      Assert.AreEqual(56, newCombo.Change[3]);
    }
    [TestMethod]
    public void MakeChange_DecreasePennies_1()
    {
      Combos newCombo = new Combos(51);
      newCombo.MakeChange();
      Assert.AreEqual(1, newCombo.Change[3]);
    }
    [TestMethod]
    public void MakeChange_IncreaseQuarters_2()
    {
      Combos newCombo = new Combos(41);
      newCombo.MakeChange();
      int[] correct = {1,1,1,1};
      CollectionAssert.AreEqual(correct, newCombo.Change);
    }
  }
}