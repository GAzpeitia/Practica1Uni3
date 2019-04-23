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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnIr_Click(object sender, EventArgs e)
        {
            if (comboSelect.Text == "Película")
            {
                Form formPeli = new FormPelicula();
                formPeli.Show();
            }
            if (comboSelect.Text == "Sala")
            {
                Form formSal = new FormSala();
                formSal.Show();
            }
            if (comboSelect.Text == "Asiento")
            {
                Form formAsie = new FormAsiento();
                formAsie.Show();
            }
            if (comboSelect.Text == "Boleto")
            {
                Form formBol = new FormBoleto();
                formBol.Show();
            }
            if (comboSelect.Text == "Cartelera")
            {
                Form formCarte = new FormCartelera();
                formCarte.Show();
            }
            if (comboSelect.Text == "Cliente")
            {
                Form formCli = new FormCliente();
                formCli.Show();
            }
            if (comboSelect.Text == "Reservación")
            {
                Form formR = new FormReservacion();
                formR.Show();
            }
            if (comboSelect.Text == "Taquillero")
            {
                Form formTaq = new FormTaquillero();
                formTaq.Show();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
