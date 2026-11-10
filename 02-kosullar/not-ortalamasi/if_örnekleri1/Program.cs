using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_örnekleri1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            double ort;
            Console.Write("1. Not = ");
            n1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("2. Not = ");
            n2 = Convert.ToInt16(Console.ReadLine());
            ort = (n1 + n2) / 2;
            if (ort >= 50)
            {
                Console.Write("Geçti, " + ort);
            }
            else
            {
                Console.Write("Kaldı, " + ort);                   
            }
            Console.ReadKey();
        }
    }
}
