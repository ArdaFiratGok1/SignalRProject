namespace SignalRWebUI.Dtos.ProductDtos
{
    public class UpdateProductDto
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int Price { get; set; }
        public string ImageURL { get; set; }
        public bool ProductStatus { get; set; }
        public string CategoryID { get; set; }
    }
}
