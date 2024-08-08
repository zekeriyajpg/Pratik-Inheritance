# C#'ta Kalıtım Örneği

Bu proje, C# dilinde temel kalıtımı `BaseKisi` adlı bir temel sınıf ve bu sınıftan türeyen `Ogrenci` ve `Ogretmen` sınıfları ile göstermektedir. Proje, hem temel sınıfta hem de türetilmiş sınıflarda özellikler ve metotlar içermekte olup, kalıtımın nasıl çalıştığını açıklamaktadır.

## Sınıflar

### BaseKisi

- **Özellikler:**
  - `string Ad`: Kişinin adı.
  - `string Soyad`: Kişinin soyadı.

- **Metotlar:**
  - `void Yazdir()`: Kişinin adını ve soyadını konsol ekranına yazdırır.

### Ogrenci (BaseKisi'den türetilmiştir)

- **Ek Özellikler:**
  - `int OgrenciNumarasi`: Öğrencinin numarası.

- **Ek Metotlar:**
  - `void OgrenciBilgileriniYazdir()`: Öğrenci numarasını, adını ve soyadını konsol ekranına yazdırır.

### Ogretmen (BaseKisi'den türetilmiştir)

- **Ek Özellikler:**
  - `decimal Maas`: Öğretmenin maaşı.

- **Ek Metotlar:**
  - `void OgretmenBilgileriniYazdir()`: Maaş bilgisini, adını ve soyadını konsol ekranına yazdırır.

