using System;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu nome?");
            string nome = Console.ReadLine();

            Console.Write("Que horas são? ");
            double horas = double.Parse(Console.ReadLine());

            if (horas >= 0.0 && horas <= 12.0)
            {
                Console.WriteLine("Bom dia, " + nome + ". Seja bem vindo(a)!");
            }
            else if (horas > 12.0 && horas <= 18.0)
            {
                Console.WriteLine("Boa tarde, " + nome + ". Seja bem vindo(a)!");
            }
            else
            {
                Console.WriteLine("Boa noite, " + nome + ". Seja bem vindo(a)!");
            }
            Console.ReadKey();
        }
    }
}
