using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Partido
{
    public partial class formJornada : Form
    {
        public formJornada()
        {
            InitializeComponent();
        }

        private void FormJornada_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Jornada jorn = new Jornada();

            jorn.Id = 45896;
            jorn.FechaInicio = "08/05/2019";
            jorn.FechaFin = "08/06/2019";
            jorn.IsConcluida = true;

            txtId.Text = jorn.Id.ToString();
            txtFechaInicio.Text = jorn.FechaInicio;
            txtFechaFin.Text = jorn.FechaFin;
            txtIsConcluido.Text = jorn.IsConcluida.ToString();
        }
    }
}
