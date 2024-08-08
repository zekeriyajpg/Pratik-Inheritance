using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik_Inheritance
{
    public class BaseKisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }


        public void Yazdir()
        {
            Console.WriteLine($"Ad: {Ad} Soyad: {Soyad}");


        }
    }

    class Ogrenci : BaseKisi
    {
        public int Ogrencino { get; set; }

        public void Ogrencibilgigetir()
        {
            Console.WriteLine("Öğrenci Numarası : " +Ogrencino );
            Yazdir();
        }
    }

    class Ogretmen : BaseKisi
    {
        public int Maas { get; set; }
        public void Ogretmenbilgigetir()
        {
            Console.WriteLine("Maaş : " + Maas);
            Yazdir() ;
        }

    }
 }
