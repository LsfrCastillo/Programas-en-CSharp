using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc;
            do
            {
                Console.WriteLine("Escribe tu nombre: ");
                string nombre = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Ingrese el primer numero");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("ingrese el segundo numero");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double resultado = 0;

                Console.WriteLine("Ingrese la opcion deseada: 1 = SUMA || 2 = RESTA || 3 = division || 4 multiplicacion");
                opc = Convert.ToInt32(Console.ReadLine());
                while (opc > 4)
                {
                    Console.WriteLine("El valor ingresado es incorecto, intentelo denuevo");
                    opc = Convert.ToInt32(Console.ReadLine());
                }

                if (opc == 1)
                {
                    resultado = num1 + num2;
                }

                if (opc == 2)
                {
                    resultado = num1 - num2;
                }
                if (opc == 3)
                {
                    if (num2 < 1) { Console.WriteLine("El valor del numero 2 es menor o igual a 0"); }
                    else
                    { resultado = num1 / num2; }
                }
                if (opc == 4)
                {
                    resultado = num1 * num2;
                }
                Console.WriteLine("Tu resultado " + nombre + " es " + resultado);

                Console.ReadLine();
                Console.WriteLine("Queres volver a ejecutarlo? 1 = NO || 2 = SI, aclaracion si pones mas de 2, se va a repetir igual");
                opc = Convert.ToInt32(Console.ReadLine());
            } while(opc>1);
        }
    }
}
