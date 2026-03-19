using Microsoft.AspNetCore.Mvc;
using Parcial_IngWeb.Interfaces;
using Parcial_IngWeb.Models;

namespace Parcial_IngWeb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RespuestasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private readonly IRespuestasService _respuestasService;

        public RespuestasController(IRespuestasService respuestasService)
        {
            _respuestasService = respuestasService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Respuestas newRespuesta)
        {
            var createdAns = await _respuestasService.Create(newRespuesta);
            return Ok(createdAns);
        }

    }
}