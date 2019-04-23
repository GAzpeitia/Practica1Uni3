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
    public partial class FormTaquillero : Form
    {
        public FormTaquillero()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Taquillero formT = new Taquillero();

            formT.NumeroEmpleado = 123698;
            formT.TipoEmpleado = "Cajero";

            textemple.Text = formT.NumeroEmpleado.ToString();
            textTip.Text = formT.TipoEmpleado;
        }
    }
}
