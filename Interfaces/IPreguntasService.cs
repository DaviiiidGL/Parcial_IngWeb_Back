using Parcial_IngWeb.Models;

namespace Parcial_IngWeb.Interfaces
{
    public interface IPreguntasService
    {
        Task<Preguntas> Create(Preguntas pregunta);
        Task<List<Preguntas>> GetAllResueltas();
        Task<List<Preguntas>> GetAllNoResueltas();
    }
}
