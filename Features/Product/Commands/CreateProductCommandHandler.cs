using ORM_TurmaFormacao.Data;
using ORM_TurmaFormacao.Features.Product.Entities;

namespace ORM_TurmaFormacao.Features.Product.Commands
{
    public class CreateProductCommandHandler
    {
        private readonly ApplicationDbContext _context;
        public CreateProductCommandHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Handle(Products handle)
        {
            var product = new Products
            {
                Name = handle.Name,
                Price = handle.Price,
                Amount = handle.Amount,
                CategoryId = handle.CategoryId
            };
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
        }
    }
}
