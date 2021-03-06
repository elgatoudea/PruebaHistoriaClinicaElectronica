﻿using Datos;
using HistoriaClinicaElectronica.Datos;
using HistoriaClinicaElectronica.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class AccesoDatosPaciente
    {
        private static Context context = new Context();
        
        internal static void IngresarPaciente(Paciente paciente)
        {
            context.Pacientes.Add(paciente);
            context.SaveChanges();
        }

        internal static List<TipoDocumento> ObtenerTiposDocumento()
        {
            return context.TiposDocumento.ToList();
        }

        internal static List<EstadoCivil> ObtenerEstadosCiviles()
        {
            return context.EstadosCiviles.ToList();
        }

        internal static List<Paciente> ObtenerPacientes()
        {
            return context.Pacientes.ToList();
        }

        internal static List<TipoVinculacion> ObtenerTiposViculacion()
        {
            return context.TiposVinculacion.ToList();
        }

        internal static List<TipoSangre> ObtenerTiposSangre()
        {
            return context.TiposSangre.ToList();
        }

        internal static List<Estrato> ObtenerEstrato()
        {
            return context.Estratos.ToList();
        }
    }
}
