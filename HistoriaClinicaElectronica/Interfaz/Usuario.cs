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

        //VariableGlobal
        int validacionInicial = 0;
        


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

            List<Estrato> Estratos = ControladorInicial.ObtenerEstrato();
            cboEstrato.DataSource = Estratos;
            cboEstrato.DisplayMember = "Nombre";
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
            //Validador de vacio Activivdades
            if (objetoControl.esVacio(txtDeporte.Text) == true)
            { erpMensaje.SetError(txtDeporte, "Este campo no puede ser vacio"); return;
            }
            else { erpMensaje.SetError(txtDeporte, ""); }

            if (objetoControl.esVacio(txtTiempoLibre.Text) == true)
            { erpMensaje.SetError(txtTiempoLibre, "Este campo no puede ser vacio"); return;
            }
            else { erpMensaje.SetError(txtTiempoLibre, ""); }


            //Validador de vacio Historia Clinica

            if (objetoControl.esVacio(txtProblemaSalud.Text) == true)
            {
                erpMensaje.SetError(txtProblemaSalud, "Este campo no puede ser vacio"); return;
            }
            else { erpMensaje.SetError(txtProblemaSalud, ""); }
            if (objetoControl.esVacio(txtMedicamento.Text) == true)
            {
                erpMensaje.SetError(txtMedicamento, "Este campo no puede ser vacio"); return;
            }
            else { erpMensaje.SetError(txtMedicamento, ""); }
            if (objetoControl.esVacio(txtConsumoSustancias.Text) == true)
            {
                erpMensaje.SetError(txtConsumoSustancias, "Este campo no puede ser vacio"); return;
            }
            else { erpMensaje.SetError(txtConsumoSustancias, ""); }
            if (objetoControl.esVacio(txtTratamientoPsicologico.Text) == true)
            {
                erpMensaje.SetError(txtTratamientoPsicologico, "Este campo no puede ser vacio"); return;
            }
            else { erpMensaje.SetError(txtTratamientoPsicologico, ""); }
            if (objetoControl.esVacio(txtTratamiento.Text) == true)
            {
                erpMensaje.SetError(txtTratamiento, "Este campo no puede ser vacio"); return;
            }
            else { erpMensaje.SetError(txtTratamiento, ""); }
            if (objetoControl.esVacio(txtOtros.Text) == true)
            {
                erpMensaje.SetError(txtOtros, "Este campo no puede ser vacio"); return;
            }
            else { erpMensaje.SetError(txtOtros, ""); }

            if (validacionInicial >= 1)
            {

                Entidades.Paciente paciente = new Entidades.Paciente();

                paciente.Nombres = txtNombrePaciente.Text;
                paciente.PrimerApellido = txtPrimerApellido.Text;
                paciente.SegundoApellido = txtSegundoApellido.Text;
                paciente.TelefonoFijo = txtTelefonoFijo.Text;
                paciente.Telefono = txtTelefono.Text;
                paciente.IdEstadoCivil = (cboEstadoCivil.SelectedItem as EstadoCivil).Id;
                paciente.NumeroDocumento = txtNumeroDocumento.Text;
                paciente.FechaNacimiento = dtpFechaNacimiento.Value;
                paciente.IdTipoDocumento = (cboTipoDocumento.SelectedItem as TipoDocumento).Id;
                paciente.IdTipoVinculacion = (cboTipoVinculacion.SelectedItem as TipoVinculacion).Id;
                paciente.IdTipoSangre = (cboTipoSangre.SelectedItem as TipoSangre).Id;
                paciente.IdEstrato = (cboEstrato.SelectedItem as Estrato).Id;
                if (rbnFemenino.Checked == true) { paciente.Sexo = "Femenino"; }
                else if (rbnMasculino.Checked == true) { paciente.Sexo = "Masculino"; }
                if (rbnSiDeporte.Checked == true) { paciente.Deporte = "Si"; paciente.CualDeporte = txtDeporte.Text; }
                else if (rbnNoDeporte.Checked == true) { paciente.Deporte = "No"; paciente.CualDeporte = "Ninguno"; }
                if (rbnSiActividad.Checked == true) { paciente.TiempoLibre = "Si"; paciente.CualTiempoLibre = txtTiempoLibre.Text; }
                else if (rbnNoAcitividad.Checked == true) { paciente.TiempoLibre = "No"; paciente.CualTiempoLibre = "Ninguno"; }
                paciente.ProblemaSalud = txtProblemaSalud.Text;
                paciente.Medicamento = txtMedicamento.Text;
                paciente.ConsumoSustancias = txtConsumoSustancias.Text;
                paciente.TratamientoPsicologico = txtTratamientoPsicologico.Text;
                paciente.Tratamiento = txtTratamiento.Text;
                paciente.Otros = txtOtros.Text;

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
            }else
            {
                MessageBox.Show("Debes llenar todos los campos para poder continuar","Faltan Datos por Guardar o Ingresar",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                tbcPrincipal.SelectedIndex = 0;
            }

            
        }



        private void cboTipoDocumento_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtNumeroDocumento.Text = "0";
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            //Validador de vacio Paciente
            if (objetoControl.esVacio(txtNombrePaciente.Text) == true)
            { erpMensaje.SetError(txtNombrePaciente, "El nombre no puede ser vacio");  return; }
            else { erpMensaje.SetError(txtNombrePaciente, "");  }

            if (objetoControl.esVacio(txtPrimerApellido.Text) == true)
            { erpMensaje.SetError(txtPrimerApellido, "El primer Apellido no puede ser vacio"); return; }
            else { erpMensaje.SetError(txtPrimerApellido, ""); }

            if (objetoControl.esVacio(txtSegundoApellido.Text) == true)
            { erpMensaje.SetError(txtSegundoApellido, "El segundo Apellido no puede ser vacio"); return; }
            else { erpMensaje.SetError(txtSegundoApellido, ""); }

            //Validador de vacio Numero de Documento
            if (objetoControl.esVacio(txtNumeroDocumento.Text) == true)
            { erpMensaje.SetError(txtNumeroDocumento, "El Numero del Documento no puede ser vacio");  return; }
            else { erpMensaje.SetError(txtNumeroDocumento, "");  }

            //Validador de vacio Numero de Telefono
            if (objetoControl.esVacio(txtTelefonoFijo.Text) == true)
            { erpMensaje.SetError(txtTelefonoFijo, "El Numero del Télefono Fijo no puede ser vacio"); return; }
            else { erpMensaje.SetError(txtTelefonoFijo, "");  }

            if (objetoControl.esVacio(txtTelefono.Text) == true)
            { erpMensaje.SetError(txtTelefono, "El Numero del Télefono Celular no puede ser vacio"); return; }
            else { erpMensaje.SetError(txtTelefono, "");  }

            tbcPrincipal.SelectedIndex = 1;
            validacionInicial = 1;

        }


        //Eventos KeyPress


        private void txtID_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //Validar campo solo numeros
            if (cboTipoDocumento.SelectedIndex == 0 || cboTipoDocumento.SelectedIndex == 1 || cboTipoDocumento.SelectedIndex == 3)
            {
                if (!((int)e.KeyChar == 8 || (int)e.KeyChar >= 48 && (int)e.KeyChar <= 57))
                {
                    e.Handled = objetoControl.EsNumero(e);
                }
            }
        }
        
        private void txtTelefonoFijo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled=objetoControl.EsNumero(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = objetoControl.EsNumero(e);
        }

        private void rbnSiDeporte_CheckedChanged(object sender, EventArgs e)
        {
            txtDeporte.Text = "Cual Deporte/Actividad";
        }

        private void rbnSiActividad_CheckedChanged(object sender, EventArgs e)
        {
            txtTiempoLibre.Text="Cual Actividad de Tiempo Libre";
        }
    }
}
