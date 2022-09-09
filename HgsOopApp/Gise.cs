using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HgsOopApp
{
    public class Gise
    {
        //public static Dictionary<DateTime, Arac> Gecisler = new Dictionary<DateTime, Arac>();
        public static List<Tuple<DateTime, Arac>> Gecisler = new List<Tuple<DateTime, Arac>>();
        public static Dictionary<string, int> GunlukBakiyeler = new Dictionary<string, int>();
        public static void BakiyeEkle(Arac arac, int bakiye)
        {
            arac.bakiye += bakiye;
        }

        public static bool Gecis(Arac arac)
        {
            DateTime gecisZamani = DateTime.Now;
            if (arac.GetType().Name.Equals("Otomobil")){
                if (arac.bakiye < 5)
                    return false;
                arac.bakiye -= 5;
                if (GunlukBakiyeler.ContainsKey(gecisZamani.Date.ToShortDateString()))
                {
                    GunlukBakiyeler[gecisZamani.Date.ToShortDateString()] = GunlukBakiyeler[gecisZamani.Date.ToShortDateString()] + 5;
                }
                else
                {
                    GunlukBakiyeler.Add(gecisZamani.Date.ToShortDateString(), 5);
                }
            }
            else if (arac.GetType().Name.Equals("Minibus"))
            {
                if (arac.bakiye < 10)
                    return false;
                arac.bakiye -= 10;
                if (GunlukBakiyeler.ContainsKey(gecisZamani.Date.ToShortDateString()))
                {
                    GunlukBakiyeler[gecisZamani.Date.ToShortDateString()] = GunlukBakiyeler[gecisZamani.Date.ToShortDateString()] + 10;
                }
                else
                {
                    GunlukBakiyeler.Add(gecisZamani.Date.ToShortDateString(), 10);
                }
            }
            else
            {
                if (arac.bakiye < 15)
                    return false;
                arac.bakiye -= 15;
                if (GunlukBakiyeler.ContainsKey(gecisZamani.Date.ToShortDateString()))
                {
                    GunlukBakiyeler[gecisZamani.Date.ToShortDateString()] = GunlukBakiyeler[gecisZamani.Date.ToShortDateString()] + 15;
                }
                else
                {
                    GunlukBakiyeler.Add(gecisZamani.Date.ToShortDateString(), 15);
                }
            }

            arac.gecisZamanlari.Add(gecisZamani);
            Gecisler.Add(new Tuple<DateTime, Arac>(gecisZamani, arac));

            return true;
        }
    }
}
