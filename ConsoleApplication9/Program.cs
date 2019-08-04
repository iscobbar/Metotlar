using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Program
    {

        static void Main(string[] args)
        {
            //// 1. Metodu çağırdık.
            //MerhabaYaz();

            //Console.WriteLine("merhaba Dünya");

            // 2. Metodu Çağırdık.
            //string m = merhabadondur(); // string m = "merhaba dünya";
            //console.writeline(m);

            //m += " hava sıcak";
            //console.writeline(m);

            //Console.WriteLine(MerhabaDondur());

            // 3. Metodu Çağırıdk.
            //Console.WriteLine(PiKareDondur());
            //double p2 = PiKareDondur();

            //// 4. Metodu çağırdık.
            //EkranaYaz("Ahmet");
            //string isim = "Mustafa";
            //EkranaYaz(isim);

            ////// 5. Metodu çağırdık.
            //KullaniciBilgiYazdir("Erhan", "BURSALI", 1970);
            //string ad = "Gülcan";
            //string soyad = "SARI";
            //short dyili = 1990;
            //KullaniciBilgiYazdir(ad, soyad, dyili);

            // 6.
            //Console.Write("Ürün fiyatını giriniz: ");
            //double dFiyat = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(KDVHesapla(dFiyat));

            // 7.
            //Console.WriteLine(KDVHesapla(1000, 1));
            //Console.WriteLine(KDVHesapla(1000, 2));
            //Console.WriteLine(KDVHesapla(1000, 3));
            //Console.WriteLine(KDVHesapla(1000, 4));

            // 8.
            //int cevre = DortgenCevreHesapla(15, 25);
            //Console.WriteLine($"Kenarları 15 ve 25 cm uzunluktaki dortgenin çevresi:  {cevre} cm'dir.");



            //10
            int[] rastSayilar = DiziDondur(1555);
            //9
            DiziListele(rastSayilar);


            Console.Read();
        }
        // 1. Değer döndürmeyen, parametre almayan metot.
        static void MerhabaYaz()
        {
            Console.WriteLine("Merhaba Dünya");
        }

        // 2. Değer döndüren, parametre almayan metot.
        static string MerhabaDondur()
        {
            string merhaba = "Merhaba Dünya";
            return merhaba;
        }

        // 3. Değer döndüren ve parametre almayan metot.
        static double PiKareDondur()
        {
            double pikare = Math.PI * Math.PI;
            return pikare;
        }

        // 4. Değer döndürmeyen ve parametre alan metot.
        static void EkranaYaz(string ad)
        {
            Console.WriteLine($"Main metodundan gönderilen ad: {ad}");
        }

        // 5. Değer döndürmeyen ve parametre alan metot.
        static void KullaniciBilgiYazdir(string ad, string soyad, short dogumYili)
        {
            Console.WriteLine($"Ad: {ad} Soyad: {soyad} Yaşı: {2019 - dogumYili}");
        }

        // 6. Değer döndüren, parametre alan metot.
        static string KDVHesapla(double fiyat)
        {
            double KDV = fiyat * 0.18;
            double KDVliFiyat = fiyat * 1.18;
            return $"Ürünün KDV'si : {KDV}, KDV'li Fiyatı: {KDVliFiyat}";
        }

        // 7. 6'nın detaylısı
        static string KDVHesapla(double fiyat, byte urunTipi)
        {
            // urunTipi: 1 = ekmek, 2: gıda, 3: teknoloji
            double KDVOran = 1;
            if (urunTipi == 1)
            {
                KDVOran = 0.01;
            }
            else if (urunTipi == 2)
            {
                KDVOran = 0.08;
            }
            else if (urunTipi == 3)
            {
                KDVOran = 0.18;
            }
            else
            {
                return "Urun kodu hatalı olduğundan hesaplama yapılamamıştır.";
            }
            double KDV = fiyat * KDVOran;
            double KDVliFiyat = fiyat + KDV;
            return $"Ürünün KDV'si : {KDV}, KDV'li Fiyatı: {KDVliFiyat}";

        }

        // 8. Değer döndüren, parametre alan metot.

        static int DortgenCevreHesapla(short kenar1, short kenar2)
        {
            int cevre = 2 * (kenar1 + kenar2);
            return cevre;
        }

        // 9. Değer döndürmeyen parametre olarak dizi alan metot.

        static void DiziListele(int[] sayilar)
        {
            foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }
        }

        // 10. Dizi değer döndüren parametre alan metot.

        static int[] DiziDondur(int sayi)
        {
            int[] dizi = new int[5];
            Random rast = new Random();
            for (int i = 0; i <= 4; i++)
            {
                dizi[i] = rast.Next(sayi);
            }
            return dizi;
        }













    }
}