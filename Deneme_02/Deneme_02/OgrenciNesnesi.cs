using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme_02
{
    class OgrenciNesnesi
    {
        private String ogrenciNo;
        private String ogrenciAd;
        private DateTime sonGiris;


        public OgrenciNesnesi()
        {
            this.sonGiris = DateTime.MinValue;
        }


        public String getOgrenciNo()
        {
            return this.ogrenciNo;
        }
        public void setOgrenciNo(String ono)
        {
            this.ogrenciNo = ono;
        }



        public String getOgrenciAd()
        {
            return this.ogrenciAd;
        }
        public void setOgrenciAd(String oad)
        {
            this.ogrenciAd = oad;
        }


        public DateTime getSonGiris()
        {
            return this.sonGiris;
        }

        public void setSonGiris(DateTime sg)
        {
            this.sonGiris = sg;
        }

    }
}
