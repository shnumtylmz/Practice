using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            string[] fruits = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };


            // Type Safe --- Tip Güvenliği
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------");
            }

            Console.WriteLine("---------Metodlar---------");

            // İnstance -- Örnek
            // Encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            Console.WriteLine("------Örneeeek------");

            sepetManager.Ekle2("Armut","Yeşil Armut", 12, 3);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 6, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 10, 20);


        }
    }
}



// Do not repeat yourself -- DRY -- Clean Code -- Best Practise > Doğru Uygulama Teknikleri //

