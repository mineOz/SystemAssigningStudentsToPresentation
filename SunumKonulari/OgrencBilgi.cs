using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunumKonulari
{
    class OgrenciBilgi
    {
        private string ad;
        private string soyad;
       

        public OgrenciBilgi () { }

        public void isimAta(string ad)
        {
            this.ad = ad;
        }
        public void soyadAta(string soyad)
        {
            this.soyad = soyad;
        }

        public string isimVer()
        {
            return ad;
        }
        public string soyadVer()
        {
           return soyad;
        }
  
    }   
}
