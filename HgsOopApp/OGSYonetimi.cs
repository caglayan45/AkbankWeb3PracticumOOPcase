using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HgsOopApp
{
    class OGSYonetimi
    {
        public static void AracGecisleri()
        {
            Console.WriteLine("\nTüm geçişler:");
            foreach (Tuple<DateTime, Arac> gecis in Gise.Gecisler)
            {
                Console.WriteLine("Tarih: " + gecis.Item1 + "\nArac;\tHgs No: " + gecis.Item2.hgsNo + "\n\tAraç Tipi: " + gecis.Item2.GetType().Name + "\n");
            }
            Console.WriteLine();
        }

        public static void AracGecisleri(Arac arac)
        {
            Console.WriteLine(arac.hgsNo + " HGS numaralı aracın geçişleri:");
            foreach (DateTime zaman in arac.gecisZamanlari)
            {
                Console.WriteLine("\t" + zaman.ToString());
            }
            Console.WriteLine();
        }

        public static void GunlukBakiyeler()
        {
            Console.WriteLine("Günlük Bakiyeler;");
            foreach (KeyValuePair<string,int> gun in Gise.GunlukBakiyeler)
            {
                Console.WriteLine("\tTarih:" + gun.Key + " Toplam bakiye: " + gun.Value);
            }
            Console.WriteLine();
        }
    }
}
