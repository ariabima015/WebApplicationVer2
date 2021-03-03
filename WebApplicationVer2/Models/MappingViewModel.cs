using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationVer2.Models
{
    public class MappingViewModel
    {
        [DisplayName("Warehouse")]
        public List<int> WarehouseIdList { get; set; }
        [DisplayName("City")]
        public int GroupId { get; set; }
        public  List<MappingIndexViewModel> MappingList { get; set; }
    }
}
