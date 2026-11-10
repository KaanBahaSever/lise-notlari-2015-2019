using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_örneği4
{
    class Program
    {
        static void Main(string[] args)
        {
            int f1, f2, idr, tp;
            Console.Write("1.ürün fiyatı = ");
            f1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("2.ürün fiyatı = ");
            f2 = Convert.ToInt16(Console.ReadLine());
            tp = f1 + f2;
            if (tp >= 500)
            {
                idr = (tp / 100) * 10;
                tp = tp - idr;
                Console.Write("indirimli fiyat = " + tp);
            }
            else
            {
                Console.Write("indirim yok = " + tp);
            }
            Console.ReadKey();

        }
    }
}
