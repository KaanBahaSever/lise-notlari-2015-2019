
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atama_örneği
{
    class Program
    {
        static void Main(string[] args)
        {
            const int kt = 2;
            int  sn1=30 , sn2=80 , sn3;
            sn1 = sn2 * 3;
            sn2 = sn2 + 45;
            sn2 = 500;
            sn3 = (sn1 + sn2)* kt;
            Console.WriteLine(sn1);
            Console.WriteLine(sn2);
            Console.Write(sn3);
            Console.ReadKey();
        }
    }
}
