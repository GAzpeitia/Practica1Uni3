using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Actividad30por.Properties;
using Actividad30por.modelo;
using Actividad30por.vista;

namespace Actividad30por.vista
{
    public partial class FormaEstudiante : Form
    {
        public FormaEstudiante()
        {
            InitializeComponent();
        }

        private void botonMostrar_Click(object sender, EventArgs e)
        {
            Estudiante student1 = new Estudiante(); //Instanciado el objeto

            //Estableciendo datos del estudiante
            student1.numerocontrol = 20181001213;
            student1.nombre = "Juan Alberto Villegas Ruíz";
            student1.genero = 'H'; // H Hombre  M Mujer
            student1.edad = 19;

            textoNumeroControl.Text = student1.numerocontrol.ToString();
            textoNombre.Text = student1.nombre;
            textoEdad.Text = student1.edad.ToString();
            textoGenero.Text = student1.genero.ToString();

        }
    }
}
