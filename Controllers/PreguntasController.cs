using Microsoft.AspNetCore.Mvc;
using Parcial_IngWeb.Interfaces;
using Parcial_IngWeb.Models;

namespace Parcial_IngWeb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PreguntasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private readonly IPreguntasService _preguntasService;

        public PreguntasController(IPreguntasService preguntasService)
        {
            _preguntasService = preguntasService;
        }


        [HttpGet]
        [Route("api/[controller]/Answered")]
        public async Task<IActionResult> GetAnswered() => Ok(await _preguntasService.GetAllResueltas());

        [HttpGet]
        [Route("api/[controller]/NotAnswered")]
        public async Task<IActionResult> GetNotAnswered() => Ok(await _preguntasService.GetAllResueltas());

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Preguntas newPregunta)
        {

            var createdPr = await _preguntasService.Create(newPregunta);
            return Ok(createdPr);
        }
    }
}
