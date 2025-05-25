using System;
using System.Runtime.InteropServices;

namespace pt06
{
    internal class Program
    {
        static void Main(string[] args)
  {   
            System.Console.Write("canvi desde la webb ");
             System.Console.WriteLine(" canvi local :)  ");          

        {
      
            Console.Write("Introdueix un valor: ");
            if (int.TryParse(Console.ReadLine(), out int limit))
            {
                Console.WriteLine("Programa per comptar múltiples de 7.  ");

                Console.WriteLine($"Hi ha {Metodes.ContadorMultiples(limit)} números múltiples de 7 més petits que {limit}.");
            }
            else
            {
                Console.WriteLine("Valor no vàlid.");
            }
            
            var multiples = Metodes.ContadorMultiples(limit);
            Console.WriteLine("Nombres múltiples de 7 menors que " + limit + ":");
            foreach (var num in multiples)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
     
   
        class Metodes
        {
            public static List<int> ContadorMultiples(int limit) //amb aixo contem els multiples 
            {
                List<int> multiples = new List<int>();
                for (int i = 1; i < limit; i++)
                {
                    if (i % 7 == 0)
                    {
                        multiples.Add(i);
                    }
                }
                return multiples;
            }
        }
    }
}
