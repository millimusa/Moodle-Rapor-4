using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deneme_02
{
    class KayitNesnesi
    {
        private DateTime kayitTarih;
        private String gercekKullanici;
        private String gercekKullanici_No;
        private String etkilenenKullanici;
        private String etkilenenKullanici_No;
        private String etkinlikBaglami;
        private String etkinlikBilesen;
        private String etkinlikAdi;
        private String etkinlikAciklama;
        private String etkinlikMensei;
        private String etkinlikIPAdresi;





        public DateTime getKayitTarih()
        {
            return this.kayitTarih;
        }

        public void setKayitTarih(DateTime tt)
        {
            this.kayitTarih = tt;
        }



        public String getGercekKullanici()
        {
            return this.gercekKullanici;
        }
        public void setGercekKullanici(String gk)
        {
            this.gercekKullanici = gk;
        }



        public String getGercekKullanici_No()
        {
            return this.gercekKullanici_No;
        }
        public void setGercekKullanici_No(String gkno)
        {
            this.gercekKullanici_No = gkno;
        }



        public String getEtkilenenKullanıcı()
        {
            return this.etkilenenKullanici;
        }
        public void setEtkilenenKullanıcı(String ek)
        {
            this.etkilenenKullanici = ek;
        }



        public String getEtkilenenKullanıcı_No()
        {
            return this.etkilenenKullanici_No;
        }
        public void setEtkilenenKullanıcı_No(String ek)
        {
            this.etkilenenKullanici_No = ek;
        }



        public String getEtkinlikBaglami()
        {
            return this.etkinlikBaglami;
        }
        public void setEtkinlikBaglami(String eb)
        {
            this.etkinlikBaglami = eb;
        }



        public String getEtkinlikBilesen()
        {
            return this.etkinlikBilesen;
        }
        public void setEtkinlikBilesen(String bil)
        {
            this.etkinlikBilesen = bil;
        }



        public String getEtkinlikAdi()
        {
            return this.etkinlikAdi;
        }
        public void setEtkinlikAdi(String ea)
        {
            this.etkinlikAdi = ea;
        }



        public String getEtkinlikAciklama()
        {
            return this.etkinlikAciklama;
        }
        public void setEtkinlikAciklama(String etac)
        {
            this.etkinlikAciklama = etac;
        }



        public String getEtkinlikMensei()
        {
            return this.etkinlikMensei;
        }
        public void setEtkinlikMensei(String em)
        {
            this.etkinlikMensei = em;
        }



        public String getEtkinlikIPAdresi()
        {
            return this.etkinlikIPAdresi;
        }
        public void setEtkinlikIPAdresi(String em)
        {
            this.etkinlikIPAdresi = em;
        }
    }
}
