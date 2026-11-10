using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atama_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1, s2;
            s1 = 10;
            s2 = 20;
            s1++;
            s2--;
            s1 += 5;
            s2 -= 8;
            s1 = s2++;
            s1--;
            s2 = ++s1;
            Console.WriteLine(s1);
            Console.Write(s2);
            Console.ReadKey();
        }
    }
}
