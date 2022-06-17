using System;

namespace Exercicio3
{
    //Escrever um algoritmo que lê 5 valores para a, um de cada vez, e conta
    //quantos destes valores são negativos, escrevendo esta informação.
    internal class Program
    {
        static void Main(string[] args)
        {
            int valorDeA;
            int cont = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("valor #" + (i + 1) + ": ");
                valorDeA = int.Parse(Console.ReadLine());

                if(valorDeA < 0)
                {
                    cont++;
                }
            }
            Console.WriteLine(cont + " valores negativos");
        }
    }
}
