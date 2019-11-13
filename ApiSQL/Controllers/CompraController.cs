using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiSQL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiSQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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