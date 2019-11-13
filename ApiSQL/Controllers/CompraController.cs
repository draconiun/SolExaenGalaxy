using ApiSQL.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiSQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CompraController : ControllerBase
    {
        private readonly ICompraService _compraService;
        public CompraController(ICompraService compraService)
        {
            _compraService = compraService;
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_compraService.Listar());
        }
    }
}