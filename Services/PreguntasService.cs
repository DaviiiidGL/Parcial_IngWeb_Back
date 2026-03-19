using ApiConciertos.DAO;
using Microsoft.EntityFrameworkCore;
using Parcial_IngWeb.Interfaces;
using Parcial_IngWeb.Models;

namespace Parcial_IngWeb.Services
{
    public class PreguntasService : IPreguntasService
    {
        private readonly ApplicationDbContext _context;

        public PreguntasService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Preguntas>> GetAllResueltas()
        {
            return await _context.Preguntas.Where(p => p.isAnswered).ToListAsync();
        }

        public async Task<List<Preguntas>> GetAllNoResueltas()
        {
            return await _context.Preguntas.Where(p => !p.isAnswered).ToListAsync();
        }
        public async Task<Preguntas> Create(Preguntas newPregunta)
        {
            _context.Preguntas.Add(newPregunta);
            await _context.SaveChangesAsync();
            return newPregunta;
        }

        private async Task<bool> PreguntaAnswered(Guid id)
        {
            var PrExist = await _context.Preguntas.FindAsync(id);
            if (PrExist != null) return false;

            PrExist.isAnswered = true;
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
