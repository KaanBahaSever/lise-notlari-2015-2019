using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_örneği_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double s1, s2, sonuc = 0;
            char islem;
            Console.Write("bir sayı giriniz = ");
            s1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("ikinci sayıyı giriniz = ");
            s2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("işlemi seçiniz +, -, /, *, % = ");
            islem = Convert.ToChar(Console.ReadLine());
            if (islem == '+')
            {
                sonuc = s1 + s2;
                Console.Write("İşlem Sonucunuz = " + sonuc);
            }
            else if (islem == '-')
            {
                sonuc = s1 - s2;
                Console.Write("işlem sonucunuz = " + sonuc);
            }
            else if (islem == '*')
            {
                sonuc = s1 * s2;
                Console.Write("İşlem Sonucunuz = " + sonuc);
            }
            else if (islem == '/')
            {
                sonuc = s1 / s2;
                Console.Write("İşlem Sonucunuz = " + sonuc);
            }
            else if (islem == '%')
            {
                    sonuc = s1 % s2;
                Console.Write("Kalan = " + sonuc);
            }
            else
            {
                Console.Write("Yanlış Tuş");
            }
                Console.ReadKey();
            }
        }
    }
    