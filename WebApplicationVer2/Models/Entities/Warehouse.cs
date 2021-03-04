using System.ComponentModel;

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
