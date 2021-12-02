using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimOdevUygulama
{
    class Program
    {
        static void Main(string[] args)
        {

            Bilgisayar B1 = new Bilgisayar();
            B1.marka = "lenoova";
            B1.model = "z50";
            B1.islemci="i9";
            B1.alisFiyat = 1000;
            B1.satisFiyat = 1500;
            B1.kampanyaFiyat = 1000;
            B1.barkod = "1231654694896";

            SanalDb.yeniUrunEkle(B1);


            Bilgisayar B2 = new Bilgisayar();
            B2.marka = "lenoova";
            B2.model = "z50";
            B2.islemci="i9";
            B2.alisFiyat = 1000;
            B2.satisFiyat = 1500;
            B2.kampanyaFiyat = 1000;
            B2.barkod = "1231654694896";

            SanalDb.yeniUrunEkle(B2);


          

            Console.ReadLine();
        }
    }
}
