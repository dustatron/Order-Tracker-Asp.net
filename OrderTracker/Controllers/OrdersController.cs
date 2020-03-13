using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using OrderTracker.Models;

namespace OrderTracker.Controllers
{
  public class OrdersController : Controller
  {

    [HttpGet("/orders")]
    public ActionResult Index()
    {
      List<Order> allOrders = Order.GetAll();
      return View(allOrders);
    }

    [HttpGet("/vender/{id}/orders/new")]
    public ActionResult New(int id)
    {
      Vender vender = Vender.GetVender(id);
      return View(vender);
    }
    [HttpPost("/vender/{id}/orders/create")]
    public ActionResult Create(int id, string productName, int quantity, string deliverBy, int venderId, string venderName)
    {
      Order order = new Order(productName, quantity, deliverBy, venderId, venderName);
      Order.AddToVender(id, order);
      return RedirectToAction("Index");
    }

    [HttpGet("/vender/{id}/orders/show")]
    public ActionResult Show(int id)
    {

      Vender thisVender = Vender.GetVender(id);
      List<Order> thisVendersOrders = thisVender.OrdersList;
      Dictionary<string, object> orderDetails = new Dictionary<string, object>()
      {
        {"Vender", thisVender},
        {"Orders", thisVendersOrders}
      };
      return View(orderDetails);
    }

    [HttpGet("/vender/{venderId}/order/{orderId}/edit")]
    public ActionResult Edit(int orderId)
    {
      Order thisOrder = Order.GetOrder(orderId);
      return View(thisOrder);
    }

    [HttpPost("/vender/{venderId}/order/{orderId}/update")]
    public ActionResult Update(int venderId, int orderId, string productName, int quantity, string deliverBy)
    {
      Order.Update(orderId, productName, quantity, deliverBy);
      Vender.UpdateOrder(venderId, orderId, productName, quantity, deliverBy);
      return RedirectToAction("Index");
    }

    [HttpGet("/vender/{venderId}/order/{orderId}/delete")]
    public ActionResult Delete(int venderId, int orderId)
    {
      Vender.DeleteOrder(venderId, orderId);
      return View();
    }


  }
}