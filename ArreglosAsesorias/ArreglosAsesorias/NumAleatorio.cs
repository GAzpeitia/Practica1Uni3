using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArreglosAsesorias
{
    class NumAleatorio
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];

            Random aleat = new Random();

            for( int i = 0; i < 10; i++)
            {
                num[i] = aleat.Next(1, 10);
                
                Console.WriteLine("[" + i + "] " + num[i]);
            }
            Console.ReadKey();
        }
    }
}
