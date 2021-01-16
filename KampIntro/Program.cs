using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemGiris = true;

            double dolarDun = 7.35;
            double dolarBugun = 7.45;


            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Oku");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Oku");
            }
            else
            {
                Console.WriteLine("Eşittir Oku");
            }

            if (sistemGiris==true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");

            }
            else
            {
                Console.WriteLine("Giriş yap Butonu");
            }


            Console.WriteLine(kategoriEtiketi);
        }
    }
}
