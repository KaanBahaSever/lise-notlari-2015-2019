using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1
{
    class Program
    {
        class mst
        {
            private Int64 tcno;
            private int odano;
            private string adsyd;
            public Int64 ads
            {
                get
                {
                    return tcno;
                }
                set
                {
                    string a = Convert.ToString(value);
                    if (a.Length != 11)
                    {
                        Console.WriteLine("11 Haneli olacak");
                        for (int i = 0; true; i++)
                        {
                            Console.Write("Yeni Tcno = ");
                            a = Console.ReadLine();
                            if (a.Length == 11)
                            {
                                tcno = Convert.ToInt64(a);
                                break;
                            }
                            Console.WriteLine("11 Haneli Olması Gerekiyor");
                        }
                    }
                    else
                    {
                        tcno = value;
                    }
                }
            }
            public int odn
            {
                get
                {
                    return odano;
                }
                set
                {
                    if (value > 0 && value < 120)
                    {
                        odano = value;
                    }
                    else
                    {
                        Console.WriteLine("0-120 Arasında girin");
                        for (int i = 0; true ; i++)
                        {
                            Console.Write("Oda No = ");
                            value = int.Parse(Console.ReadLine());
                            if (value > 0 && value < 120)
                            {
                                odano = value;
                                break;
                            }
                            Console.WriteLine("0-120 Arasında giriniz");
                        }
                    }
                }
            }
            public string ism
            {
                get
                {
                    return adsyd;
                }
                set
                {
                    adsyd = value;
                }
            }
        }

        static void Main(string[] args)
        {
            mst deaw = new mst();
            Console.Write("Ad Soyad = ");
            deaw.ism = Console.ReadLine();
            Console.Write("Oda Numarası = ");
            deaw.odn = int.Parse(Console.ReadLine());
            Console.Write("Tcno = ");
            deaw.ads = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("------Değerler------");
            Console.WriteLine();
            Console.WriteLine("AD SOYAD = " + deaw.ism);
            Console.WriteLine("TC NO = " + deaw.ads);
            Console.Write("ODA NUMARASI = " + deaw.odn);
            Console.ReadKey();
        }
    }
}

