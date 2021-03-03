using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationVer2.Models
{
    public class Warehouse
    {
        [DisplayName("Warehouse Id")]
        public int WarehouseId { get; set; }
        public string Name { get; set; }
        [DisplayName("Group Id")]
        public int? GroupId { get; set; }
        public Group Group { get; set; }
    }
}
