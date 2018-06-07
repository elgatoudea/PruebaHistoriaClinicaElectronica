using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HistoriaClinicaElectronica
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        //Crear Objeto de la Clase Control
        public Control.ControladorInicial objetoControl = new Control.ControladorInicial();

        private void btnInicio_Click(object sender, EventArgs e)
        {
            //Llamada del Metodo
            objetoControl.UsuarioContraseña(txtUsuario.Text, txtContraseña.Text);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Asignación de la respuesta enviada por el Mensaje de Salida
            DialogResult resultado = MessageBox.Show("Seguro que dese salir?", "Salir", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            objetoControl.DeseaSalir(resultado);
        }

        private void InicioSesion_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Salir de la Aplicación
            Application.Exit();
        }
    }
}
