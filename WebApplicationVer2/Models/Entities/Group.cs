using System.Collections.Generic;
using System.ComponentModel;

namespace WebApplicationVer2.Models
{
    public class Group
    {
        [DisplayName("Group Id")]
        public int GroupId { get; set; }
        public string Name { get; set; }
        public List<City> Cities { get; set; }
        public List<Warehouse> Warehouses { get; set; }
    }
}
