using DESAFIO_FUNDAMENTOS5.Entities;
using Microsoft.EntityFrameworkCore;

namespace DESAFIO_FUNDAMENTOS5.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        }

        public DbSet<Tarefa> Tarefas { get; set;}

    }
}