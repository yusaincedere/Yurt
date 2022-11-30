using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yurt
{
    public class Yonetici
    {
        public string tcno { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string telno { get; set; }
        public string email { get; set; }
        public string sifre { get; set; }
        public String dogumtarihi { get; set; }
        public byte[] profilfoto { get; set; }


        public Yonetici(string tcno, string ad, string soyad, string telno, string email, string sifre, string dogumtarihi, byte[] profilfoto)
        {
            this.tcno = tcno;
            this.ad = ad;
            this.soyad = soyad;
            this.telno = telno;
            this.email = email;
            this.sifre = sifre;
            this.dogumtarihi = dogumtarihi;
            this.profilfoto = profilfoto;
        }
        public Yonetici()
        {

        }

    }
}
