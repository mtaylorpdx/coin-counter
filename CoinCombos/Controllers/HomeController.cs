using Microsoft.AspNetCore.Mvc;
using CoinCombos.Models;
using System;

namespace CoinCombos.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form() { return View(); }

    [Route("/Coins")]
    public ActionResult Coins(string total)
    {
      Combos newCombo = new Combos(total);
      return View("Coins", newCombo);
    }
  }
}