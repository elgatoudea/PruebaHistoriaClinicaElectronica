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
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            dgvListadoPacientes.AutoGenerateColumns = false;
            List<Entidades.Paciente> pacientes = ControladorInicial.ObtenerPacientes();
            dgvListadoPacientes.DataSource = pacientes;
        }
    }
}
