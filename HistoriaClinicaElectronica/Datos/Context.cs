using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HistoriaClinicaElectronica.Entidades;

namespace HistoriaClinicaElectronica.Datos
{
    public class Context : DbContext
    {
        public Context() : base("name=HistoriaClinicaElectronica")
        {
            Database.SetInitializer(new Initializer());
        }

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<TipoDocumento> TiposDocumento { get; set; }
        public DbSet<EstadoCivil> EstadosCiviles { get; set; }
        public DbSet<TipoVinculacion> TiposVinculacion { get; set; }
        public DbSet<TipoSangre> TiposSangre { get; set; }
        public DbSet<Estrato> Estratos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TipoDocumento>()
                .HasMany(p => p.Pacientes)
                .WithRequired(p => p.TipoDocumento)
                .HasForeignKey(p => p.IdTipoDocumento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EstadoCivil>()
                .HasMany(p => p.Pacientes)
                .WithRequired(p => p.EstadoCivil)
                .HasForeignKey(p => p.IdEstadoCivil)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoVinculacion>()
                .HasMany(p => p.Pacientes)
                .WithRequired(p => p.TipoVinculacion)
                .HasForeignKey(p => p.IdTipoVinculacion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoSangre>()
                .HasMany(p => p.Pacientes)
                .WithRequired(p => p.TipoSangre)
                .HasForeignKey(p => p.IdTipoSangre)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Estrato>()
                .HasMany(p => p.Pacientes)
                .WithRequired(p => p.Estrato)
                .HasForeignKey(p => p.IdEstrato)
                .WillCascadeOnDelete(false);

        }
    }
}
