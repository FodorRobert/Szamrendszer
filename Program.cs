using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamrendszer
{
    internal class Program
    {
        public static List<int> atvaltas = new List<int>();
        public static int szam = input();
        static int input()
        {
            Console.WriteLine("Adj meg egy számot: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static void conv()
        {
            for (int i = 0; szam > 0; i++)
            {
                atvaltas.Add(szam % 2);
                szam /= 2;
            }
            atvaltas.Reverse();
        }
        static void Main(string[] args)
        {
            conv();
            foreach (int i in atvaltas)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }
}