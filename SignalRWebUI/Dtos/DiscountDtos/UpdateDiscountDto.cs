namespace SignalRWebUI.Dtos.DiscountDtos
{
    public class UpdateDiscountDto
    {
        public int DiscountID { get; set; }
        public string DiscountTitle { get; set; }
        public int Amount { get; set; }
        public string DiscountDescription { get; set; }
        public string ImageUrl { get; set; }
    }
}
