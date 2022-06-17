using System;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("informe o número 1: ");
            double numero1 = double.Parse(Console.ReadLine());
            Console.Write("informe o número 2: ");
            double numero2 = double.Parse(Console.ReadLine());

            Console.WriteLine("----------------------------");

            Console.WriteLine(numero1 + " - " + numero2);
            
                double resultado = numero1 - numero2;
                Console.WriteLine("O resultado é: " + resultado);

            Console.WriteLine("----------------------------");

            Console.WriteLine(numero1 + " + " + numero2);

            resultado = numero1 + numero2;
            Console.WriteLine("O resultado é: " + resultado);

            Console.WriteLine("----------------------------");

            Console.WriteLine(numero1 + " * " + numero2);

            resultado = numero1 * numero2;
            Console.WriteLine("O resultado é: " + resultado);

            Console.WriteLine("----------------------------");

            Console.WriteLine(numero1 + " / " + numero2);

            if(numero1 == 0)
            {
                Console.WriteLine("impossível dividir por zero!");
            }
            else
            {
                resultado = numero1 / numero2;
                Console.WriteLine("O resultado é: " + resultado);
            }

            Console.ReadKey();
        }
    }
}
