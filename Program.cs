using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mixta_impropia
{
    class Program
    {
        static void Main(string[] args)
        {

            double cociente, numerador, denominador, resultado;

            Console.Title = " De fraccion mixta a impropia";
            Console.WriteLine("Programa que determina el tipo de fraccion");


            Console.WriteLine(" Ingrese el numero del cociente");
            cociente = double.Parse(Console.ReadLine());


            Console.WriteLine(" Ingrese el denominador de la fraccion");
            numerador = double.Parse(Console.ReadLine());



            Console.WriteLine("Ingrese el numerador de la fraccion");
            denominador = double.Parse(Console.ReadLine());



            resultado = (cociente * numerador + denominador);
            Console.WriteLine("La fraccion es : {0} / {1}", resultado, numerador);


            Console.ReadKey(); 



        }
    }
}
