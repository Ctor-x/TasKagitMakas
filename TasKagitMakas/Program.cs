using System;

namespace TasKagitMakas
{
    class Program
    {
        static void Main(string[] args)
        {
            int kazanan = 0;
            int kaybeden = 0;
            int berabere = 0;
            string kullanici = " ";

            do
            {
                Console.WriteLine("Lütfen taş kağıt makas birini girin");
                kullanici = Console.ReadLine();


                string[] secenek = { "tas", "kagit", "makas" };

                Random rnd = new Random();

                int a = rnd.Next(3);

                if (kullanici == "tas" && secenek[a] == "kagit")
                {
                    kaybeden++;
                }
                if (kullanici == "tas" && secenek[a] == "makas")
                {
                    kazanan++;
                }
                if (kullanici == "makas" && secenek[a] == "kagit")
                {
                    kazanan++;
                }
                if (kullanici == "makas" && secenek[a] == "tas")
                {
                    kaybeden++;
                }
                if (kullanici == "kagit" && secenek[a] == "tas")
                {
                    kazanan++;
                }
                if (kullanici == "kagit" && secenek[a] == "makas")
                {
                    kaybeden++;
                }

                else
                {
                    berabere++;
                }


                if (kaybeden > kazanan)
                {
                    Console.WriteLine("Kaybettin");
                }
                else if (kaybeden < kazanan)
                {
                    Console.WriteLine("Kazandın");
                }
                else if (kazanan == kaybeden && berabere != 0)
                {
                    Console.WriteLine("Berabere");
                }

                Console.WriteLine("___________________");
            } while (kullanici != "a");
        }
    }
}
