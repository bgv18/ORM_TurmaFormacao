using Microsoft.Data.SqlClient;
using System.Data;

namespace ORM_TurmaFormacao.Data
{
    public class DapperContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public DapperContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        public IDbConnection GetConnection() => new SqlConnection(_connectionString);
        
    }
}
