using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cinema.vista;

namespace Cinema
{
    static class Program
    {
        public static FormMenu formMenu = null;
        public static FormPelicula formPelicula = null;
        public static FormSala formSala = null;
        public static FormAsiento formAsiento = null;
        public static FormBoleto formBoleto = null;
        public static FormCartelera formCartelera = null;
        public static FormCliente formCliente = null;
        public static FormReservacion formReser = null;
        public static FormTaquillero formTaqui = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formMenu = new FormMenu();
            formPelicula = new FormPelicula();
            formSala = new FormSala();
            formAsiento = new FormAsiento();
            formBoleto = new FormBoleto();
            formCartelera = new FormCartelera();
            formCliente = new FormCliente();
            formReser = new FormReservacion();
            formTaqui = new FormTaquillero();
            Application.Run(new FormMenu());
        }
    }
}
