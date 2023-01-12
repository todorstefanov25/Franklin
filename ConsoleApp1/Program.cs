using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> opashka = new Queue<int>();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Vuvedi element lek");
                opashka.Enqueue(int.Parse(Console.ReadLine()));
            }
           
            Console.Write("Posleden element: ");
            int nomera = opashka.Last();
            Console.WriteLine(nomera);

            Console.Write("Minimalen element: ");
            int nomera1 = opashka.Min();
            Console.WriteLine(nomera1);
        }
    }
}
