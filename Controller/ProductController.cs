using Microsoft.AspNetCore.Mvc;
using ORM_TurmaFormacao.Features.Product.Commands;
using ORM_TurmaFormacao.Features.Product.Entities;

namespace ORM_TurmaFormacao.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly CreateProductCommandHandler _commandHandler;

        public ProductController(CreateProductCommandHandler commandHandler)
        {
            _commandHandler = commandHandler;
        }

        [HttpPost("Create")]
        public IActionResult CreateProduct([FromBody] Products command)
        {
            var result = _commandHandler.Handle(command);
            return Ok(result);
        }
    }
}
