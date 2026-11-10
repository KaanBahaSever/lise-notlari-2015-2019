using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metinsel_İfadeler
{
    class Program
    {
        static void Main(string[] args)
        {
            int ss1, s2, tp;
            Console.Write("1. Sayı = ");
            ss1=Convert.ToInt16(Console.ReadLine());
            Console.Write("2. Sayı = ");
            s2=Convert.ToInt16(Console.ReadLine());
            tp = ss1 + s2;
            Console.WriteLine("1. Sayı = "+ss1+" 2.Sayı = "+s2+" Toplam = " + tp);
            Console.ReadKey();
        }
    }
}
