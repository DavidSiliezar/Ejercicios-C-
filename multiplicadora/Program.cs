using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplicadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pedimos al usuario un número para la tabla de multiplicar
            Console.Write("Introduce el número para generar la tabla de multiplicar: ");
            int numero = int.Parse(Console.ReadLine());

            //Solicitamos al usuario el número hasta el cual quiere multiplicar
            Console.Write("Introduce el número hasta el cual deseas multiplicar: ");
            int limite = int.Parse(Console.ReadLine());

            //Esta vez vamos a usar Math.Abs para asegurarnos de que los números sean positivos
            numero = (int)Math.Abs(numero);
            limite = (int)Math.Abs(limite);

            //Vamos a hacer la tabla de multiplicar del número manualmente
            

            Console.WriteLine(numero + " x 1 = " + (numero * 1));
            Console.WriteLine(numero + " x 2 = " + (numero * 2));
            Console.WriteLine(numero + " x 3 = " + (numero * 3));
            Console.WriteLine(numero + " x 4 = " + (numero * 4));
            Console.WriteLine(numero + " x 5 = " + (numero * 5));
            Console.WriteLine(numero + " x 6 = " + (numero * 6));
            Console.WriteLine(numero + " x 7 = " + (numero * 7));
            Console.WriteLine(numero + " x 8 = " + (numero * 8));
            Console.WriteLine(numero + " x 9 = " + (numero * 9));
            Console.WriteLine(numero + " x 10 = " + (numero * 10));

            // Aquí es donde termina la multiplicación. 
            // Si se necesita hacer hasta un límite más grande (hasta 12, 20, etc.), 
            //Podemos agregar mas lineas si nosotros lo deseamos

            //El usuario tiene que presionar une tecla para cerrar el programa
            Console.Write("Presiona una tecla para cerrar el programa");
            Console.ReadKey();

        }
    }
}

