using System.Collections.Generic;

namespace OrderTracker.Models
{
  class Vender
  {
    public int IdCounter = 0;
    private List<Vender> _vendersList = new List<Vender>(5);
    public string VenderName { get; set; }
    public string Address { get; set; }
    public string Description { get; set; }
    public int Id { get; set; }

    public List<Order> OrdersList { get; set; }

    Vender(string name, string address, string decription)
    {
      VenderName = name;
      Address = address;
      Description = decription;
      Id = IdCounter++;
      OrdersList = new List<Order>(5);

      _vendersList.Add(this);
    }
  }


}