using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.AboutDto
{
    public class CreateAboutDto
    {
        public string ImageUrl { get; set; }
        public int Title { get; set; }
        public int Description { get; set; }
    }
}
