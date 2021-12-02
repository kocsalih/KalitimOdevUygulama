using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimOdevUygulama
{
    public class Urun : BaseClass
    {
        public string marka { get; set; }
        public string model { get; set; }


        private decimal _aliFiyat;
        public decimal alisFiyat
        {
            get
            {
                return _aliFiyat;
            }
            set
            {
                if (value<=0)
                {
                    Console.WriteLine("Alış fiyatı 0 dan küçük veya eşit olamaz!!");
                }
                else
                {
                    _aliFiyat = value;
                }
            }
        }


        private decimal _satisFiyat;
        public decimal satisFiyat
        {
            get
            {
                return _satisFiyat;
            }
            set
            {
                if (value < _aliFiyat)
                {
                    Console.WriteLine("Ürünün satış fiyatı alış fiyatından küçük olamaz!!");
                }
                else
                {
                    _aliFiyat = value;
                }
            }
        }



        private decimal _kampanyaFiyat;
        public decimal kampanyaFiyat
        {
            get
            {
                return _kampanyaFiyat;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Kampanya fiyatı 0 dan küçük olamaz!!");
                }
                else
                {
                    _kampanyaFiyat = value;
                }
            }
        }



    }
}
