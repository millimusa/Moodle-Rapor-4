using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deneme_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private KayitNesnesi gelenKayit = new KayitNesnesi();
        private OgrenciNesnesi ogrenci = new OgrenciNesnesi();
        private List<KayitNesnesi> listKayitlar = new List<KayitNesnesi>();
        private List<OgrenciNesnesi> listOgrenciler = new List<OgrenciNesnesi>();

        private void Dosya_Ac_ve_Kayit_Doldur()
        {  
            FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);

            char[] separators = new char[] {',', '\"' };

            string yazi = sw.ReadLine();
            yazi = sw.ReadLine();
            String[] temp = yazi.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            String[] temp2;
            String tempIsim = "";
            while (yazi != null)
            {
                Console.WriteLine(yazi);
                temp = yazi.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                gelenKayit.setKayitTarih(Convert.ToDateTime(temp[0] + " " + temp[1]));

                temp2 = temp[2].Split(' ');
                tempIsim = temp2[0];
                for (int i = 1; i < temp2.Length - 1; i++)
                    tempIsim += " " + temp2[i];

                gelenKayit.setGercekKullanici(tempIsim);
                gelenKayit.setGercekKullanici_No(temp2[temp2.Length-1]);

                temp2 = temp[3].Split(' ');
                tempIsim = temp2[0];
                for(int i = 1; i < temp2.Length - 1; i++)
                    tempIsim += " " + temp2[i];

                gelenKayit.setEtkilenenKullanıcı(tempIsim);
                gelenKayit.setEtkilenenKullanıcı_No(temp2[temp2.Length - 1]);
                gelenKayit.setEtkinlikBaglami(temp[4]);
                gelenKayit.setEtkinlikBilesen(temp[5]);
                gelenKayit.setEtkinlikAdi(temp[6]);
                gelenKayit.setEtkinlikAciklama(temp[7]);
                gelenKayit.setEtkinlikMensei(temp[8]);
                gelenKayit.setEtkinlikIPAdresi(temp[9]);

                listKayitlar.Add(gelenKayit);
                gelenKayit = new KayitNesnesi();
                yazi = sw.ReadLine();
            }
            sw.Close();
            fs.Close();

        }

        private int  Ogrencileri_Bul_ve_Doldur()
        {
            int ogrenciSayisi = 0;
            OgrenciNesnesi temp = new OgrenciNesnesi();

            richTxtOgrenciListesi.Text = "";
            lblDers.Text = listKayitlar.ElementAt(0).getEtkinlikBaglami();
            foreach (KayitNesnesi kayit in listKayitlar)                                //Derse eklenenler bulunuyor...
            {
                temp = new OgrenciNesnesi();
                if (kayit.getEtkinlikAdi() == "Kullanıcı derse kaydoldu" && Char.IsDigit(kayit.getEtkilenenKullanıcı_No()[kayit.getEtkilenenKullanıcı_No().Length-1]))
                {
                    temp.setOgrenciAd(kayit.getEtkilenenKullanıcı());
                    temp.setOgrenciNo(kayit.getEtkilenenKullanıcı_No());
                    listOgrenciler.Add(temp);

                    ogrenciSayisi++;
                }
            }

            foreach (KayitNesnesi kayit in listKayitlar)                                //Derten kaydı silinenler çıkarılıyor...
            {
                temp = new OgrenciNesnesi();
                if (kayit.getEtkinlikAdi() == "Kullanıcı ders kaydını sildi")
                {
                    listOgrenciler.RemoveAt(listOgrenciler.FindIndex(x => x.getOgrenciNo() == kayit.getEtkilenenKullanıcı_No()));
                    ogrenciSayisi--;
                }
            }

            foreach(OgrenciNesnesi kayit in listOgrenciler)                             //Öğrenci Listesi yazdırılıyor...
            {
                richTxtOgrenciListesi.Text += kayit.getOgrenciNo() + "\t" + kayit.getOgrenciAd() + "\n";
            }

            return ogrenciSayisi;
        }

        private void Ogrencileri_Son_Giris_Doldur()
        {
            int etkinlik_sayisi = 0;
            String b = new String(cmbZamanDilimi.SelectedItem.ToString().Where(Char.IsDigit).ToArray());

            foreach (OgrenciNesnesi ogrenci in listOgrenciler)
            {
                ogrenci.setSonGiris(DateTime.MinValue);
            }

            foreach (KayitNesnesi kayit in listKayitlar)
            {
                if (kayit.getKayitTarih() < DateTime.Now.AddDays(-Convert.ToInt32(b)))      //Kayıtlar yeniden eskiye olduğu için bu optimizasyonu yapabliyoruz. Aksi halde yanlış çalışır....
                {
                    break;
                }
                foreach (OgrenciNesnesi ogrenci in listOgrenciler)
                {
                    if (kayit.getGercekKullanici_No() == ogrenci.getOgrenciNo())
                    {
                        if (kayit.getKayitTarih() > ogrenci.getSonGiris())
                        {
                            ogrenci.setSonGiris(kayit.getKayitTarih());
                        }
                        etkinlik_sayisi++;
                    }
                }
            }
            lblToplamEtkilesim.Text = etkinlik_sayisi.ToString();
        }


            private void Girmeyen_Ogrenci_Listele()
        {
            int Derse_Girmeyen = 0;
            richTxtGelmeyenOgrenciler.Text = "";
            foreach (OgrenciNesnesi ogrenci in listOgrenciler)
            {
                if (ogrenci.getSonGiris() == DateTime.MinValue)
                {
                    richTxtGelmeyenOgrenciler.Text += ogrenci.getOgrenciNo() + "\t" + ogrenci.getOgrenciAd() + "\n";
                    Derse_Girmeyen++;
                }
            }
            lblDerseGiren.Text = (listOgrenciler.Count - Derse_Girmeyen).ToString();
            lblDerseGirmeyen.Text = Derse_Girmeyen.ToString();
        }

        private void Kopyala_Clipboard()
        {
            if (richTxtGelmeyenOgrenciler.Text != "")
            {
                Clipboard.SetText(richTxtGelmeyenOgrenciler.Text);
            }  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbZamanDilimi.Items.Add("1 Gün");
            cmbZamanDilimi.Items.Add("2 Gün");
            cmbZamanDilimi.Items.Add("3 Gün");
            cmbZamanDilimi.Items.Add("7 Gün");
            cmbZamanDilimi.Items.Add("30 Gün");
            cmbZamanDilimi.Items.Add("90 Gün");
            cmbZamanDilimi.SelectedIndex = 3;
        }

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help hl1 = new Help();
            hl1.Show();
        }

        private void btnDosyaSec_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            txtDosya.Text = openFileDialog1.FileName;

            lblDers.Text = "";
            lblOgrenciSayisi_2.Text = "";
            lblDerseGiren.Text = "";
            lblDerseGirmeyen.Text = "";
            lblToplamEtkilesim.Text = "";
            richTxtGelmeyenOgrenciler.Text = "";
            listKayitlar = new List<KayitNesnesi>();
            listOgrenciler = new List<OgrenciNesnesi>();
            Dosya_Ac_ve_Kayit_Doldur();
            lblOgrenciSayisi_2.Text = Ogrencileri_Bul_ve_Doldur().ToString();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            Ogrencileri_Son_Giris_Doldur();
            Girmeyen_Ogrenci_Listele();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Kopyala_Clipboard();
        }
    }
}
