using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreglosAsesorias
{
    class Solicitar
    {
        static void Main(string[] args)
        {
            int num, conta=0;
            //int[] numUs = new int[100];
            int numUs = 0;
            Console.Write("\nDame un número: ");
            num = int.Parse(Console.ReadLine());

            do
            {

                Random ale = new Random();
                numUs = ale.Next(1, 100);
                conta++;

            } while (numUs != num);

            Console.Write("\nNúmero de ciclos: " + conta);
            Console.ReadKey();
            
        }
    }
}
