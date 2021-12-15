using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirbiriyleSelamlasanIkiInsan
{
    class Program
    {
        static void Main(string[] args)
        {
            Insan i1 = new Insan();
            Insan i2 = new Insan();
            i1.Isimveyasduzenle("ali", 25);
            i2.Isimveyasduzenle("resul", 25);
            i1.SelamVer();
            i2.SelamVer();
            i1.BilgiSor();
            i2.CevapVer();
            i2.BilgiSor();
            i1.CevapVer();
            
            //Console.WriteLine(i1.Isimveyasyazdırma());
            //Console.WriteLine(i2.Isimveyasyazdırma());
            Console.ReadLine();

        }
    }
    class Insan
    {
        string isim;
        int yas;

        public void SelamVer()
        {
            Console.WriteLine("Merhaba!");
        }

        public void BilgiSor()
        {
            Console.WriteLine("Adın ne? ve Yaşın Kaç?");
        }

        public void CevapVer()
        {
            Console.WriteLine("Benim adım: "+isim+" ve yaşım: "+yas);
        }
         
        public void Isimveyasduzenle(string name,int age)
        {
            this.isim = name;
            this.yas = age;
        }

        public string Isimveyasyazdırma()
        {
            return isim + " " + yas;
        }
    }
}
