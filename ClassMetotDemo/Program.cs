using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Ahmet";
            musteri1.Soyadi = "Aslan";
            musteri1.Id = 1;
            musteri1.Yasi = 22;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Sevgi";
            musteri2.Soyadi = "Çalışkan";
            musteri2.Id = 2;
            musteri2.Yasi = 34;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Yasin";
            musteri3.Soyadi = "Üstün";
            musteri3.Id = 3;
            musteri3.Yasi = 51;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3};

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Listele(musteriler);



        }
    }
}
