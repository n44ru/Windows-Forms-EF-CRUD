using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ares1
{
    public class ModelContext:DbContext
    {
        public ModelContext():base("name=LocalDb") { }
        public DbSet<Clases.Camara> Camaras { get; set; }
        public DbSet<Clases.Central> Centrales { get; set; }
        public DbSet<Clases.ListaNegra> ListasNegras { get; set; }
        public DbSet<Clases.RegistroAlarma> RegistrosAlarmas { get; set; }
        public DbSet<Clases.TipoProcedimiento> TiposProcedimientos { get; set; }
        public DbSet<Clases.VideoClip> VideosClips { get; set; }
        public DbSet<Clases.ZonaAlarma> ZonasAlarmas { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Clases.ZonaAlarma>()
        //        .HasOptional<Clases.Camara>(s => s.Camaras)
        //        .WithMany()
        //        .WillCascadeOnDelete(false);
        //}
    }
}
