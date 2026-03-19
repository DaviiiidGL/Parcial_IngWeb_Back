using ApiConciertos.DAO;
using Parcial_IngWeb.Interfaces;
using Parcial_IngWeb.Models;

namespace Parcial_IngWeb.Services
{
    public class RespuestasService : IRespuestasService
    {
        private readonly ApplicationDbContext _context;

        public RespuestasService(ApplicationDbContext context)
        {
            _context = context;
        }



        public async Task<Respuestas> Create(Respuestas respuesta)
        {

            var pregunta = await _context.Preguntas.FindAsync(respuesta.IdPregunta);
            if (pregunta == null) throw new Exception("Pregunta no encontrada");

            _context.Respuestas.Add(respuesta);

            pregunta.isAnswered = true;

            await _context.SaveChangesAsync();
            return respuesta;
        }
    }
}
