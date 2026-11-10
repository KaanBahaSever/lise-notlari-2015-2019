 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_örneği2
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1;
            Console.Write("bir sayı giriniz = ");
            s1 = Convert.ToInt16(Console.ReadLine());
            if (s1 < 0)
            {
                Console.Write("0 dan küçüktür");
            }
            else if (s1 < 0)
            {
                Console.Write("0 dan büyüktür");
            }
            else 
            {
                Console.Write("0 a eşittir");
            }
            Console.ReadKey();
        }
    }
}
