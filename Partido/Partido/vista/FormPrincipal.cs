using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Partido
{ 
    public partial class formPrincipal : Form
    {
        
        public formPrincipal()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form FormP = new formAdministracionCampeonatos();
            FormP.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form FormCamp = new formCampeonato();
            FormCamp.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnJornada_Click(object sender, EventArgs e)
        {
            Form FormJ = new formJornada();
            FormJ.Show();
        }
    }
}
