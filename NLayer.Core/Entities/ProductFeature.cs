namespace NLayer.Core.Entities
{
    public class ProductFeature
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public int Heigt { get; set; }
        public int Width { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
