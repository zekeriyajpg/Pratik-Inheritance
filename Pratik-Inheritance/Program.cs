using Pratik_Inheritance;

BaseKisi baseKisi = new BaseKisi();

baseKisi.Ad = "Ali";
baseKisi.Soyad = "Kınık";
baseKisi.Yazdir();

Console.WriteLine("*****************************************************************");

Ogrenci ogrenci = new Ogrenci
{
    Ad = "Ahmet",
    Soyad = "Kaya",
    Ogrencino = 123456789

};
ogrenci.Ogrencibilgigetir();

Console.WriteLine("*****************************************************************");

Ogretmen ogretmen = new Ogretmen();

ogretmen.Ad = "Abdullah";
ogretmen.Soyad = "Paksoy";
ogretmen.Maas = 45000;
ogretmen.Ogretmenbilgigetir();
