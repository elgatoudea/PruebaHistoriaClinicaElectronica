using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoriaClinicaElectronica.Entidades
{
    [Table("Estratos")]
    public class Estrato
    {
            
            [DatabaseGenerated(DatabaseGeneratedOption.None)]
            public int Id { get; set; }
            public string Nombre { get; set; }

            public virtual ICollection<Paciente> Pacientes { get; set; }
        
    }


}
