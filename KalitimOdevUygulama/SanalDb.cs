using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace KalitimOdevUygulama
{
   public static class SanalDb
    {
        private static ArrayList db = new ArrayList();

        public static void yeniUrunEkle(BaseClass data)
        {
            if (data!=null&&!string.IsNullOrEmpty(data.barkod))
            {
                db.Add(data);

            }
        }

        public static bool dbBarkodKontrol(string dbbarkod)
        {
            bool kontrolIslemi = false;

            if (db!=null&&db.Count>0)
            {
                for (int i = 0; i < db.Count; i++)
                {
                    BaseClass bc = (BaseClass)db[i];
                    if (bc.barkod==dbbarkod)
                    {
                        kontrolIslemi = true;

                    }
                }
            }

            return kontrolIslemi;
        }


    }
}
