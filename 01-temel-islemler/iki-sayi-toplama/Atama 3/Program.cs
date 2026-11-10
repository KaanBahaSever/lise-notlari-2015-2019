using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atama_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double s1, s2,tp;
            Console.Write("Sayı 1 = ");
            s1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Sayı 2 = ");
            s2 = Convert.ToDouble(Console.ReadLine());
            tp = s1 + s2;
            Console.WriteLine("");
            Console.Write("Sayı 1 ={0} Sayı 2 ={1} Toplam ={2} ",s1,s2,tp);
            Console.ReadKey();


        }
    }
}
