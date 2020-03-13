using System.Collections.Generic;

namespace OrderTracker.Models
{
  class Order
  {
    public static List<Order> MaserOrderList { get; set; } = new List<Order>(5);
    public int IdCounter = 0;

    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public string DeliverBy { get; set; }
    public int Id { get; set; }
    public int VenderId { get; set; }

    public string VenderName { get; set; }


    Order(string productName, int quantity, string deliverBy, int venderId, string venderName)
    {
      ProductName = productName;
      Quantity = quantity;
      DeliverBy = deliverBy;
      VenderId = venderId;
      VenderName = venderName;
      Id = IdCounter++;

      MaserOrderList.Add(this);
    }

  }

}