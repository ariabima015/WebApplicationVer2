using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationVer2.Models
{
    public class MappingViewModel
    {
        [DisplayName("Warehouse")]
        [Required]
        public List<int> WarehouseIdList { get; set; }
        [DisplayName("City")]
        [Required]
        public int GroupId { get; set; }
        public List<MappingIndexViewModel> MappingList { get; set; }
    }
}
