namespace basicModel.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Brand brand { get; set; }
        public Product_Type product_type { get; set; }
        public float price { get; set; }
    }
}
