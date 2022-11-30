using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yurt
{
  public  class Ogrenci
    {

        public string tcno { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string telno { get; set; }
        public string email { get; set; }
        public string bolum { get; set; }
        public String dogumtarihi { get; set; }
        public byte[] profilfoto { get; set; }


        public Ogrenci(string tcno, string ad, string soyad, string telno, string email, string bolum, string dogumtarihi, byte[] profilfoto)
        {
            this.tcno = tcno;
            this.ad = ad;
            this.soyad = soyad;
            this.telno = telno;
            this.email = email;
            this.bolum = bolum;
            this.dogumtarihi = dogumtarihi;
            this.profilfoto = profilfoto;
        }
        public Ogrenci()
        {
          
        }
    }
}
