using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik_Inheritance
{
    // Base class
    // Temel sınıf
    public class BaseKisi
    {
        // Properties
        // Özellikler
        public string Ad { get; set; }
        public string Soyad { get; set; }

        // Method to print name and surname
        // Ad ve soyad yazdıran meto
        public void Yazdir()
        {
            Console.WriteLine($"Ad: {Ad} Soyad: {Soyad}");


        }
    }
    // Derived class for students
    // Öğrenciler için türetilmiş sınıf

    class Ogrenci : BaseKisi
    {
        // Additional property for student number
        // Öğrenci numarası için ek özellik
        public int Ogrencino { get; set; }
        // Method to print student number, name, and surname
        // Öğrenci numarası, ad ve soyad yazdıran metot

        public void Ogrencibilgigetir()
        {
            Console.WriteLine("Öğrenci Numarası : " +Ogrencino );
            // Call the base class method to print name and surname
            // Ad ve soyad yazdırmak için temel sınıf metodunu çağır
            Yazdir();
        }
    }
    // Derived class for teachers
    // Öğretmenler için türetilmiş sınıf

    class Ogretmen : BaseKisi
    {
        // Additional property for salary
        // Maaş bilgisi için ek özellik
        public int Maas { get; set; }
        // Method to print salary, name, and surname
        // Maaş bilgisi, ad ve soyad yazdıran metot
        public void Ogretmenbilgigetir()
        {
            Console.WriteLine("Maaş : " + Maas);
            // Call the base class method to print name and surname
            // Ad ve soyad yazdırmak için temel sınıf metodunu çağır
            Yazdir() ;
        }

    }
 }
