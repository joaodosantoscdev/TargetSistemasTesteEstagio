using System;

namespace TargetSistemasLPTeste___Exercício_5
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arrayFrase;
            Console.Write("[Inversor de String] Digite uma frase : ");
            string frase = Console.ReadLine();
            arrayFrase = frase.ToCharArray();

            char[] chars = frase.ToCharArray();
            int numChars = chars.Length - 1;
            for (int i = 0; i < numChars / 2; i++)
            {
                char temp = chars[i];
                chars[i] = chars[numChars - i];
                chars[numChars - i] = temp;
            }
            Console.WriteLine(chars);
        }
    }
}
