using Microsoft.EntityFrameworkCore;
using MeetPrg.Core.Entities;

namespace MeetPrg.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options) { }
       
       

        public DbSet<Semana> Semanas { get; set; }
        public DbSet<Indicador> Indicadores { get; set; }
        public DbSet<Volante> Volantes { get; set; }
        public DbSet<VidaMinisterio> VidaMinisterios { get; set; }
        public DbSet<LeituraSentinela> LeituraSentinelas { get; set; }
        public DbSet<Participante> Participantes { get; set; }
    }
}
