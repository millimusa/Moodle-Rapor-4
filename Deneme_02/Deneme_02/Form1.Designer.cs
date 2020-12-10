namespace Deneme_02
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblOgrenciSayisi_1 = new System.Windows.Forms.Label();
            this.lblOgrenciSayisi_2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtDosya = new System.Windows.Forms.TextBox();
            this.richTxtOgrenciListesi = new System.Windows.Forms.RichTextBox();
            this.richTxtGelmeyenOgrenciler = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDers = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDerseGiren = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDerseGirmeyen = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblToplamEtkilesim = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGetir = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnDosyaSec = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cmbZamanDilimi = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btnCikis = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCopy = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbZamanDilimi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOgrenciSayisi_1
            // 
            this.lblOgrenciSayisi_1.AutoSize = true;
            this.lblOgrenciSayisi_1.Location = new System.Drawing.Point(12, 361);
            this.lblOgrenciSayisi_1.Name = "lblOgrenciSayisi_1";
            this.lblOgrenciSayisi_1.Size = new System.Drawing.Size(138, 13);
            this.lblOgrenciSayisi_1.TabIndex = 0;
            this.lblOgrenciSayisi_1.Text = "Derse Kayıtlı Öğrenci Sayısı:";
            // 
            // lblOgrenciSayisi_2
            // 
            this.lblOgrenciSayisi_2.AutoSize = true;
            this.lblOgrenciSayisi_2.Location = new System.Drawing.Point(194, 361);
            this.lblOgrenciSayisi_2.Name = "lblOgrenciSayisi_2";
            this.lblOgrenciSayisi_2.Size = new System.Drawing.Size(0, 13);
            this.lblOgrenciSayisi_2.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtDosya
            // 
            this.txtDosya.BackColor = System.Drawing.Color.Beige;
            this.txtDosya.Location = new System.Drawing.Point(12, 38);
            this.txtDosya.Name = "txtDosya";
            this.txtDosya.Size = new System.Drawing.Size(418, 20);
            this.txtDosya.TabIndex = 3;
            // 
            // richTxtOgrenciListesi
            // 
            this.richTxtOgrenciListesi.BackColor = System.Drawing.Color.Beige;
            this.richTxtOgrenciListesi.Location = new System.Drawing.Point(12, 116);
            this.richTxtOgrenciListesi.Name = "richTxtOgrenciListesi";
            this.richTxtOgrenciListesi.Size = new System.Drawing.Size(239, 225);
            this.richTxtOgrenciListesi.TabIndex = 5;
            this.richTxtOgrenciListesi.Text = "";
            // 
            // richTxtGelmeyenOgrenciler
            // 
            this.richTxtGelmeyenOgrenciler.BackColor = System.Drawing.Color.Beige;
            this.richTxtGelmeyenOgrenciler.Location = new System.Drawing.Point(292, 116);
            this.richTxtGelmeyenOgrenciler.Name = "richTxtGelmeyenOgrenciler";
            this.richTxtGelmeyenOgrenciler.Size = new System.Drawing.Size(239, 225);
            this.richTxtGelmeyenOgrenciler.TabIndex = 6;
            this.richTxtGelmeyenOgrenciler.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Zaman Dilimi Seçin";
            // 
            // lblDers
            // 
            this.lblDers.AutoSize = true;
            this.lblDers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDers.ForeColor = System.Drawing.Color.Maroon;
            this.lblDers.Location = new System.Drawing.Point(12, 66);
            this.lblDers.Name = "lblDers";
            this.lblDers.Size = new System.Drawing.Size(37, 16);
            this.lblDers.TabIndex = 9;
            this.lblDers.Text = "Ders";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Derse Giren Öğrenci Sayısı:";
            // 
            // lblDerseGiren
            // 
            this.lblDerseGiren.AutoSize = true;
            this.lblDerseGiren.Location = new System.Drawing.Point(194, 388);
            this.lblDerseGiren.Name = "lblDerseGiren";
            this.lblDerseGiren.Size = new System.Drawing.Size(0, 13);
            this.lblDerseGiren.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Derse Girmeyen Öğrenci Sayısı:";
            // 
            // lblDerseGirmeyen
            // 
            this.lblDerseGirmeyen.AutoSize = true;
            this.lblDerseGirmeyen.Location = new System.Drawing.Point(194, 415);
            this.lblDerseGirmeyen.Name = "lblDerseGirmeyen";
            this.lblDerseGirmeyen.Size = new System.Drawing.Size(0, 13);
            this.lblDerseGirmeyen.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 442);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Dersin Toplam Etkileşimi:";
            // 
            // lblToplamEtkilesim
            // 
            this.lblToplamEtkilesim.AutoSize = true;
            this.lblToplamEtkilesim.Location = new System.Drawing.Point(194, 442);
            this.lblToplamEtkilesim.Name = "lblToplamEtkilesim";
            this.lblToplamEtkilesim.Size = new System.Drawing.Size(0, 13);
            this.lblToplamEtkilesim.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 39);
            this.label3.TabIndex = 16;
            this.label3.Text = "Not: Dosyanın oluşturulma zamanını değil, programın\r\nçalışma zamanını baz alır. D" +
    "olayısı ile dosyayı\r\noluşturduktan sonra raporunuzu alınız.";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(549, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            this.yardımToolStripMenuItem.Click += new System.EventHandler(this.yardımToolStripMenuItem_Click);
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(411, 380);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(120, 25);
            this.btnGetir.TabIndex = 18;
            this.btnGetir.Values.Text = "Getir";
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // btnDosyaSec
            // 
            this.btnDosyaSec.Location = new System.Drawing.Point(436, 35);
            this.btnDosyaSec.Name = "btnDosyaSec";
            this.btnDosyaSec.Size = new System.Drawing.Size(95, 25);
            this.btnDosyaSec.TabIndex = 19;
            this.btnDosyaSec.Values.Text = "Dosya Seç";
            this.btnDosyaSec.Click += new System.EventHandler(this.btnDosyaSec_Click_1);
            // 
            // cmbZamanDilimi
            // 
            this.cmbZamanDilimi.DropDownWidth = 103;
            this.cmbZamanDilimi.Location = new System.Drawing.Point(292, 384);
            this.cmbZamanDilimi.Name = "cmbZamanDilimi";
            this.cmbZamanDilimi.Size = new System.Drawing.Size(103, 21);
            this.cmbZamanDilimi.StateActive.ComboBox.Back.Color1 = System.Drawing.Color.Beige;
            this.cmbZamanDilimi.TabIndex = 20;
            this.cmbZamanDilimi.Text = "1 Gün";
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(411, 350);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(120, 25);
            this.btnCikis.TabIndex = 21;
            this.btnCikis.Values.Text = "Çıkış";
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Derse Kayıtlı Öğrenciler";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(289, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Derse Girmeyen Öğrenciler";
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(436, 86);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.OverrideDefault.Content.LongText.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btnCopy.OverrideDefault.Content.LongText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.btnCopy.OverrideDefault.Content.LongText.TextV = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.btnCopy.Size = new System.Drawing.Size(95, 27);
            this.btnCopy.TabIndex = 24;
            this.btnCopy.Values.Text = "Copy";
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(549, 464);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.cmbZamanDilimi);
            this.Controls.Add(this.btnDosyaSec);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblToplamEtkilesim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblDerseGirmeyen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDerseGiren);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTxtGelmeyenOgrenciler);
            this.Controls.Add(this.richTxtOgrenciListesi);
            this.Controls.Add(this.txtDosya);
            this.Controls.Add(this.lblOgrenciSayisi_2);
            this.Controls.Add(this.lblOgrenciSayisi_1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Moodle Rapor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbZamanDilimi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOgrenciSayisi_1;
        private System.Windows.Forms.Label lblOgrenciSayisi_2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtDosya;
        private System.Windows.Forms.RichTextBox richTxtOgrenciListesi;
        private System.Windows.Forms.RichTextBox richTxtGelmeyenOgrenciler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDerseGiren;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDerseGirmeyen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblToplamEtkilesim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnGetir;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDosyaSec;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cmbZamanDilimi;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCikis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCopy;
    }
}

