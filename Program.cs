using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] Mat = new string[5, 2];
            string maxsueldo = "0";
            string empleadoconmax = "";


            for (int f = 0; f < 5; f++)

            {
                Console.WriteLine("Introduzca el nombre del empleado");
                Mat[f,0] = Console.ReadLine();
            }

            for (int f = 0; f < 5; f++)
            {
                Console.WriteLine("Introduzca el sueldo de " + Mat[f, 0]);
                Mat[f, 1] = Console.ReadLine();
            }


            for (int f = 0; f < 5; f++)
            {
                if (int.Parse(maxsueldo) < int.Parse(Mat[f, 1]))
                {
                    maxsueldo = Mat[f, 1];
                    empleadoconmax = Mat[f, 0];
                }
            }

                Console.WriteLine("El empleado con sueldo maximo es " + empleadoconmax + " y su sueldo es de " + maxsueldo);
                Console.ReadLine();
            
        }
    }
}
