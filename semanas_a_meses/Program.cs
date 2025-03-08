using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semanas_a_meses
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar el número de semanas y usar un tipo entero
            Console.Write("Introduce el número de semanas: ");
            int semanas = int.Parse(Console.ReadLine());

            // Calcular la cantidad de meses usando Math (división entera)
            int meses = (int)Math.Round(semanas / 4.0);  // Aproximación de semanas en un mes y redondeo

            // Mostrar el resultado
            Console.WriteLine("El número de meses es: " + meses);
            Console.Write("Presione una tecla para cerrar");
            Console.ReadKey();
        }
    }
}
