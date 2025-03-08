using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace distancia_por_tiempo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vamos a solicitar la velocidad en km/h
            Console.Write("Introduce la velocidad del auto en km/h: ");
            int velocidad = int.Parse(Console.ReadLine());

            //Solicitaremos el tiempo en horas
            Console.Write("Introduce el tiempo de viaje en horas: ");
            int tiempo = int.Parse(Console.ReadLine());

            // Calcular la distancia (Distancia = Velocidad * Tiempo)
            int distancia = velocidad * tiempo;

            //Usaremos la clase Math.abs que asegura que la distancia sea positiva, incluso si la entrada es negativa
            distancia = (int)Math.Abs(distancia);  // Asegura que la distancia sea positiva

            //Se tiene que mostrar el resultado
            Console.WriteLine("El auto recorrerá " + distancia + " km en " + tiempo + " horas.");
            Console.Write("Presione una tecla para cerrar el programa.");
            //Se tiene que presionar una tecla para cerrar el programa
            Console.ReadKey();
        }
    }
}
