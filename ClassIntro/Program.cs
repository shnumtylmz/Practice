using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 67;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.egitmen = "Kerem Mehmet";
            kurs2.IzlenmeOrani = 88;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "HTML-CSS";
            kurs3.egitmen = "Berkay AM";
            kurs3.IzlenmeOrani = 900;

            // Console.WriteLine(kurs2.KursAdi + " : " + kurs1.egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.egitmen);
            }

        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }

}
