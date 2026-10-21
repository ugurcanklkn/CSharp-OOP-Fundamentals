using ilkProjem;

// 1. KISIM: DEĞİŞKENLER VE KONSOL ÇIKTILARI
string ad = "Ugur";
char harf = 'u';
int yas = 26;
double Maas = 75000.50;
bool suandaYazilimcimi = false;

Console.WriteLine($"Ad: {ad}\nHarf: {harf}\nYaş: {yas}\nHedef Maaş: {Maas}\nYazılımcı mı: {suandaYazilimcimi}");

if (Maas > 70000)
{
    Console.WriteLine("Yüksek hedef! Disiplinli çalışma gerektirir.");
}
else
{
    Console.WriteLine("Makul bir hedef, adım adım ilerliyoruz.");
}

Console.WriteLine("-------------------------------------------");

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"{i}. Ay tamamlandı: Yazılım öğrenmeye ve kod yazmaya devam !");
}

Console.WriteLine("-------------------------------------------");

// 2. KISIM: ŞABLONDAN GERÇEK NESNE (OBJECT) ÜRETİYORUZ
Yazilimci yeniYazilimci = new Yazilimci();

// Nesnenin özelliklerini dolduruyoruz
yeniYazilimci.Ad = "Uğur";
yeniYazilimci.Yas = 26;
yeniYazilimci.Maas = 75000.50; // Calisan.cs içindeki Kapsüllemeye tabi tutulur!
yeniYazilimci.UzmanlikAlani = "Backend Development";

// Nesnenin metodunu çağırıyoruz
yeniYazilimci.BilgileriYazdir();

// 3. KISIM: KAPSÜLLEME TESTİ (Hatalı maaş denemesi)
Console.WriteLine("-------------------------------------------");
Yazilimci testYazilimci = new Yazilimci();
testYazilimci.Ad = "Ahmet";
testYazilimci.Yas = 20;
testYazilimci.Maas = 5000; // Asgari ücretten düşük, kontrol çalışacak!
testYazilimci.UzmanlikAlani = "Intern";
testYazilimci.BilgileriYazdir();