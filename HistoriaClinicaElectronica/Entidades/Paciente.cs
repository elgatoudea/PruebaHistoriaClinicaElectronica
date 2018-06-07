using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoriaClinicaElectronica.Entidades
{
    public class Paciente
    {
        public int Id { get; set; }
        public long NumeroDocumento { get; set; }
        public string Nombres { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Telefono { get; set; }

        
        public DateTime FechaNacimiento { get; set; }

        public int IdEstadoCivil { get; set; }
        public virtual EstadoCivil EstadoCivil { get; set; }

        public int IdTipoDocumento { get; set; }
        public virtual TipoDocumento TipoDocumento { get; set; }

        public int IdTipoVinculacion { get; set; }
        public virtual TipoVinculacion TipoVinculacion { get; set; }

        public int IdTipoSangre { get; set; }
        public virtual TipoSangre TipoSangre { get; set; }
    }
}
