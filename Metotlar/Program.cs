using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2, };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------------------------");
            }
            Console.WriteLine("--------------Metotlar-------------");

            //Metodu ana projede oluşturduk.
            SepetManager sepetManager = new SepetManager();
            //Metot Çağırma
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Süper Armut", 15, 9);

            //Console.WriteLine("Hello World!");
        }
    }
}


// Tekrar tekrar kullanılabilirliği sağlayan yapılara metotlar diyoruz.
// Do not repeat yourself. -- DRY -- CleanCode