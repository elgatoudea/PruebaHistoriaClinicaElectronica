using HistoriaClinicaElectronica.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HistoriaClinicaElectronica.Interfaz
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        //Crear Objeto de la Clase Control
        public Control.ControladorInicial objetoControl = new Control.ControladorInicial();
        public int contador = 0;

        private void cerrarSesiónToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            objetoControl.CerrarSesion();
        }

        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Salir de la Aplicación
            Application.Exit();
        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbxConsultar_Click(object sender, EventArgs e)
        {
            Consulta frmConsulta = new Consulta();
            frmConsulta.ShowDialog();
        }

        private void pbxNuevoUsuario_Click(object sender, EventArgs e)
        {

            contador=objetoControl.EsPrimeraVez(contador);
            Usuario frmNuevo = new Usuario();
            frmNuevo.ShowDialog();
        }

        private void nuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contador = objetoControl.EsPrimeraVez(contador);
            Usuario frmNuevo = new Usuario();
            frmNuevo.ShowDialog();
        }

        private void historiaClínicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta frmConsulta = new Consulta();
            frmConsulta.ShowDialog();
        }
    }
}
