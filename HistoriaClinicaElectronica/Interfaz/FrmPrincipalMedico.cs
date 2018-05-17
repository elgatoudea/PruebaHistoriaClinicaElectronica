using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HistoriaClinicaElectronica.Entidades;

namespace HistoriaClinicaElectronica.Interfaz
{
    public partial class FrmPrincipal : Form
    {
        //Crear Objeto de la Clase Control
        public Control.ControladorInicial objetoControl = new Control.ControladorInicial();

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        //Carga del Formulario
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            List<TipoDocumento> tiposDocumento = new List<TipoDocumento>();
            tiposDocumento.Add(new TipoDocumento() { Id = 1, Nombre = "Cedula de Ciudadania" });
            tiposDocumento.Add(new TipoDocumento() { Id = 2, Nombre = "NUIP" });
            tiposDocumento.Add(new TipoDocumento() { Id = 3, Nombre = "Tarjeta de Extranjería" });
            tiposDocumento.Add(new TipoDocumento() { Id = 4, Nombre = "Tarjeta de Identidad" });

            cboTipoDocumento.DataSource = tiposDocumento;
            cboTipoDocumento.DisplayMember = "Nombre";

            
        }


        //Evento KeyPress
        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validar campo solo numeros
            if (cboTipoDocumento.SelectedIndex == 0 || cboTipoDocumento.SelectedIndex == 1 || cboTipoDocumento.SelectedIndex == 3)
            {
                if (!((int)e.KeyChar == 8 || (int)e.KeyChar >= 48 && (int)e.KeyChar <= 57))
                {
                    e.Handled = true;
                }
            }
        }

        private void cboTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtID.Text = "0";
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Salir de la Aplicación
            Application.Exit();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objetoControl.CerrarSesion();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Los Datos ingresados han sido Guardar", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
