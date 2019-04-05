using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Partido;

namespace Partido
{
    static class Program
    {
        public static formCampeonato campeonato = null;
        public static formJornada jornada = null;
        public static formPrincipal main = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            main = new formPrincipal();
            campeonato = new formCampeonato();
            jornada = new formJornada();
            Application.Run(new formPrincipal());
            
        }
    }
}
