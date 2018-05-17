using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HistoriaClinicaElectronica.Interfaz;

namespace HistoriaClinicaElectronica.Control
{
    public class ControladorInicial
    {
        //Crear Objeto de la Clase Control
        //public Control.ControladorInicial objetoControl = new Control.ControladorInicial();

        //Declaración variables privadas locales
        private String UsuarioMedico = "MedUsb", UsuarioEnfermera = "EnfUsb";
        private String ContraseñaMedico = "UsbMed", ContraseñaEnfermera = "UsbEnf";

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
                Interfaz.FrmPrincipal.ActiveForm.Hide();
                //Crear Nuevo formulario
                Interfaz.FrmPrincipal frm = new Interfaz.FrmPrincipal();
                //Activar-Motrar formulario principal
                frm.Show();

                estado = true;
            }
            else if (Usuario == UsuarioEnfermera && Contraseña == ContraseñaEnfermera)
            {
                estado = true;
            }
            else {
                MessageBox.Show("El usuario y/o contraseña estan incorrectos", "Ingreso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                estado = false;
            }

            return estado;
        }

        //Controlador de Salida
        public void DeseaSalir(DialogResult resultado)
        {
            //Casos respuesta
            switch (resultado)
            {
                case DialogResult.Yes:
                    Interfaz.FrmPrincipal.ActiveForm.Close(); break;
                case DialogResult.No:
                    break;
            }
        }


        public void CerrarSesion()
        {

            //Ocultar este formulario
            Interfaz.FrmPrincipal.ActiveForm.Hide();
            //Crear Nuevo formulario
            InicioSesion frm = new InicioSesion();
            //Activar-Motrar formulario principal
            frm.Show();
        }


    }
}
