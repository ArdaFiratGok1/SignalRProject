using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.AboutDto
{
    public class GetAboutDto
    {
        public int AboutID { get; set; }
        public string ImageUrl { get; set; }
        public int Title { get; set; }
        public int Description { get; set; }
    }
}
