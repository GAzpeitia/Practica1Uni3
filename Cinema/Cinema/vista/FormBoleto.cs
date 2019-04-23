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
    public partial class FormBoleto : Form
    {
        public FormBoleto()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Boleto boleto = new Boleto();

            boleto.Folio = 1000563289;
            boleto.Fecha = "02/04/2019";
            boleto.Asiento = 12;
            boleto.Costo = 25;

            textFolio.Text = boleto.Folio.ToString();
            textFecha.Text = boleto.Fecha;
            textAsiento.Text = boleto.Asiento.ToString();
            textCosto.Text = boleto.Costo.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
