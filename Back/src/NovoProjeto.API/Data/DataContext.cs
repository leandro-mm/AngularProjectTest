using Microsoft.EntityFrameworkCore;

namespace NovoProjeto.API.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options){}
        public DbSet<NovoProjeto.API.Models.Evento>    Eventos { get; set; }
    }
}