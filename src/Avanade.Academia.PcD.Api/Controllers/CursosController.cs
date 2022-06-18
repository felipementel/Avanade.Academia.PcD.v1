using Microsoft.AspNetCore.Mvc;

namespace Avanade.Academia.PcD.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CursosController : ControllerBase
    {

        private readonly ILogger<CursosController> _logger;

        public CursosController(ILogger<CursosController> logger)
        {
            _logger = logger;
        }
    }
}