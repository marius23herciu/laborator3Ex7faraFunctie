using System;

namespace laborator3Ex7faraFunctie
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se citesc doua numere de la tastatura. Scrieti un program care va
            //calcula cel mai mare divizor comun al numerelor

            Ex7();
        }

        static void Ex7()
        {
            Console.WriteLine("Introduceti 2 numere:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int divizor;

            if (a == b)
            {
                divizor = a;
                Console.WriteLine("Cel mai mare divizor comun este " + divizor);
            }

            divizor = Math.Min(a, b);
            for (int i = 0; i < Math.Min(a, b); i++)
            {
                if (Math.Max(a, b) % divizor == 0 && Math.Min(a, b) % divizor == 0)
                {
                    Console.WriteLine("Cel mai mare divizor comun este " + divizor);
                    break;
                }
                divizor--;
            }
        }
    }
}
