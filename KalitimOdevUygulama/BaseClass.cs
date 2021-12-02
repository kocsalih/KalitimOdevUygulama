using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalitimOdevUygulama
{
    public class BaseClass
    {
        public static int sayac = 1;

        private int _id;
        public int id
        {
            get { return _id; }
            private set
            {

            }
        }

        public BaseClass()
        {

            _id = sayac;
            sayac = sayac + 1;

        }

        private string _barkod;
        public string barkod
        {
            get
            {
                return _barkod;
            }
            set
            {
                bool kontrolIslemi = SanalDb.dbBarkodKontrol(value);
                if (!kontrolIslemi)
                {
                    _barkod = value;

                }
                else Console.WriteLine("sanl database içerisinde Bu barkod değeri Girilmiştir!");
            }
        }

        public DateTime olusturmaTarih { get; set; }
        public int olusturranKullanici { get; set; }

        public DateTime guncellemeTarih { get; set; }
        public int guncelleyenKullanici { get; set; }

        public bool silindi { get; set; }



    }
}
