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
    public partial class FormCartelera : Form
    {
        public FormCartelera()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Cartelera cartel = new Cartelera();

            cartel.Id = 799546;
            cartel.Fecha = "11/03/2019";
            cartel.Horario = "Vespertino";
            cartel.Tipo = "Publica";
            cartel.Costo = 52;

            textId.Text = cartel.Id.ToString();
            textFecha.Text = cartel.Fecha;
            textHorario.Text = cartel.Horario;
            textTipo.Text = cartel.Tipo;
            textCosto.Text = cartel.Costo.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
