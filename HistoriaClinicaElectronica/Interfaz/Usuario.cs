using HistoriaClinicaElectronica.Control;
using HistoriaClinicaElectronica.Entidades;
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
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        //Crear Objeto de la Clase Control
        public Control.ControladorInicial objetoControl = new Control.ControladorInicial();
        

        //Carga del Formulario
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            List<TipoDocumento> tiposDocumento = new List<TipoDocumento>();
            tiposDocumento.Add(new TipoDocumento() { Id = 1, Nombre = "Cedula de Ciudadania" });
            tiposDocumento.Add(new TipoDocumento() { Id = 2, Nombre = "NUIP" });
            tiposDocumento.Add(new TipoDocumento() { Id = 3, Nombre = "Tarjeta de Extranjería" });
            tiposDocumento.Add(new TipoDocumento() { Id = 4, Nombre = "Tarjeta de Identidad" });
        }

        //Evento KeyPress
        private void txtID_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void cboTipoDocumento_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtNumeroDocumento.Text = "0";
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
           List<TipoDocumento> tiposDocumento = ControladorInicial.ObtenerTiposDocumento();
            cboTipoDocumento.DataSource = tiposDocumento;
            cboTipoDocumento.DisplayMember = "Nombre";

            List<EstadoCivil> estadosCiviles = ControladorInicial.ObtenerEstadosCiviles();
            cboEstadoCivil.DataSource = estadosCiviles;
            cboEstadoCivil.DisplayMember = "Nombre";

            List<TipoVinculacion> tiposVinculacion = ControladorInicial.ObtenerTiposVinculacion();
            cboTipoVinculacion.DataSource = tiposVinculacion;
            cboTipoVinculacion.DisplayMember = "Nombre";

            List<TipoSangre> tiposSangre = ControladorInicial.ObtenerTiposSangre();
            cboTipoSangre.DataSource = tiposSangre;
            cboTipoSangre.DisplayMember = "Nombre";
        }
        

        private void dtpFechaNacimiento_Validating(object sender, CancelEventArgs e)
        {
            if (dtpFechaNacimiento.Value > DateTime.Now)
            {
                erpMensaje.SetError(dtpFechaNacimiento,
                    "La fecha de nacimiento debe ser menor a la fecha actual");
            }
            else
            {
                erpMensaje.SetError(dtpFechaNacimiento, string.Empty);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            //Asignación de la respuesta enviada por el Mensaje de Salida
            DialogResult resultado = MessageBox.Show("Seguro que dese salir sin Guardar Información?", "Mensaje de Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            switch (resultado)
            {
                case DialogResult.Yes:
                    this.Close(); break;
                case DialogResult.No:
                    break;
            }
            
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            Entidades.Paciente paciente = new Entidades.Paciente();
            paciente.Nombres = txtNombrePaciente.Text;
            paciente.PrimerApellido = txtPrimerApellido.Text;
            paciente.SegundoApellido = txtSegundoApellido.Text;
            paciente.Telefono = txtTelefono.Text;
            paciente.IdEstadoCivil = (cboEstadoCivil.SelectedItem as EstadoCivil).Id;
            paciente.NumeroDocumento = Convert.ToInt64(txtNumeroDocumento.Text);
            paciente.FechaNacimiento = dtpFechaNacimiento.Value;
            paciente.IdTipoDocumento = (cboTipoDocumento.SelectedItem as TipoDocumento).Id;
            paciente.IdTipoVinculacion = (cboTipoVinculacion.SelectedItem as TipoVinculacion).Id;
            paciente.IdTipoSangre = (cboTipoSangre.SelectedItem as TipoSangre).Id;


            ControladorInicial.IngresarPaciente(paciente);
           
            
            //Asignación de la respuesta enviada por el Mensaje de Salida
            DialogResult resultado = MessageBox.Show("El Paciente ha sido Ingresado Correctamente", "Paciente Agregado Correctamente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (resultado)
            {
                case DialogResult.Yes:
                    objetoControl.Refrescar();
                    break;
                case DialogResult.No:
                    this.Close();
                    break;
            }
        }
    }
}
