using System;
using System.Collections.Generic;


namespace Meryem_Çirkin_202113709049_ürün_puanlama
{
     class Program
    {
        static void yıldızla(List<int> yıldız)
        {
            while (true)
            {
                Console.WriteLine("1-5 arası puan verin.");
                int yıldızat = Convert.ToInt32(Console.ReadLine());
                if (yıldızat < 6 && yıldızat > 0)
                {
                    yıldız.Add(yıldızat);
                    break;
                }

            }

        }
        static void yorum_yaz(List<string> yorumlar)
        {
            string yorum = Console.ReadLine();

            yorumlar.Add(yorum);


        }
        static void yorumoku(List<string> yorumlar)
        {
            foreach (string item in yorumlar)
            {
                Console.WriteLine(item + "\n");

            }

        }
        static string yıldızpuanı(List<int> yıldız)
        {
            int sayı = 0;
            foreach (int item in yıldız)
            {
                sayı += item;
            }
            double cevap = (double)sayı / (double)(yıldız.Count);
            cevap.ToString();
            return "ortalama puan " + cevap + "\t\t" + yıldız.Count + " adet kişi puanladı";

        }
        static void Main(string[] args)
        {
            string çizgi = new string('-', 20);
            List<int> yıldız = new List<int>();
            List<String> yorumlar = new List<string>();
            while (true)
            {
                Console.WriteLine("1-puan ver \n2-yorum yap\n3-puan göster\n4-yorum göster");
                string seçim = Console.ReadLine();
                switch (seçim)
                {
                    case "1":

                        yıldızla(yıldız);


                        break;
                    case "2":

                        yorum_yaz(yorumlar);


                        break;
                    case "3":
                        Console.WriteLine(yıldızpuanı(yıldız));


                        break;
                    case "4":
                        yorumoku(yorumlar);



                        break;

                    default:
                        Console.WriteLine("hatalı tuşlama");
                        break;
                }
                Console.WriteLine(çizgi);
            }
        }
    }
}
