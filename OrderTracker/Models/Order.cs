using System.Collections.Generic;

namespace OrderTracker.Models
{
  public class Order
  {
    public static List<Order> MasterOrderList { get; set; } = new List<Order>(5);
    public static int IdCounter = 0;

    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public string DeliverBy { get; set; }
    public int Id { get; set; }
    public int VenderId { get; set; }

    public string VenderName { get; set; }


    public Order(string productName, int quantity, string deliverBy, int venderId, string venderName)
    {

      ProductName = productName;
      Quantity = quantity;
      DeliverBy = deliverBy;
      VenderId = venderId;
      VenderName = venderName;
      Id = IdCounter++;

      MasterOrderList.Add(this);
    }

    public static List<Order> GetAll()
    {
      return MasterOrderList;
    }

    public static Order GetOrder(int id)
    {
      foreach (var order in MasterOrderList)
      {
        if (id == order.Id)
        {
          return order;
        }
      }
      return MasterOrderList[0];
    }

    public static void Update(int id, string productName, int quantity, string deliverBy)
    {
      Order thisOrder = GetOrder(id);
      thisOrder.ProductName = productName;
      thisOrder.Quantity = quantity;
      thisOrder.DeliverBy = deliverBy;

    }

    public static void Delete(int id)
    {
      Order thisOrder = GetOrder(id);
      MasterOrderList.Remove(thisOrder);
    }

    public static void AddToVender(int id, Order order)
    {
      Vender vender = Vender.GetVender(id);
      vender.OrdersList.Add(order);
    }

    // public static void UpdateOrder(int id, string productName, int quantity, string deliverBy)
    // {
    //   Order thisOrder = GetOrder(id);
    //   thisOrder.ProductName = productName;
    //   thisOrder.Quantity = quantity;
    //   thisOrder.DeliverBy = deliverBy;
    // }

    public static void DeleteOrder(int id)
    {
      for (int i = 0; i < MasterOrderList.Count; i++)
      {
        if (id == MasterOrderList[i].Id)
        {
          MasterOrderList.RemoveAt(i);
        }
      }
    }


  }

}