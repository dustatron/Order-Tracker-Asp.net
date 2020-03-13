using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Vender
  {
    public static int IdCounter = 0;
    private static List<Vender> _vendersList = new List<Vender>(5);
    public string VenderName { get; set; }
    public string Address { get; set; }
    public string Description { get; set; }
    public int Id { get; set; }

    public List<Order> OrdersList { get; set; }

    public Vender(string name, string address, string decription)
    {
      VenderName = name;
      Address = address;
      Description = decription;
      Id = IdCounter++;
      OrdersList = new List<Order>(5);

      _vendersList.Add(this);
    }

    public static List<Vender> GetAllVenders()
    {
      return _vendersList;
    }

    public static Vender GetVender(int id)
    {
      foreach (var vender in _vendersList)
      {
        if (id == vender.Id)
        {
          return vender;
        }
      }
      return _vendersList[0];
    }

    public static void Update(int id, string name, string address, string decription)
    {
      Vender thisVender = GetVender(id);
      List<Order> orderList = thisVender.OrdersList;
      thisVender.VenderName = name;
      thisVender.Address = address;
      thisVender.Description = decription;
    }

    public static void UpdateOrder(int venderId, int orderId, string productName, int quantity, string deliverBy)
    {
      Vender thisVender = GetVender(venderId);
      List<Order> OrdersList = thisVender.OrdersList;
      for (int i = 0; i < OrdersList.Count; i++)
      {
        if (orderId == OrdersList[i].Id)
        {
          OrdersList[i].ProductName = productName;
          OrdersList[i].Quantity = quantity;
          OrdersList[i].DeliverBy = deliverBy;
        }
      }

    }

    public static void Delete(int id)
    {
      Vender thisVender = GetVender(id);
      _vendersList.Remove(thisVender);
    }

    public static void DeleteOrder(int venderId, int orderId)
    {
      Vender thisVender = GetVender(venderId);
      List<Order> OrdersList = thisVender.OrdersList;
      for (int i = 0; i < OrdersList.Count; i++)
      {
        if (orderId == OrdersList[i].Id)
        {
          OrdersList.RemoveAt(i);
        }
      }

      Order.DeleteOrder(orderId);

    }

  }


}