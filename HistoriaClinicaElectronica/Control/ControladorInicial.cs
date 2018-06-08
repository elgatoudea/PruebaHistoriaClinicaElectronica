using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HistoriaClinicaElectronica.Interfaz;
using Datos;
using HistoriaClinicaElectronica.Entidades;

namespace HistoriaClinicaElectronica.Control
{
    public class ControladorInicial
    {
        
       
        //Declaración variables privadas locales
        private String UsuarioMedico = "MedUsb", UsuarioEnfermera = "EnfUsb";
        private String ContraseñaMedico = "UsbMed", ContraseñaEnfermera = "UsbEnf";

       
        internal static List<Entidades.TipoDocumento> ObtenerTiposDocumento()
        {
            return AccesoDatosPaciente.ObtenerTiposDocumento();
        }

        internal static List<Entidades.EstadoCivil> ObtenerEstadosCiviles()
        {
            return AccesoDatosPaciente.ObtenerEstadosCiviles();
        }

        internal static List<Entidades.Paciente> ObtenerPacientes()
        {
            return AccesoDatosPaciente.ObtenerPacientes();
        }

        internal static List<Entidades.TipoVinculacion> ObtenerTiposVinculacion()
        {
            return AccesoDatosPaciente.ObtenerTiposViculacion();
        }

        internal static List<Entidades.TipoSangre> ObtenerTiposSangre()
        {
            return AccesoDatosPaciente.ObtenerTiposSangre();
        }

        internal static List<Entidades.Estrato> ObtenerEstrato()
        {
            return AccesoDatosPaciente.ObtenerEstrato();
        }

        /// <summary>
        /// Metodo para validar Usuario y Contraseña
        /// </summary>
        /// <param name="Usuario">Campo donde este el texto del usurio ingresado</param>
        /// <param name="Contraseña">Campo donde este la contraseña del usurio ingresado</param>
        /// <returns></returns>
        public bool UsuarioContraseña(String Usuario, String Contraseña)
        {
            //Variable Local
            bool estado = false;

            //Validaciones con condicional IF
            if (Usuario == UsuarioMedico && Contraseña == ContraseñaMedico)
            {
                //Ocultar este formulario
                Form.ActiveForm.Hide();
                //Crear Nuevo formulario
                Interfaz.Inicio frm = new Interfaz.Inicio();
                //Activar-Motrar formulario principal
                frm.Show();

                estado = true;
            }
            else if (Usuario == UsuarioEnfermera && Contraseña == ContraseñaEnfermera)
            {
                estado = true;
            }
            else
            {
                MessageBox.Show("El usuario y/o contraseña estan incorrectos", "Ingreso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                estado = false;
            }

            return estado;
        }

        internal static void IngresarPaciente(Paciente paciente)
        {
            AccesoDatosPaciente.IngresarPaciente(paciente);
        }

        //Controlador de Salida
        public void DeseaSalir(DialogResult resultado)
        {
            //Casos respuesta
            switch (resultado)
            {
                case DialogResult.Yes:
                    Interfaz.Inicio.ActiveForm.Close(); break;
                case DialogResult.No:
                    break;
            }
        }

        public int EsPrimeraVez(int contador)
        {
            if (contador == 0)
            {
                MessageBox.Show("Espere por favor Mientras Carga la Base de Datos", "Conexión a la Base de Datos en Curso...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return contador = contador + 1;
            }
            return contador;
        }

        public void CerrarSesion()
        {

            //Ocultar este formulario
            Interfaz.Inicio.ActiveForm.Hide();
            //Crear Nuevo formulario
            InicioSesion frm = new InicioSesion();
            //Activar-Motrar formulario principal
            frm.Show();
        }

        internal void Refrescar()
        {
            Interfaz.Usuario.ActiveForm.Close();
            Usuario frm = new Usuario();
            frm.ShowDialog();
        }


        public bool EsNumero(KeyPressEventArgs e)
        {
            bool valor = false;

            if (!((int)e.KeyChar == 8 || (int)e.KeyChar >= 48 && (int)e.KeyChar <= 57))
            {
                valor = true;
            }
            return valor;
        }

        public bool esVacio(string campo)
        {
            bool estado = true;

            if (campo == ""){estado = true;}
            else{estado = false;}

            return estado;
        }

       
    }
}
