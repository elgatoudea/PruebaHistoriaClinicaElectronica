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
    public partial class Agenda : Form
    {
        public Agenda()
        {
            InitializeComponent();
        }

        private void Agenda_Load(object sender, EventArgs e)
        {
            wbrAgenda.Navigate("https://usbmedellin.sharepoint.com/");
        }

        private void ptbAtras_Click(object sender, EventArgs e)
        {
            wbrAgenda.GoBack();
        }

        private void ptbAdelante_Click(object sender, EventArgs e)
        {
            wbrAgenda.GoForward();
        }

        private void ptbInicio_Click(object sender, EventArgs e)
        {
            wbrAgenda.Navigate("https://usbmedellin.sharepoint.com/");
        }
    }
}
