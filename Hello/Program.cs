using System;

namespace Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string imię;

            Console.Write("Podaj imię: ");
            imię = Console.ReadLine();

            if (imię.Length == 0)
            {
                Console.WriteLine("Długość napisu wynosi zero.");
            }
            else
            {
                Console.Write("Witaj");
                
                int i = 0;
                while (i < imię.Length)
                {
                    Console.WriteLine(imię[i]);
                    i = i + 1;
                }
            }
        }
    }
}
