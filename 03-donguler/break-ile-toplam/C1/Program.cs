using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1
{
    class Program
    {
        static void Main(string[] args)
        {
            int tp = 0, s=0;
            for (int i = 0; true ; i++)
            {
                tp += i;
                Console.WriteLine(i);
                s = i;
                if (i == 50) break;
      
            }
            Console.WriteLine("Sayı = " + s);
            Console.Write("Toplam = " + tp);
            Console.ReadKey();
        }
    }
}
