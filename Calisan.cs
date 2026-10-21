using System;
using System.Collections.Generic;
using System.Text;

namespace ilkProjem
{
    // ANA SINIF (BASE CLASS)
    internal class Calisan
{
    public string Ad { get; set; } = "";
    public int Yas { get; set; }
        // 1. Değişkeni gizliyoruz
        private double _maas;

        // 2. Kapsüllenen Ortak Özellik (Property)
        public double Maas
        {
            get
            {
                return _maas;
            }
            set
            {
                if (value < 17002)
                {
                    Console.WriteLine("HATA: Çalışan maaşı asgari ücretten düşük olamaz! Otomatik 17.002 TL atandı.");
                    _maas = 17002;
                }
                else
                {
                    _maas = value;
                }
            }
        }

        public void Calis()
    {
        Console.WriteLine($"{Ad} şu an mesaide çalışıyor...");
    }
}
}
