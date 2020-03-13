using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using OrderTracker.Models;

namespace OrderTrack.Controllers
{
  public class VendersController : Controller
  {
    [HttpGet("/venders")]
    public ActionResult Index()
    {
      return View();
    }
  }

}