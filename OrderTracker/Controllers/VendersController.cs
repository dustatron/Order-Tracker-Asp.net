using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using OrderTracker.Models;

namespace OrderTrack.Controllers
{
  public class VendersController : Controller
  {
    //Read
    [HttpGet("/venders")]
    public ActionResult Index()
    {
      List<Vender> allVenders = Vender.GetAllVenders();
      return View(allVenders);
    }
    //Create get
    [HttpGet("/venders/New")]
    public ActionResult New()
    {
      return View();
    }

    //Create post
    [HttpPost("/venders/create")]
    public ActionResult Create(string venderName, string address, string description)
    {
      Vender vender = new Vender(venderName, address, description);

      return RedirectToAction("Index");
    }

    //Update view
    [HttpGet("/vender/{id}")]
    public ActionResult Edit(int id)
    {
      Vender vender = Vender.GetVender(id);
      return View(vender);
    }


    //Update Post
    [HttpPost("/venders/{id}")]
    public ActionResult Update(int id, string venderName, string address, string description)
    {
      Vender.Update(id, venderName, address, description);
      return RedirectToAction("Index");
    }

    //Destroy
    [HttpPost("/venders/{id}/delete")]
    public ActionResult Delete(int id)
    {
      Vender.Delete(id);
      return View();
    }
  }

}