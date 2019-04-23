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
    public partial class FormAsiento : Form
    {
        public FormAsiento()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Asiento formAsi = new Asiento();

            formAsi.Numero = 12;
            formAsi.EstaDisponible = true;

            textNum.Text = formAsi.Numero.ToString();
            textDisp.Text = formAsi.EstaDisponible.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
