using Dapper;
using ORM_TurmaFormacao.Data;
using ORM_TurmaFormacao.Features.Product.Entities;

namespace ORM_TurmaFormacao.Features.Product.Queries
{
    public class GetProductsQueryHandler
    {
        private readonly DapperContext _context;

        public GetProductsQueryHandler(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Products>> Handle()
        {
            var query = ""; //TODO: Criar query para buscar todos os produtos
            using (var connection = _context.GetConnection())
            {
                var result = await connection.QueryAsync<Products>(query);
                return result;
            }
        }
    }
}
