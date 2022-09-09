using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HgsOopApp
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Otomobil arac1 = new Otomobil(12, "caglayan", "sancaktar");
            Minibus arac2 = new Minibus(13, "caglayan", "sancaktar");
            //Console.WriteLine(arac2.GetType());
            //Console.WriteLine(arac1.GetType().Name);
            //Console.WriteLine(arac1.bakiye);
            Gise.BakiyeEkle(arac1, 20);
            Gise.BakiyeEkle(arac2, 50);

            for (int i = 0; i < 3; i++)
            {
                if (Gise.Gecis(arac1))
                    Console.WriteLine(arac1.hgsNo + " numaralı araç geçiş yaptı. Güncel Bakiye: " + arac1.bakiye);
                else
                    Console.WriteLine(arac1.hgsNo + " numaralı araç için yetersiz bakiye.");
                Thread.Sleep(1000);
            }

            for (int i = 0; i < 3; i++)
            {
                if (Gise.Gecis(arac2))
                    Console.WriteLine(arac2.hgsNo + " numaralı araç geçiş yaptı. Güncel Bakiye: " + arac2.bakiye);
                else
                    Console.WriteLine(arac2.hgsNo + " numaralı araç için yetersiz bakiye.");
                Thread.Sleep(1000);
            }
            //Console.WriteLine(DateTime.Now.Date.ToShortDateString());

            OGSYonetimi.AracGecisleri();
            OGSYonetimi.GunlukBakiyeler();

            Console.ReadLine();


        }
    }
}
