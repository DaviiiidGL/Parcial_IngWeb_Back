
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Parcial_IngWeb.Models;
using System.Diagnostics;

namespace ApiConciertos.DAO
{
    public class ApplicationDbContext : DbContext
    {

        //Constructor que recibe las opciones de conexión a la bd para tener contexto de esta
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        //listado de clases -> a tablas en la base de datos
        //Los DB Set nos ayudan a mapear las clases como Entidades
        //Es decir que Entity Framework lee este archivo para tomar del modelo el esquema de las tablas

        public DbSet<Preguntas> Preguntas { get; set; }
        public DbSet<Respuestas> Respuestas { get; set; }
    }
}