/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2018-2019 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 1
**				ÖĞRENCİ ADI............: Eray Ermemiş
**				ÖĞRENCİ NUMARASI.......: g181210050
**              DERSİN ALINDIĞI GRUP...: 2C
****************************************************************************/


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

namespace Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // not defterindeki metni kelimelerine ayırdığımda içinde tutacağım dizi.
        public string[] kelimeler;
        
        private RichTextBox richTextBox1 = new RichTextBox();
        private void Form1_Load(object sender, EventArgs e)
        {
            //textbox karakter sınırını en fazla 11 olacak şekilde ayarlar.
            txt_giriniz.MaxLength = 11;

            TextReader reader = new StreamReader(@"C:\a.txt");
            richTextBox1.Text = reader.ReadToEnd();
            reader.Close();
            string hepsi = richTextBox1.Text;

            //.Split ile not defterindeki metini kelimelerine ayırdım.
            kelimeler = hepsi.Split(' ','\n');
            Console.WriteLine(hepsi);
        }
        private void but_hesapla_Click(object sender, EventArgs e)
        {
            double brutMaas=0;
            double damgaVergisi = 0;
            double gelirVergisi = 0;
            double emekliKesintisi = 0;
            double netMaas = 0;
            //girilen kimliği not defteri içinde bulmayı sağlar
            for (int i = 0; i < kelimeler.Length; i=i+16)
            {
                // eğer textbox'a birşey girilmediyse bir önceki işlemden kalma bilgileri görünmez yapıp ekrana bir messagebox çıkarır ve döngüyü kırar.
                if (String.IsNullOrEmpty(txt_giriniz.Text)) {
                    lbl_damga2.Visible = false;
                    lbl_damga.Visible = false;

                    lbl_gelir2.Visible = false;
                    lbl_gelir.Visible = false;

                    lbl_brut2.Visible = false;
                    lbl_brut.Visible = false;

                    lbl_emekli2.Visible = false;
                    lbl_emekli.Visible = false;

                    lbl_net2.Visible = false;
                    lbl_net.Visible = false;

                    lbl_adi2.Visible = false;
                    lbl_adi.Visible = false;

                    lbl_soyadi2.Visible = false;
                    lbl_soyadi.Visible = false;

                    lbl_yasi2.Visible = false;
                    lbl_yasi.Visible = false;

                    lbl_calismaSureci2.Visible = false;
                    lbl_calismaSureci.Visible = false;

                    lbl_evlilikDurumu2.Visible = false;
                    lbl_evlilikDurumu.Visible = false;

                    lbl_esiCalisiyorMu2.Visible = false;
                    lbl_esiCalisiyorMu.Visible = false;

                    lbl_cocukSayisi2.Visible = false;
                    lbl_cocukSayisi.Visible = false;

                    lbl_tabanMaas2.Visible = false;
                    lbl_tabanMaas.Visible = false;

                    lbl_makamTazminati2.Visible = false;
                    lbl_makamTazminati.Visible = false;

                    lbl_idariGorevTazminati.Visible = false;
                    lbl_idariGorevTazminati2.Visible = false;

                    lbl_fazlaMesaiSaati2.Visible = false;
                    lbl_fazlaMesaiSaati.Visible = false;

                    lbl_fazlaMesaiUcreti2.Visible = false;
                    lbl_fazlaMesaiUcreti.Visible = false;

                    lbl_vergiMatrahi2.Visible = false;
                    lbl_vergiMatrahi.Visible = false;

                    pic_resim.Visible = false;
                    this.pic_resim.BorderStyle = BorderStyle.None;
                    MessageBox.Show("Alanı Boş Bırakmayınız");
                    break;
                }
                //eşleşen tc'yi bulursa değişkenlere gerekli değerleri atar ve form elemanlarını görünür yapar.
                if (kelimeler[i] == txt_giriniz.Text)
                {
                    lbl_adi2.Text = kelimeler[i+1];
                    lbl_soyadi2.Text = kelimeler[i + 2];
                    lbl_yasi2.Text = kelimeler[i + 3];
                    lbl_calismaSureci2.Text = kelimeler[i + 4];
                    lbl_evlilikDurumu2.Text = kelimeler[i + 5];
                    lbl_esiCalisiyorMu2.Text = kelimeler[i + 6];
                    lbl_cocukSayisi2.Text = kelimeler[i + 7];
                    lbl_tabanMaas2.Text = kelimeler[i + 8];
                    lbl_makamTazminati2.Text = kelimeler[i + 9];
                    lbl_idariGorevTazminati2.Text = kelimeler[i + 10];
                    lbl_fazlaMesaiSaati2.Text = kelimeler[i + 11];
                    lbl_fazlaMesaiUcreti2.Text = kelimeler[i + 12];
                    lbl_vergiMatrahi2.Text = kelimeler[i + 13];
                    pic_resim.ImageLocation = kelimeler[i+14];
                    
                    lbl_adi2.Visible = true;
                    lbl_adi.Visible = true;
                    lbl_soyadi2.Visible = true;
                    lbl_soyadi.Visible = true;
                    lbl_yasi2.Visible = true;
                    lbl_yasi.Visible = true;
                    lbl_calismaSureci2.Visible = true;
                    lbl_calismaSureci.Visible = true;
                    lbl_evlilikDurumu2.Visible = true;
                    lbl_evlilikDurumu.Visible = true;
                    lbl_esiCalisiyorMu2.Visible = true;
                    lbl_esiCalisiyorMu.Visible = true;
                    lbl_cocukSayisi2.Visible = true;
                    lbl_cocukSayisi.Visible = true;
                    lbl_tabanMaas2.Visible = true;
                    lbl_tabanMaas.Visible = true;
                    lbl_makamTazminati2.Visible = true;
                    lbl_makamTazminati.Visible = true;
                    lbl_idariGorevTazminati.Visible = true;
                    lbl_idariGorevTazminati2.Visible = true;
                    lbl_fazlaMesaiSaati2.Visible = true;
                    lbl_fazlaMesaiSaati.Visible = true;
                    lbl_fazlaMesaiUcreti2.Visible = true;
                    lbl_fazlaMesaiUcreti.Visible = true;
                    lbl_vergiMatrahi2.Visible = true;
                    lbl_vergiMatrahi.Visible = true;
                    pic_resim.Visible = true;
                    this.pic_resim.BorderStyle = BorderStyle.Fixed3D;

                    //verilen koşulları (bekar ise, evli ama eşi çalışmıyor ise, evli ve eşi çalışıyor ise) denetler. Bulduğu sonuca göre gerekli atamaları yapar.
                    if (kelimeler[i + 5] == "B")
                    {
                        brutMaas = Convert.ToDouble(kelimeler[i + 8]) + Convert.ToDouble(kelimeler[i + 9]) +
                            Convert.ToDouble(kelimeler[i + 10]) + (Convert.ToDouble(kelimeler[1 + 7]) * 30) +
                            (Convert.ToDouble(kelimeler[i + 11]) * Convert.ToDouble(kelimeler[i + 12]));
                    }
                    if (kelimeler[i + 5] == "E")
                    {
                        if (kelimeler[i + 6] == "E")
                        {
                            brutMaas = Convert.ToDouble(kelimeler[i + 8]) + Convert.ToDouble(kelimeler[i + 9]) +
                                Convert.ToDouble(kelimeler[i + 10]) + (Convert.ToDouble(kelimeler[1 + 7]) * 30) +
                                (Convert.ToDouble(kelimeler[i + 11]) * Convert.ToDouble(kelimeler[i + 12]));
                        }
                        if (kelimeler[i + 6] == "H")
                        {
                            brutMaas = Convert.ToDouble(kelimeler[i + 8]) + Convert.ToDouble(kelimeler[i + 9]) +
                                Convert.ToDouble(kelimeler[i + 10]) + 200 + (Convert.ToDouble(kelimeler[1 + 7]) * 30) +
                                (Convert.ToDouble(kelimeler[i + 11]) * Convert.ToDouble(kelimeler[i + 12]));
                        }
                    }
                    //gelir vergisini verilen koşullara (maaş aralığı: 1000- , 1000<x<2000,2000<x<3000,3000+) göre gelir vergisini hesaplar.
                    if (Convert.ToDouble(kelimeler[i + 13]) < 1000)
                    {
                        gelirVergisi = brutMaas * 15 / 100;
                    }
                    if (Convert.ToDouble(kelimeler[i + 13]) > 1000 && Convert.ToDouble(kelimeler[i + 13]) > 2000)
                    {
                        gelirVergisi = brutMaas * 20 / 100;
                    }
                    if (Convert.ToDouble(kelimeler[i + 13]) > 2000 && Convert.ToDouble(kelimeler[i + 13]) > 3000)
                    {
                        gelirVergisi = brutMaas * 25 / 100;
                    }
                    if (Convert.ToDouble(kelimeler[i + 13]) > 3000)
                    {
                        gelirVergisi = brutMaas * 30 / 100;
                    }

                    //damga verigisini hesaplar
                    damgaVergisi = brutMaas * 10 / 100;
                    //emekli kesintisini hesaplar
                    emekliKesintisi = brutMaas * 15 / 100;
                    //net maaşı hesaplar
                    netMaas = brutMaas - (emekliKesintisi + gelirVergisi + damgaVergisi);
                   

                    //gerekli dönüşümler yapılıp gerekli form elemanları görünür hale getirilir.
                    lbl_damga2.Text = Convert.ToString(damgaVergisi);
                    lbl_damga2.Visible = true;
                    lbl_damga.Visible = true;

                    lbl_gelir2.Text = Convert.ToString(gelirVergisi);
                    lbl_gelir2.Visible = true;
                    lbl_gelir.Visible = true;

                    lbl_brut2.Text = Convert.ToString(brutMaas);
                    lbl_brut2.Visible = true;
                    lbl_brut.Visible = true;

                    lbl_emekli2.Text = Convert.ToString(brutMaas);
                    lbl_emekli2.Visible = true;
                    lbl_emekli.Visible = true;

                    lbl_net2.Text = Convert.ToString(netMaas);
                    lbl_net2.Visible = true;
                    lbl_net.Visible = true;

                    break;
                }
                //eğer not defterinde tc yi bulamazsa önceden kalma form elemanlarını görünmez yapar ve ekrana messageBox çıkarır ve döngüyü kırar.
                if (i == kelimeler.Length-16)
                {
                    lbl_damga2.Visible = false;
                    lbl_damga.Visible = false;

                    lbl_gelir2.Visible = false;
                    lbl_gelir.Visible = false;

                    lbl_brut2.Visible = false;
                    lbl_brut.Visible = false;

                    lbl_emekli2.Visible = false;
                    lbl_emekli.Visible = false;

                    lbl_net2.Visible = false;
                    lbl_net.Visible = false;

                    lbl_adi2.Visible = false;
                    lbl_adi.Visible = false;

                    lbl_soyadi2.Visible = false;
                    lbl_soyadi.Visible = false;

                    lbl_yasi2.Visible = false;
                    lbl_yasi.Visible = false;

                    lbl_calismaSureci2.Visible = false;
                    lbl_calismaSureci.Visible = false;

                    lbl_evlilikDurumu2.Visible = false;
                    lbl_evlilikDurumu.Visible = false;

                    lbl_esiCalisiyorMu2.Visible = false;
                    lbl_esiCalisiyorMu.Visible = false;

                    lbl_cocukSayisi2.Visible = false;
                    lbl_cocukSayisi.Visible = false;

                    lbl_tabanMaas2.Visible = false;
                    lbl_tabanMaas.Visible = false;

                    lbl_makamTazminati2.Visible = false;
                    lbl_makamTazminati.Visible = false;

                    lbl_idariGorevTazminati.Visible = false;
                    lbl_idariGorevTazminati2.Visible = false;

                    lbl_fazlaMesaiSaati2.Visible = false;
                    lbl_fazlaMesaiSaati.Visible = false;

                    lbl_fazlaMesaiUcreti2.Visible = false;
                    lbl_fazlaMesaiUcreti.Visible = false;

                    lbl_vergiMatrahi2.Visible = false;
                    lbl_vergiMatrahi.Visible = false;

                    pic_resim.Visible = false;
                    this.pic_resim.BorderStyle = BorderStyle.None;
                    MessageBox.Show("Hatalı Giriş Yaptınız");

                }

                

            }

            


        }
    //tc girilmesi gereken textbox'a rakam dışındaki sembollerin yazılmasını engeller.
        private void txt_giriniz_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;//eğer rakamsa  yazdır.
            }

            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;//eğer basılan tuş backspace ise yazdır.
            }
            else
            {
                e.Handled = true;//bunların dışındaysa hiçbirisini yazdırma
            }
        }
    }
}



