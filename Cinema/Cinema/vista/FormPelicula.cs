using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Cinema.vista
{
    public partial class FormPelicula : Form
    {
        public FormPelicula()
        {
            InitializeComponent();
        }

        private void FormPelicula_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //richTextBoxPeli.Text = "";
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Pelicula peliculas = new Pelicula();

            peliculas.Id = 428106593;
            peliculas.Nombre = "Payper";
            peliculas.Director = "Smith";
            peliculas.Clasificacion = "B";
            peliculas.Resumen = "Niña que se pierde en un bosque con un monstruo.";

            textId.Text = peliculas.Id.ToString();
            textNombre.Text = peliculas.Nombre;
            textDir.Text = peliculas.Director;
            textClasi.Text = peliculas.Clasificacion;
            textRes.Text = peliculas.Resumen;
        }
    }
}
