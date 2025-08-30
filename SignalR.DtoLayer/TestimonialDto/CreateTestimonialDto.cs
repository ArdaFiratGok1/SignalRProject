using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.TestimonialDto
{
    public class CreateTestimonialDto
    {
        public string TestimonialName { get; set; }
        public string TestimonialTitle { get; set; }
        public string Comment { get; set; }
        public string ImageUrl { get; set; }
        public bool TestimonialStatus { get; set; }
    }
}
