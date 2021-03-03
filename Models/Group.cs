using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationVer2.Models
{
    public class Group
    {
        public int GroupId { get; set; }
        public string Name { get; set; }
        public List<City> Cities { get; set; }
        public Warehouse Warehouses { get; set; }
    }
}
