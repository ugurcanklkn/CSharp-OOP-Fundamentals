using System;
using System.Collections.Generic;
using System.Text;

namespace ilkProjem
{
    // Yazilimci sınıfı Calisan sınıfından MİRAS alıyor
    internal class Yazilimci : Calisan
    {
        // Ad, Yas ve Maas zaten Calisan'dan geldi!
        // Buraya sadece Yazılımcıya ÖZEL nitelikleri yazıyoruz:
        public string UzmanlikAlani { get; set; } = "";

        public void BilgileriYazdir()
        {
            Console.WriteLine($"[Yazılımcı Profil] Ad: {Ad} | Yaş: {Yas} | Maaş: {Maas} | Alan: {UzmanlikAlani}");
        }
    }
}
