using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkleme(Musteri musteri)
        {
            Console.WriteLine("Müşteri Id : " + musteri.MusteriId);
            Console.WriteLine("Müşteri Adi :" + musteri.MusteriAdi);
            Console.WriteLine("Müşteri Soyadi :" + musteri.MusteriSoyadi);
            Console.WriteLine("Müşteri TcNo : " + musteri.MusteriTcNo);
            Console.WriteLine("Müşteri Yaşı :" + musteri.MusteriYas);
            Console.WriteLine("Müşteri Meslek :" + musteri.MusteriMeslek);
            Console.WriteLine("Müşterinin Kredi Türü :" + musteri.KrediTuru);
            Console.WriteLine("Müşteri Eklenmiştir !");
        }

        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine("Müşteri Id : " + musteri.MusteriId);
            Console.WriteLine("Müşteri Adi :" + musteri.MusteriAdi);
            Console.WriteLine("Müşteri Soyadi :" + musteri.MusteriSoyadi);
            Console.WriteLine("Müşteri TcNo :" + musteri.MusteriTcNo);
            Console.WriteLine("Müşteri Yaşı :" + musteri.MusteriYas);
            Console.WriteLine("Müşteri Meslek :" + musteri.MusteriMeslek);
            Console.WriteLine("Müşterinin Kredi Türü :" + musteri.KrediTuru);
            Console.WriteLine("Müşteri Silinmiştir !");
        }

        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine("Müşteri Id : " + musteri.MusteriId);
            Console.WriteLine("Müşteri Adi :" + musteri.MusteriAdi);
            Console.WriteLine("Müşteri Soyadi :" + musteri.MusteriSoyadi);
            Console.WriteLine("Müşteri TcNo :" + musteri.MusteriTcNo);
            Console.WriteLine("Müşteri Yaşı :" + musteri.MusteriYas);
            Console.WriteLine("Müşteri Meslek :" + musteri.MusteriMeslek);
            Console.WriteLine("Müşterinin Kredi Türü :" + musteri.KrediTuru);
            Console.WriteLine("Müşteri listelenmiştir ! ");
        }
    }
}
