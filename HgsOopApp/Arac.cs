using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HgsOopApp
{
    public class Arac
    {
        private int _hgsNo, _bakiye = 0;
        private string _sahipAd, _sahipSoyad;
        private List<DateTime> _gecisZamanlari = new List<DateTime>();

        public List<DateTime> gecisZamanlari
        {
            get { return _gecisZamanlari; }
            set { this._gecisZamanlari = value; }
        }

        public string sahipAd
        {
            get { return _sahipAd; }
            set { this._sahipAd = value; }
        }

        public string sahipSoyad
        {
            get { return _sahipSoyad; }
            set { this._sahipSoyad = value; }
        }

        public int hgsNo
        {
            get { return _hgsNo; }
            set { this._hgsNo = value; }
        }

        public int bakiye
        {
            get { return _bakiye; }
            set { this._bakiye = value; }
        }
        protected Arac(int hgsNo, string sahipAd, string sahipSoyad)
        {
            this.hgsNo = hgsNo;
            this.sahipAd = sahipAd;
            this.sahipSoyad = sahipSoyad;
        }

    }
}
