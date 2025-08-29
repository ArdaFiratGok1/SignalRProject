

namespace SignalR.EntityLayer.Entitites
{
    public class Testimonial
    {
        public int TestimonialID { get; set; }
        public string TestimonialName { get; set; }
        public string TestimonialTitle { get; set; }
        public string Comment { get; set; }  
        public string ImageUrl { get; set; }
        public bool TestimonialStatus { get; set; }
    }
}
