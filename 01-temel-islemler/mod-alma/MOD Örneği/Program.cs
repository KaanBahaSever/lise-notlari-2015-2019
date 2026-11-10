using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOD_Örneği
{
    class Program
    {
        static void Main(string[] args)
        {
            double s1,k1;
            const double b1=5;
            Console.Write("Sayı 1 = ");
            s1=Convert.ToDouble(Console.ReadLine());
            k1 = s1 % b1;
            Console.Write("{0} Sayısının {1}'e bölümünden kalan={2}",s1,b1,k1);
            Console.ReadKey();
        }
    }
}
