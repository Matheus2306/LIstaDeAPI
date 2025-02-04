using ListaDeTarefasAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ListaDeTarefasAPI.Data
{
    public class listaTarefasContext : DbContext
    {
        public listaTarefasContext(DbContextOptions<listaTarefasContext> options) : base(options) { }
        public DbSet<Tarefa> Tarefas { get; set; }
        public DbSet<TipoTarefa> TipoTarefas { get; set; }
    }
}
