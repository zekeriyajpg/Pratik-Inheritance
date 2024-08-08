using Pratik_Inheritance;

BaseKisi baseKisi = new BaseKisi();

baseKisi.Ad = "Ali";
baseKisi.Soyad = "Kınık";
baseKisi.Yazdir();

Console.WriteLine("*****************************************************************");
// Create an instance of Ogrenci and set properties
// Bir Ogrenci nesnesi oluştur ve özelliklerini ayarla
Ogrenci ogrenci = new Ogrenci
{
    Ad = "Ahmet",
    Soyad = "Kaya",
    Ogrencino = 123456789

};
// Print student details
// Öğrenci bilgilerini yazdır
ogrenci.Ogrencibilgigetir();

Console.WriteLine("*****************************************************************");
// Create an instance of Ogretmen and set properties
// Bir Ogretmen nesnesi oluştur ve özelliklerini ayarla
Ogretmen ogretmen = new Ogretmen();

ogretmen.Ad = "Abdullah";
ogretmen.Soyad = "Paksoy";
ogretmen.Maas = 45000;
// Print teacher details
// Öğretmen bilgilerini yazdır
ogretmen.Ogretmenbilgigetir();
