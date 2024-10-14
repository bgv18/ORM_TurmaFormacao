namespace ORM_TurmaFormacao.Features.Product.Entities
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal? Amount { get; set; }
        public int CategoryId { get; set; }
    }
}
