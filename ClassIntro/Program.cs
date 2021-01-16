using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#"; 
            kurs1.egitmen = "Eğitmen"; 
            kurs1.izlenmeOrani = 65;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.egitmen = "Eğitmen2";
            kurs2.izlenmeOrani = 60;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.egitmen = "Eğitmen3";
            kurs3.izlenmeOrani = 20;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.egitmen = "Eğitmen4";
            kurs4.izlenmeOrani = 50;

            //Console.WriteLine(kurs1.KursAdi+" : "+kurs1.egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4 };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine("Kurs Adi" +" : "+ kurs.KursAdi);
                Console.WriteLine("Kurs Eğitmeni"+ " : "+kurs.egitmen);
                Console.WriteLine("Kurs İzlenme Oranı"+" : "+kurs.izlenmeOrani);
                Console.WriteLine("------------------");

            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string egitmen { get; set; }
        public int izlenmeOrani { get; set; }

    }
}
