using System;

namespace TargetSistemasLPTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("<[Calculadora de Fibonacci]> Digite um número: ");
            int input = int.Parse(Console.ReadLine());
            int zero = 0, fib = 1;

            while (fib < input) 
            {
                zero += fib;
                fib += zero;
            }

            if (fib == input || input <= 1 && input >= 0) 
                Console.WriteLine("<[Calculadora de Fibonacci]> Numero pertence a sequência Fibonacci! :)");
             else 
                Console.WriteLine("<[Calculadora de Fibonacci]> Numero não pertence a sequência Fibonacci! :("); }
        }
    }
}
