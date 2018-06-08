using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HistoriaClinicaElectronica.Entidades;
using System.Data.Entity;


namespace HistoriaClinicaElectronica.Datos
{
    class Initializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {

            context.TiposDocumento.Add(new TipoDocumento() { Nombre = "Cédula de Ciudadanía", Id = 1 });
            context.TiposDocumento.Add(new TipoDocumento() { Nombre = "NUIP", Id = 2 });
            context.TiposDocumento.Add(new TipoDocumento() { Nombre = "Cédula de Extranjería", Id = 3 });
            context.TiposDocumento.Add(new TipoDocumento() { Nombre = "Tarjeta de Identidad", Id = 4 }); 

            context.EstadosCiviles.Add(new EstadoCivil() { Nombre = "Soltero/a", Id = 1 });
            context.EstadosCiviles.Add(new EstadoCivil() { Nombre = "Casado/a", Id = 2 });
            context.EstadosCiviles.Add(new EstadoCivil() { Nombre = "Divorciado/a", Id = 3 });
            context.EstadosCiviles.Add(new EstadoCivil() { Nombre = "Viudo/a", Id = 4 });

            context.TiposVinculacion.Add(new TipoVinculacion() { Nombre = "Estudiante", Id = 1 });
            context.TiposVinculacion.Add(new TipoVinculacion() { Nombre = "Docente", Id = 2 });
            context.TiposVinculacion.Add(new TipoVinculacion() { Nombre = "Empleado Adminstrativo", Id = 3 });
            context.TiposVinculacion.Add(new TipoVinculacion() { Nombre = "Empleado Operativo", Id = 4 });
            context.TiposVinculacion.Add(new TipoVinculacion() { Nombre = "Visitante", Id = 5 });

            context.TiposSangre.Add(new TipoSangre() { Nombre = "O+", Id = 1 });
            context.TiposSangre.Add(new TipoSangre() { Nombre = "O-", Id = 2 });
            context.TiposSangre.Add(new TipoSangre() { Nombre = "A+", Id = 3 });
            context.TiposSangre.Add(new TipoSangre() { Nombre = "A-", Id = 4 });
            context.TiposSangre.Add(new TipoSangre() { Nombre = "B+", Id = 5 });
            context.TiposSangre.Add(new TipoSangre() { Nombre = "B-", Id = 6 });
            context.TiposSangre.Add(new TipoSangre() { Nombre = "AB+", Id = 7 });
            context.TiposSangre.Add(new TipoSangre() { Nombre = "AB-", Id = 8 });

            context.Estratos.Add(new Estrato() { Nombre = "1", Id = 1 });
            context.Estratos.Add(new Estrato() { Nombre = "2", Id = 2 });
            context.Estratos.Add(new Estrato() { Nombre = "3", Id = 3 });
            context.Estratos.Add(new Estrato() { Nombre = "4", Id = 4 });
            context.Estratos.Add(new Estrato() { Nombre = "5", Id = 5 });
            context.Estratos.Add(new Estrato() { Nombre = "6", Id = 6 });

            base.Seed(context);
        }
    }
}
