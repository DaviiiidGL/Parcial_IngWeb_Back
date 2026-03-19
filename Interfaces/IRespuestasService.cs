using Parcial_IngWeb.Models;
using System.Diagnostics;

namespace Parcial_IngWeb.Interfaces
{
    public interface IRespuestasService
    {
        Task<Respuestas> Create(Respuestas respuesta);
    }
}
