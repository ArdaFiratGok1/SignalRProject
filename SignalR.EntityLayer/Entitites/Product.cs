namespace SignalR.EntityLayer.Entitites
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int Price { get; set; }
        public string ImageURL { get; set; }
        public bool ProductStatus { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
