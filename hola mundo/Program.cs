using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hola_mundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sabes quien soy?");
            Console.ReadKey();
            Console.Clear();

            /* crea primera linea de "*" */
            for (int i = 0; i < 30; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
            Console.WriteLine("*  Soy Julio Fallas Diaz :)  *");

            /* crea segunda linea de "*" */
            for (int i = 0; i < 30; i++)
            {
                Console.Write("*");
            }
            Console.ReadKey();
        }
    }
}
