using System.ComponentModel;

namespace WebApplicationVer2.Models
{
    public class City
    {
        [DisplayName("City Id")]
        public int CityId { get; set; }
        public string Name { get; set; }
        [DisplayName("Group Id")]
        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}
