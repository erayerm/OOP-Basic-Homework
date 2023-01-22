namespace Odev
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
            this.lbl_giriniz = new System.Windows.Forms.Label();
            this.txt_giriniz = new System.Windows.Forms.TextBox();
            this.lbl_adi = new System.Windows.Forms.Label();
            this.lbl_soyadi = new System.Windows.Forms.Label();
            this.lbl_calismaSureci = new System.Windows.Forms.Label();
            this.lbl_evlilikDurumu = new System.Windows.Forms.Label();
            this.lbl_esiCalisiyorMu = new System.Windows.Forms.Label();
            this.lbl_makamTazminati = new System.Windows.Forms.Label();
            this.lbl_idariGorevTazminati = new System.Windows.Forms.Label();
            this.lbl_fazlaMesaiSaati = new System.Windows.Forms.Label();
            this.lbl_fazlaMesaiUcreti = new System.Windows.Forms.Label();
            this.lbl_vergiMatrahi = new System.Windows.Forms.Label();
            this.lbl_adi2 = new System.Windows.Forms.Label();
            this.lbl_soyadi2 = new System.Windows.Forms.Label();
            this.lbl_calismaSureci2 = new System.Windows.Forms.Label();
            this.lbl_evlilikDurumu2 = new System.Windows.Forms.Label();
            this.lbl_esiCalisiyorMu2 = new System.Windows.Forms.Label();
            this.lbl_cocukSayisi2 = new System.Windows.Forms.Label();
            this.lbl_tabanMaas2 = new System.Windows.Forms.Label();
            this.lbl_makamTazminati2 = new System.Windows.Forms.Label();
            this.lbl_idariGorevTazminati2 = new System.Windows.Forms.Label();
            this.lbl_fazlaMesaiSaati2 = new System.Windows.Forms.Label();
            this.lbl_fazlaMesaiUcreti2 = new System.Windows.Forms.Label();
            this.lbl_vergiMatrahi2 = new System.Windows.Forms.Label();
            this.lbl_tabanMaas = new System.Windows.Forms.Label();
            this.lbl_cocukSayisi = new System.Windows.Forms.Label();
            this.but_hesapla = new System.Windows.Forms.Button();
            this.lbl_yasi = new System.Windows.Forms.Label();
            this.lbl_yasi2 = new System.Windows.Forms.Label();
            this.pic_resim = new System.Windows.Forms.PictureBox();
            this.lbl_brut = new System.Windows.Forms.Label();
            this.lbl_brut2 = new System.Windows.Forms.Label();
            this.lbl_damga2 = new System.Windows.Forms.Label();
            this.lbl_damga = new System.Windows.Forms.Label();
            this.lbl_gelir2 = new System.Windows.Forms.Label();
            this.lbl_gelir = new System.Windows.Forms.Label();
            this.lbl_emekli2 = new System.Windows.Forms.Label();
            this.lbl_emekli = new System.Windows.Forms.Label();
            this.lbl_net2 = new System.Windows.Forms.Label();
            this.lbl_net = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_resim)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_giriniz
            // 
            this.lbl_giriniz.AutoSize = true;
            this.lbl_giriniz.Location = new System.Drawing.Point(2, 9);
            this.lbl_giriniz.Name = "lbl_giriniz";
            this.lbl_giriniz.Size = new System.Drawing.Size(390, 13);
            this.lbl_giriniz.TabIndex = 0;
            this.lbl_giriniz.Text = "Personel Bilgilerini Görüntülemek İstediğiniz Çalışanın TC Kimlik Numarasını Giri" +
    "niz:";
            // 
            // txt_giriniz
            // 
            this.txt_giriniz.Location = new System.Drawing.Point(391, 6);
            this.txt_giriniz.Name = "txt_giriniz";
            this.txt_giriniz.Size = new System.Drawing.Size(100, 20);
            this.txt_giriniz.TabIndex = 1;
            this.txt_giriniz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_giriniz_KeyPress);
            // 
            // lbl_adi
            // 
            this.lbl_adi.AutoSize = true;
            this.lbl_adi.Location = new System.Drawing.Point(29, 47);
            this.lbl_adi.Name = "lbl_adi";
            this.lbl_adi.Size = new System.Drawing.Size(22, 13);
            this.lbl_adi.TabIndex = 2;
            this.lbl_adi.Text = "Adı";
            this.lbl_adi.Visible = false;
            // 
            // lbl_soyadi
            // 
            this.lbl_soyadi.AutoSize = true;
            this.lbl_soyadi.Location = new System.Drawing.Point(29, 60);
            this.lbl_soyadi.Name = "lbl_soyadi";
            this.lbl_soyadi.Size = new System.Drawing.Size(39, 13);
            this.lbl_soyadi.TabIndex = 3;
            this.lbl_soyadi.Text = "Soyadı";
            this.lbl_soyadi.Visible = false;
            // 
            // lbl_calismaSureci
            // 
            this.lbl_calismaSureci.AutoSize = true;
            this.lbl_calismaSureci.Location = new System.Drawing.Point(29, 86);
            this.lbl_calismaSureci.Name = "lbl_calismaSureci";
            this.lbl_calismaSureci.Size = new System.Drawing.Size(76, 13);
            this.lbl_calismaSureci.TabIndex = 4;
            this.lbl_calismaSureci.Text = "Çalışma Süreci";
            this.lbl_calismaSureci.Visible = false;
            // 
            // lbl_evlilikDurumu
            // 
            this.lbl_evlilikDurumu.AutoSize = true;
            this.lbl_evlilikDurumu.Location = new System.Drawing.Point(29, 99);
            this.lbl_evlilikDurumu.Name = "lbl_evlilikDurumu";
            this.lbl_evlilikDurumu.Size = new System.Drawing.Size(74, 13);
            this.lbl_evlilikDurumu.TabIndex = 5;
            this.lbl_evlilikDurumu.Text = "Evlilik Durumu";
            this.lbl_evlilikDurumu.Visible = false;
            // 
            // lbl_esiCalisiyorMu
            // 
            this.lbl_esiCalisiyorMu.AutoSize = true;
            this.lbl_esiCalisiyorMu.Location = new System.Drawing.Point(29, 112);
            this.lbl_esiCalisiyorMu.Name = "lbl_esiCalisiyorMu";
            this.lbl_esiCalisiyorMu.Size = new System.Drawing.Size(84, 13);
            this.lbl_esiCalisiyorMu.TabIndex = 6;
            this.lbl_esiCalisiyorMu.Text = "Eşi çalışıyor mu?";
            this.lbl_esiCalisiyorMu.Visible = false;
            // 
            // lbl_makamTazminati
            // 
            this.lbl_makamTazminati.AutoSize = true;
            this.lbl_makamTazminati.Location = new System.Drawing.Point(29, 151);
            this.lbl_makamTazminati.Name = "lbl_makamTazminati";
            this.lbl_makamTazminati.Size = new System.Drawing.Size(90, 13);
            this.lbl_makamTazminati.TabIndex = 9;
            this.lbl_makamTazminati.Text = "Makam Tazminatı";
            this.lbl_makamTazminati.Visible = false;
            // 
            // lbl_idariGorevTazminati
            // 
            this.lbl_idariGorevTazminati.AutoSize = true;
            this.lbl_idariGorevTazminati.Location = new System.Drawing.Point(29, 164);
            this.lbl_idariGorevTazminati.Name = "lbl_idariGorevTazminati";
            this.lbl_idariGorevTazminati.Size = new System.Drawing.Size(107, 13);
            this.lbl_idariGorevTazminati.TabIndex = 10;
            this.lbl_idariGorevTazminati.Text = "İdari Görev Tazminatı";
            this.lbl_idariGorevTazminati.Visible = false;
            // 
            // lbl_fazlaMesaiSaati
            // 
            this.lbl_fazlaMesaiSaati.AutoSize = true;
            this.lbl_fazlaMesaiSaati.Location = new System.Drawing.Point(29, 177);
            this.lbl_fazlaMesaiSaati.Name = "lbl_fazlaMesaiSaati";
            this.lbl_fazlaMesaiSaati.Size = new System.Drawing.Size(90, 13);
            this.lbl_fazlaMesaiSaati.TabIndex = 11;
            this.lbl_fazlaMesaiSaati.Text = "Fazla Mesai Saati";
            this.lbl_fazlaMesaiSaati.Visible = false;
            // 
            // lbl_fazlaMesaiUcreti
            // 
            this.lbl_fazlaMesaiUcreti.AutoSize = true;
            this.lbl_fazlaMesaiUcreti.Location = new System.Drawing.Point(29, 190);
            this.lbl_fazlaMesaiUcreti.Name = "lbl_fazlaMesaiUcreti";
            this.lbl_fazlaMesaiUcreti.Size = new System.Drawing.Size(94, 13);
            this.lbl_fazlaMesaiUcreti.TabIndex = 12;
            this.lbl_fazlaMesaiUcreti.Text = "Fazla Mesai Ücreti";
            this.lbl_fazlaMesaiUcreti.Visible = false;
            // 
            // lbl_vergiMatrahi
            // 
            this.lbl_vergiMatrahi.AutoSize = true;
            this.lbl_vergiMatrahi.Location = new System.Drawing.Point(29, 203);
            this.lbl_vergiMatrahi.Name = "lbl_vergiMatrahi";
            this.lbl_vergiMatrahi.Size = new System.Drawing.Size(69, 13);
            this.lbl_vergiMatrahi.TabIndex = 13;
            this.lbl_vergiMatrahi.Text = "Vergi Matrahı";
            this.lbl_vergiMatrahi.Visible = false;
            // 
            // lbl_adi2
            // 
            this.lbl_adi2.AutoSize = true;
            this.lbl_adi2.Location = new System.Drawing.Point(152, 47);
            this.lbl_adi2.Name = "lbl_adi2";
            this.lbl_adi2.Size = new System.Drawing.Size(0, 13);
            this.lbl_adi2.TabIndex = 14;
            this.lbl_adi2.Visible = false;
            // 
            // lbl_soyadi2
            // 
            this.lbl_soyadi2.AutoSize = true;
            this.lbl_soyadi2.Location = new System.Drawing.Point(152, 60);
            this.lbl_soyadi2.Name = "lbl_soyadi2";
            this.lbl_soyadi2.Size = new System.Drawing.Size(0, 13);
            this.lbl_soyadi2.TabIndex = 15;
            this.lbl_soyadi2.Visible = false;
            // 
            // lbl_calismaSureci2
            // 
            this.lbl_calismaSureci2.AutoSize = true;
            this.lbl_calismaSureci2.Location = new System.Drawing.Point(152, 86);
            this.lbl_calismaSureci2.Name = "lbl_calismaSureci2";
            this.lbl_calismaSureci2.Size = new System.Drawing.Size(10, 13);
            this.lbl_calismaSureci2.TabIndex = 16;
            this.lbl_calismaSureci2.Text = " ";
            this.lbl_calismaSureci2.Visible = false;
            // 
            // lbl_evlilikDurumu2
            // 
            this.lbl_evlilikDurumu2.AutoSize = true;
            this.lbl_evlilikDurumu2.Location = new System.Drawing.Point(152, 99);
            this.lbl_evlilikDurumu2.Name = "lbl_evlilikDurumu2";
            this.lbl_evlilikDurumu2.Size = new System.Drawing.Size(10, 13);
            this.lbl_evlilikDurumu2.TabIndex = 17;
            this.lbl_evlilikDurumu2.Text = " ";
            this.lbl_evlilikDurumu2.Visible = false;
            // 
            // lbl_esiCalisiyorMu2
            // 
            this.lbl_esiCalisiyorMu2.AutoSize = true;
            this.lbl_esiCalisiyorMu2.Location = new System.Drawing.Point(152, 112);
            this.lbl_esiCalisiyorMu2.Name = "lbl_esiCalisiyorMu2";
            this.lbl_esiCalisiyorMu2.Size = new System.Drawing.Size(10, 13);
            this.lbl_esiCalisiyorMu2.TabIndex = 18;
            this.lbl_esiCalisiyorMu2.Text = " ";
            this.lbl_esiCalisiyorMu2.Visible = false;
            // 
            // lbl_cocukSayisi2
            // 
            this.lbl_cocukSayisi2.AutoSize = true;
            this.lbl_cocukSayisi2.Location = new System.Drawing.Point(152, 125);
            this.lbl_cocukSayisi2.Name = "lbl_cocukSayisi2";
            this.lbl_cocukSayisi2.Size = new System.Drawing.Size(10, 13);
            this.lbl_cocukSayisi2.TabIndex = 19;
            this.lbl_cocukSayisi2.Text = " ";
            this.lbl_cocukSayisi2.Visible = false;
            // 
            // lbl_tabanMaas2
            // 
            this.lbl_tabanMaas2.AutoSize = true;
            this.lbl_tabanMaas2.Location = new System.Drawing.Point(152, 138);
            this.lbl_tabanMaas2.Name = "lbl_tabanMaas2";
            this.lbl_tabanMaas2.Size = new System.Drawing.Size(10, 13);
            this.lbl_tabanMaas2.TabIndex = 20;
            this.lbl_tabanMaas2.Text = " ";
            this.lbl_tabanMaas2.Visible = false;
            // 
            // lbl_makamTazminati2
            // 
            this.lbl_makamTazminati2.AutoSize = true;
            this.lbl_makamTazminati2.Location = new System.Drawing.Point(152, 151);
            this.lbl_makamTazminati2.Name = "lbl_makamTazminati2";
            this.lbl_makamTazminati2.Size = new System.Drawing.Size(10, 13);
            this.lbl_makamTazminati2.TabIndex = 21;
            this.lbl_makamTazminati2.Text = " ";
            this.lbl_makamTazminati2.Visible = false;
            // 
            // lbl_idariGorevTazminati2
            // 
            this.lbl_idariGorevTazminati2.AutoSize = true;
            this.lbl_idariGorevTazminati2.Location = new System.Drawing.Point(152, 164);
            this.lbl_idariGorevTazminati2.Name = "lbl_idariGorevTazminati2";
            this.lbl_idariGorevTazminati2.Size = new System.Drawing.Size(10, 13);
            this.lbl_idariGorevTazminati2.TabIndex = 22;
            this.lbl_idariGorevTazminati2.Text = " ";
            this.lbl_idariGorevTazminati2.Visible = false;
            // 
            // lbl_fazlaMesaiSaati2
            // 
            this.lbl_fazlaMesaiSaati2.AutoSize = true;
            this.lbl_fazlaMesaiSaati2.Location = new System.Drawing.Point(152, 177);
            this.lbl_fazlaMesaiSaati2.Name = "lbl_fazlaMesaiSaati2";
            this.lbl_fazlaMesaiSaati2.Size = new System.Drawing.Size(10, 13);
            this.lbl_fazlaMesaiSaati2.TabIndex = 23;
            this.lbl_fazlaMesaiSaati2.Text = " ";
            this.lbl_fazlaMesaiSaati2.Visible = false;
            // 
            // lbl_fazlaMesaiUcreti2
            // 
            this.lbl_fazlaMesaiUcreti2.AutoSize = true;
            this.lbl_fazlaMesaiUcreti2.Location = new System.Drawing.Point(152, 190);
            this.lbl_fazlaMesaiUcreti2.Name = "lbl_fazlaMesaiUcreti2";
            this.lbl_fazlaMesaiUcreti2.Size = new System.Drawing.Size(10, 13);
            this.lbl_fazlaMesaiUcreti2.TabIndex = 24;
            this.lbl_fazlaMesaiUcreti2.Text = " ";
            this.lbl_fazlaMesaiUcreti2.Visible = false;
            // 
            // lbl_vergiMatrahi2
            // 
            this.lbl_vergiMatrahi2.AutoSize = true;
            this.lbl_vergiMatrahi2.Location = new System.Drawing.Point(152, 203);
            this.lbl_vergiMatrahi2.Name = "lbl_vergiMatrahi2";
            this.lbl_vergiMatrahi2.Size = new System.Drawing.Size(10, 13);
            this.lbl_vergiMatrahi2.TabIndex = 25;
            this.lbl_vergiMatrahi2.Text = " ";
            this.lbl_vergiMatrahi2.Visible = false;
            // 
            // lbl_tabanMaas
            // 
            this.lbl_tabanMaas.AutoSize = true;
            this.lbl_tabanMaas.Location = new System.Drawing.Point(29, 138);
            this.lbl_tabanMaas.Name = "lbl_tabanMaas";
            this.lbl_tabanMaas.Size = new System.Drawing.Size(67, 13);
            this.lbl_tabanMaas.TabIndex = 26;
            this.lbl_tabanMaas.Text = "Taban Maaş";
            this.lbl_tabanMaas.Visible = false;
            // 
            // lbl_cocukSayisi
            // 
            this.lbl_cocukSayisi.AutoSize = true;
            this.lbl_cocukSayisi.Location = new System.Drawing.Point(29, 125);
            this.lbl_cocukSayisi.Name = "lbl_cocukSayisi";
            this.lbl_cocukSayisi.Size = new System.Drawing.Size(68, 13);
            this.lbl_cocukSayisi.TabIndex = 27;
            this.lbl_cocukSayisi.Text = "Çocuk Sayısı";
            this.lbl_cocukSayisi.Visible = false;
            // 
            // but_hesapla
            // 
            this.but_hesapla.Location = new System.Drawing.Point(532, 4);
            this.but_hesapla.Name = "but_hesapla";
            this.but_hesapla.Size = new System.Drawing.Size(75, 23);
            this.but_hesapla.TabIndex = 28;
            this.but_hesapla.Text = "Görüntüle";
            this.but_hesapla.UseVisualStyleBackColor = true;
            this.but_hesapla.Click += new System.EventHandler(this.but_hesapla_Click);
            // 
            // lbl_yasi
            // 
            this.lbl_yasi.AutoSize = true;
            this.lbl_yasi.Location = new System.Drawing.Point(29, 73);
            this.lbl_yasi.Name = "lbl_yasi";
            this.lbl_yasi.Size = new System.Drawing.Size(27, 13);
            this.lbl_yasi.TabIndex = 29;
            this.lbl_yasi.Text = "Yaşı";
            this.lbl_yasi.Visible = false;
            // 
            // lbl_yasi2
            // 
            this.lbl_yasi2.AutoSize = true;
            this.lbl_yasi2.Location = new System.Drawing.Point(152, 73);
            this.lbl_yasi2.Name = "lbl_yasi2";
            this.lbl_yasi2.Size = new System.Drawing.Size(0, 13);
            this.lbl_yasi2.TabIndex = 30;
            this.lbl_yasi2.Visible = false;
            // 
            // pic_resim
            // 
            this.pic_resim.Location = new System.Drawing.Point(311, 138);
            this.pic_resim.Name = "pic_resim";
            this.pic_resim.Size = new System.Drawing.Size(220, 220);
            this.pic_resim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_resim.TabIndex = 31;
            this.pic_resim.TabStop = false;
            // 
            // lbl_brut
            // 
            this.lbl_brut.AutoSize = true;
            this.lbl_brut.Location = new System.Drawing.Point(299, 60);
            this.lbl_brut.Name = "lbl_brut";
            this.lbl_brut.Size = new System.Drawing.Size(55, 13);
            this.lbl_brut.TabIndex = 32;
            this.lbl_brut.Text = "Brüt Maaş";
            this.lbl_brut.Visible = false;
            // 
            // lbl_brut2
            // 
            this.lbl_brut2.AutoSize = true;
            this.lbl_brut2.Location = new System.Drawing.Point(424, 60);
            this.lbl_brut2.Name = "lbl_brut2";
            this.lbl_brut2.Size = new System.Drawing.Size(10, 13);
            this.lbl_brut2.TabIndex = 33;
            this.lbl_brut2.Text = " ";
            this.lbl_brut2.Visible = false;
            // 
            // lbl_damga2
            // 
            this.lbl_damga2.AutoSize = true;
            this.lbl_damga2.Location = new System.Drawing.Point(424, 73);
            this.lbl_damga2.Name = "lbl_damga2";
            this.lbl_damga2.Size = new System.Drawing.Size(10, 13);
            this.lbl_damga2.TabIndex = 35;
            this.lbl_damga2.Text = " ";
            this.lbl_damga2.Visible = false;
            // 
            // lbl_damga
            // 
            this.lbl_damga.AutoSize = true;
            this.lbl_damga.Location = new System.Drawing.Point(299, 73);
            this.lbl_damga.Name = "lbl_damga";
            this.lbl_damga.Size = new System.Drawing.Size(75, 13);
            this.lbl_damga.TabIndex = 34;
            this.lbl_damga.Text = "Damga Vergisi";
            this.lbl_damga.Visible = false;
            // 
            // lbl_gelir2
            // 
            this.lbl_gelir2.AutoSize = true;
            this.lbl_gelir2.Location = new System.Drawing.Point(424, 86);
            this.lbl_gelir2.Name = "lbl_gelir2";
            this.lbl_gelir2.Size = new System.Drawing.Size(10, 13);
            this.lbl_gelir2.TabIndex = 37;
            this.lbl_gelir2.Text = " ";
            this.lbl_gelir2.Visible = false;
            // 
            // lbl_gelir
            // 
            this.lbl_gelir.AutoSize = true;
            this.lbl_gelir.Location = new System.Drawing.Point(299, 86);
            this.lbl_gelir.Name = "lbl_gelir";
            this.lbl_gelir.Size = new System.Drawing.Size(62, 13);
            this.lbl_gelir.TabIndex = 36;
            this.lbl_gelir.Text = "Gelir Vergisi";
            this.lbl_gelir.Visible = false;
            // 
            // lbl_emekli2
            // 
            this.lbl_emekli2.AutoSize = true;
            this.lbl_emekli2.Location = new System.Drawing.Point(424, 99);
            this.lbl_emekli2.Name = "lbl_emekli2";
            this.lbl_emekli2.Size = new System.Drawing.Size(10, 13);
            this.lbl_emekli2.TabIndex = 39;
            this.lbl_emekli2.Text = " ";
            this.lbl_emekli2.Visible = false;
            // 
            // lbl_emekli
            // 
            this.lbl_emekli.AutoSize = true;
            this.lbl_emekli.Location = new System.Drawing.Point(299, 99);
            this.lbl_emekli.Name = "lbl_emekli";
            this.lbl_emekli.Size = new System.Drawing.Size(79, 13);
            this.lbl_emekli.TabIndex = 38;
            this.lbl_emekli.Text = "Emekli Kesintisi";
            this.lbl_emekli.Visible = false;
            // 
            // lbl_net2
            // 
            this.lbl_net2.AutoSize = true;
            this.lbl_net2.Location = new System.Drawing.Point(424, 112);
            this.lbl_net2.Name = "lbl_net2";
            this.lbl_net2.Size = new System.Drawing.Size(10, 13);
            this.lbl_net2.TabIndex = 41;
            this.lbl_net2.Text = " ";
            this.lbl_net2.Visible = false;
            // 
            // lbl_net
            // 
            this.lbl_net.AutoSize = true;
            this.lbl_net.Location = new System.Drawing.Point(299, 112);
            this.lbl_net.Name = "lbl_net";
            this.lbl_net.Size = new System.Drawing.Size(53, 13);
            this.lbl_net.TabIndex = 40;
            this.lbl_net.Text = "Net Maaş";
            this.lbl_net.Visible = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.but_hesapla;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(617, 366);
            this.Controls.Add(this.lbl_net2);
            this.Controls.Add(this.lbl_net);
            this.Controls.Add(this.lbl_emekli2);
            this.Controls.Add(this.lbl_emekli);
            this.Controls.Add(this.lbl_gelir2);
            this.Controls.Add(this.lbl_gelir);
            this.Controls.Add(this.lbl_damga2);
            this.Controls.Add(this.lbl_damga);
            this.Controls.Add(this.lbl_brut2);
            this.Controls.Add(this.lbl_brut);
            this.Controls.Add(this.pic_resim);
            this.Controls.Add(this.lbl_yasi2);
            this.Controls.Add(this.lbl_yasi);
            this.Controls.Add(this.but_hesapla);
            this.Controls.Add(this.lbl_cocukSayisi);
            this.Controls.Add(this.lbl_tabanMaas);
            this.Controls.Add(this.lbl_vergiMatrahi2);
            this.Controls.Add(this.lbl_fazlaMesaiUcreti2);
            this.Controls.Add(this.lbl_fazlaMesaiSaati2);
            this.Controls.Add(this.lbl_idariGorevTazminati2);
            this.Controls.Add(this.lbl_makamTazminati2);
            this.Controls.Add(this.lbl_tabanMaas2);
            this.Controls.Add(this.lbl_cocukSayisi2);
            this.Controls.Add(this.lbl_esiCalisiyorMu2);
            this.Controls.Add(this.lbl_evlilikDurumu2);
            this.Controls.Add(this.lbl_calismaSureci2);
            this.Controls.Add(this.lbl_soyadi2);
            this.Controls.Add(this.lbl_adi2);
            this.Controls.Add(this.lbl_vergiMatrahi);
            this.Controls.Add(this.lbl_fazlaMesaiUcreti);
            this.Controls.Add(this.lbl_fazlaMesaiSaati);
            this.Controls.Add(this.lbl_idariGorevTazminati);
            this.Controls.Add(this.lbl_makamTazminati);
            this.Controls.Add(this.lbl_esiCalisiyorMu);
            this.Controls.Add(this.lbl_evlilikDurumu);
            this.Controls.Add(this.lbl_calismaSureci);
            this.Controls.Add(this.lbl_soyadi);
            this.Controls.Add(this.lbl_adi);
            this.Controls.Add(this.txt_giriniz);
            this.Controls.Add(this.lbl_giriniz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Personal Bilgileri Görüntüleme";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_resim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_giriniz;
        private System.Windows.Forms.TextBox txt_giriniz;
        private System.Windows.Forms.Label lbl_adi;
        private System.Windows.Forms.Label lbl_soyadi;
        private System.Windows.Forms.Label lbl_calismaSureci;
        private System.Windows.Forms.Label lbl_evlilikDurumu;
        private System.Windows.Forms.Label lbl_esiCalisiyorMu;
        private System.Windows.Forms.Label lbl_makamTazminati;
        private System.Windows.Forms.Label lbl_idariGorevTazminati;
        private System.Windows.Forms.Label lbl_fazlaMesaiSaati;
        private System.Windows.Forms.Label lbl_fazlaMesaiUcreti;
        private System.Windows.Forms.Label lbl_vergiMatrahi;
        private System.Windows.Forms.Label lbl_adi2;
        private System.Windows.Forms.Label lbl_soyadi2;
        private System.Windows.Forms.Label lbl_calismaSureci2;
        private System.Windows.Forms.Label lbl_evlilikDurumu2;
        private System.Windows.Forms.Label lbl_esiCalisiyorMu2;
        private System.Windows.Forms.Label lbl_cocukSayisi2;
        private System.Windows.Forms.Label lbl_tabanMaas2;
        private System.Windows.Forms.Label lbl_makamTazminati2;
        private System.Windows.Forms.Label lbl_idariGorevTazminati2;
        private System.Windows.Forms.Label lbl_fazlaMesaiSaati2;
        private System.Windows.Forms.Label lbl_fazlaMesaiUcreti2;
        private System.Windows.Forms.Label lbl_vergiMatrahi2;
        private System.Windows.Forms.Label lbl_tabanMaas;
        private System.Windows.Forms.Label lbl_cocukSayisi;
        private System.Windows.Forms.Button but_hesapla;
        private System.Windows.Forms.Label lbl_yasi;
        private System.Windows.Forms.Label lbl_yasi2;
        private System.Windows.Forms.PictureBox pic_resim;
        private System.Windows.Forms.Label lbl_brut;
        private System.Windows.Forms.Label lbl_brut2;
        private System.Windows.Forms.Label lbl_damga2;
        private System.Windows.Forms.Label lbl_damga;
        private System.Windows.Forms.Label lbl_gelir2;
        private System.Windows.Forms.Label lbl_gelir;
        private System.Windows.Forms.Label lbl_emekli2;
        private System.Windows.Forms.Label lbl_emekli;
        private System.Windows.Forms.Label lbl_net2;
        private System.Windows.Forms.Label lbl_net;
    }
}

