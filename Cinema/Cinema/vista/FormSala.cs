using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema.vista
{
    public partial class FormSala : Form
    {
        public FormSala()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Sala sal = new Sala();

            sal.Id = 4281004;
            sal.Nombre = "Sala_4";
            sal.Capacidad = 250;
            sal.EstaLLena = false;

            textId.Text = sal.Id.ToString();
            textNombre.Text = sal.Nombre;
            textCapacidad.Text = sal.Capacidad.ToString();
            textLlena.Text = sal.EstaLLena.ToString();
        }
    }
}
