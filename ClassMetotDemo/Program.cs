using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 1453;
            musteri1.MusteriAdi = "Kadir";
            musteri1.MusteriSoyadi = "Kaptan";
            musteri1.MusteriTcNo = "25668554973";
            musteri1.MusteriMeslek = "Software Engineer";
            musteri1.KrediTuru = "Özel Sektör Çalışanlarına Özel";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 1278;
            musteri2.MusteriAdi = "Veysel";
            musteri2.MusteriSoyadi = "Himmetoğlu";
            musteri2.MusteriTcNo = "666551455877";
            musteri2.MusteriMeslek = "Software Developer";
            musteri2.KrediTuru = "İhtiyaç Kredisi";
            musteri2.MusteriYas = 23;

            Musteri musteri3 = new Musteri
            {
                MusteriId = 2458,
                MusteriAdi = "Gizem",
                MusteriSoyadi = "Özlük",
                MusteriMeslek = "Doktor",
                MusteriTcNo = "45167824662",
                KrediTuru = "Maaşını Banka'dan Alanlara Özel",
                MusteriYas = 25,
            };

            Musteri[] musteris = { musteri1, musteri2 };

            foreach (Musteri musteri in musteris)
            {
                Console.WriteLine("Müşteri Id : " + musteri.MusteriId);
                Console.WriteLine("Müşteri Adi :" + musteri.MusteriAdi);
                Console.WriteLine("Müşteri Soyadi :" + musteri.MusteriSoyadi);
                Console.WriteLine("Müşteri TcNo : " + musteri.MusteriTcNo);
                Console.WriteLine("Müşteri Yaşı :" + musteri.MusteriYas);
                Console.WriteLine("Müşteri Meslek :" + musteri.MusteriMeslek);
                Console.WriteLine("Müşterinin Kredi Türü :" + musteri.KrediTuru);
            }

            Console.WriteLine("-------------------MetotlarI Uygulama - Newleme Kısmı-----------------------");
            Console.WriteLine("----------------------------Ekleme------------------------------------------");

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkleme(musteri1);
            musteriManager.MusteriEkleme(musteri2);

            Console.WriteLine("-----------------------------------Listeleme---------------------------------");

            musteriManager.MusteriListele(musteri1);
            musteriManager.MusteriListele(musteri2);

            Console.WriteLine("----------------------------------Silme--------------------------------------");
            musteriManager.MusteriSilme(musteri1);
            musteriManager.MusteriSilme(musteri2);

            Console.ReadLine();
        }

    }
}
