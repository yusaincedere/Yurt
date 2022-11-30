using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Yurt.Properties;

namespace Yurt
{
    public partial class YoneticiEkrani : Form
    {

        bool kontrol = false;
        int sayac = 1;
        Ogrenci secilenOgrenci;
        Yonetici secilenYonetici;
        Yonetici girisYapanYonetici;
        
        public YoneticiEkrani(Yonetici yonetici)
        {
            InitializeComponent();
            girisYapanYonetici = yonetici;
            yoneticiAdSoyadLabel.Text = yonetici.ad +" "+ yonetici.soyad;
            ProfilFoto1.Image = byteArrayToImage(yonetici.profilfoto);
            ProfilFoto2.Image = byteArrayToImage(yonetici.profilfoto);
            TcNoTextBox.Text = yonetici.tcno;
            AdTextBox.Text = yonetici.ad;
            SoyadTextBox.Text = yonetici.soyad;
            SifreTextBox.Text = yonetici.sifre;
            TelefonNoTextBox.Text = yonetici.telno;
            EmailTextBox.Text = yonetici.email;
            DogumtarihiBox.Value = DateTime.Parse(yonetici.dogumtarihi);


        }

        void AyracHareket(Control control)
        {
            ayrac.Top = control.Top;
            ayrac.Height = control.Height;
        }



    

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }


        private void bunifuTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        


        private void tabPage6_Click(object sender, EventArgs e)
        {

        }


        private void bunifuLabel15_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            Image profileImage;
            Bitmap profileBitmap;

            OpenFileDialog file = new OpenFileDialog();
            file.Title = "Lütfen bir resim seçin";
            file.Filter = "image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            DialogResult result = file.ShowDialog();
            if (result == DialogResult.OK)
            {
                profileImage = Image.FromFile(file.FileName);
                profileBitmap = (Bitmap)profileImage;
                ogrenciPfotoKaydetBox.Image = profileBitmap;
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void gridList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void soyadEditButton_Click(object sender, EventArgs e)
        {
            SoyadTextBox.Enabled = true;
        }

        private void sifreEditButton_Click(object sender, EventArgs e)
        {
            SifreTextBox.Enabled = true;
        }

        private void adEditButton_Click(object sender, EventArgs e)
        {
            AdTextBox.Enabled = true;
        }

        private void dogumtarEditButton_Click(object sender, EventArgs e)
        {
            DogumtarihiBox.Enabled = true;
        }

        private void emailEditButton_Click(object sender, EventArgs e)
        {
            EmailTextBox.Enabled = true;
        }

        private void telnoEditButton_Click(object sender, EventArgs e)
        {
            TelefonNoTextBox.Enabled = true;
        }

        private void ProfilFoto1_Click(object sender, EventArgs e)
        {

        }
        private void ProfilFotoDegistirButton_Click(object sender, EventArgs e)
        {

            Image profileImage;
            Bitmap profileBitmap;

            OpenFileDialog file = new OpenFileDialog();
            file.Title = "Lütfen bir resim seçin";
            file.Filter = "image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            DialogResult result = file.ShowDialog();
            if (result == DialogResult.OK)
            {
                profileImage = Image.FromFile(file.FileName);
                profileBitmap = (Bitmap)profileImage;
                ProfilFoto1.Image = profileBitmap;
                ProfilFoto2.Image = profileBitmap;

            }
        }
        private void ProfilSayfa_Click(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel3_Click(object sender, EventArgs e)
        {

        }



        private void ProfilButton_Click(object sender, EventArgs e)
        {
            AyracHareket((Control)sender);
            baslikIcon.Image = Resources.profil;
            sayfaBaslik.Text = "PROFİLİM";
            Sayfa8.SetPage("Profil");
        }

        private void ogrencilerButton_Click(object sender, EventArgs e)
        {
            AyracHareket((Control)sender);
            baslikIcon.Image = Resources.yonetici;
            sayfaBaslik.Text = "YÖNETİCİLER";
            Sayfa8.SetPage("YöneticilerSayfası");
            

            List<Yonetici> yoneticiList = DataAccess.yoneticiYukle();
            YoneticiGridList.Rows.Clear();

            foreach (Yonetici yonetici in yoneticiList)
            {
                YoneticiGridList.Rows.Add();
                YoneticiGridList.Rows[YoneticiGridList.Rows.Count - 1].Cells[0].Value = YoneticiGridList.Rows.Count;
                YoneticiGridList.Rows[YoneticiGridList.Rows.Count - 1].Cells[1].Value = yonetici.tcno;
                YoneticiGridList.Rows[YoneticiGridList.Rows.Count - 1].Cells[2].Value = yonetici.ad;
                YoneticiGridList.Rows[YoneticiGridList.Rows.Count - 1].Cells[3].Value = yonetici.soyad;
                YoneticiGridList.Rows[YoneticiGridList.Rows.Count - 1].Cells[4].Value = yonetici.telno;
                YoneticiGridList.Rows[YoneticiGridList.Rows.Count - 1].Cells[5].Value = yonetici.email;
                YoneticiGridList.Rows[YoneticiGridList.Rows.Count - 1].Cells[6].Value = yonetici.dogumtarihi;

            }
        }


        private void duzenleButton_Click(object sender, EventArgs e)
        {

            AyracHareket((Control)sender);
            baslikIcon.Image = Resources.liste;
            sayfaBaslik.Text = "ÖĞRENCİLER";
            Sayfa8.SetPage("ÖgrencilerSayfasi");
            ogrenciAraBox.Visible = true;
            List<Ogrenci> ogrenciList = DataAccess.ogrenciYukle();
            OgrenciGridList.Rows.Clear();

            foreach (Ogrenci ogrenci in ogrenciList)
            {
                OgrenciGridList.Rows.Add();
                OgrenciGridList.Rows[OgrenciGridList.Rows.Count - 1].Cells[0].Value = OgrenciGridList.Rows.Count;
                OgrenciGridList.Rows[OgrenciGridList.Rows.Count - 1].Cells[1].Value = ogrenci.tcno;
                OgrenciGridList.Rows[OgrenciGridList.Rows.Count - 1].Cells[2].Value = ogrenci.ad;
                OgrenciGridList.Rows[OgrenciGridList.Rows.Count - 1].Cells[3].Value = ogrenci.soyad;
                OgrenciGridList.Rows[OgrenciGridList.Rows.Count - 1].Cells[4].Value = ogrenci.telno;
                OgrenciGridList.Rows[OgrenciGridList.Rows.Count - 1].Cells[5].Value = ogrenci.email;
                OgrenciGridList.Rows[OgrenciGridList.Rows.Count - 1].Cells[6].Value = ogrenci.bolum;
                OgrenciGridList.Rows[OgrenciGridList.Rows.Count - 1].Cells[7].Value = ogrenci.dogumtarihi;

            }
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void kapatButton_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void genisletButton_Click(object sender, EventArgs e)
        {
            changeSize();
        }

        private void Sayfa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void changeSize()
        {
           if(sayac % 2 == 0)
            {
                this.WindowState = FormWindowState.Normal; 
                
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
            sayac += 1;
        }

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            kontrol = true;
        }

        private void topPanel_MouseUp(object sender, MouseEventArgs e)
        {
            kontrol = false;
        }

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (kontrol == true)
            {
                this.Location = Cursor.Position;
            }
        }

        private void cikisButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Programdan çıkmak istiyormusunuz?", "ÇIKIŞ", MessageBoxButtons.YesNo);
            if(dialog == DialogResult.Yes)
            {
                this.Close();
            }
            
        }
        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
           if(byteArrayIn != null)
            {
                MemoryStream ms = new MemoryStream(byteArrayIn);
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
            return Resources.profileicon;

        }

        private void TcNoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void adLabel_Click(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void ogrenciListeYenileButton_Click(object sender, EventArgs e)
        {
            List<Ogrenci> ogrenciList = DataAccess.ogrenciYukle();
            OgrenciGridList.Rows.Clear();

            foreach (Ogrenci ogrenci in ogrenciList)
            {
                OgrenciGridList.Rows.Add();
                OgrenciGridList.Rows[OgrenciGridList.Rows.Count - 1].Cells[0].Value = OgrenciGridList.Rows.Count;
                OgrenciGridList.Rows[OgrenciGridList.Rows.Count - 1].Cells[1].Value = ogrenci.tcno;
                OgrenciGridList.Rows[OgrenciGridList.Rows.Count - 1].Cells[2].Value = ogrenci.ad;
                OgrenciGridList.Rows[OgrenciGridList.Rows.Count - 1].Cells[3].Value = ogrenci.soyad;
                OgrenciGridList.Rows[OgrenciGridList.Rows.Count - 1].Cells[4].Value = ogrenci.telno;
                OgrenciGridList.Rows[OgrenciGridList.Rows.Count - 1].Cells[5].Value = ogrenci.email;
                OgrenciGridList.Rows[OgrenciGridList.Rows.Count - 1].Cells[6].Value = ogrenci.bolum;
                OgrenciGridList.Rows[OgrenciGridList.Rows.Count - 1].Cells[7].Value = ogrenci.dogumtarihi;

            }
        }

        private void ogrenciGuncelleButton_Click(object sender, EventArgs e)
        {
            string tcno ="";
        
            foreach(DataGridViewRow row in OgrenciGridList.Rows)
            {
                if (row.Selected)
                {
                  
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        int index = cell.ColumnIndex;
                        if (index == 1)
                        {
                            tcno = cell.Value.ToString();
                        }
                    }
                    secilenOgrenci = DataAccess.ogrenciAraTcNo(tcno)[0];
                }
            }

            ogrenciTcNoEditBox.Text = secilenOgrenci.tcno;
            ogrenciAdEditBox.Text = secilenOgrenci.ad;
            ogrenciSoyadEditBox.Text = secilenOgrenci.soyad;
            ogrenciBolumEditBox.Text = secilenOgrenci.bolum;
            ogrenciEmailEditBox.Text = secilenOgrenci.email;
            ogrenciDogumtarEditBox.Value= DateTime.Parse(secilenOgrenci.dogumtarihi);
            ogrenciTelnoEditBox.Text = secilenOgrenci.telno;
            Image image = byteArrayToImage(secilenOgrenci.profilfoto);
            Bitmap profileBitmap = (Bitmap)image;
            OgrenciProfilFotoEdit.Image = profileBitmap;
            baslikIcon.Image = Resources.edit1;
            sayfaBaslik.Text = "ÖĞRENCİ DÜZENLE";
            Sayfa8.SetPage("ÖgrenciDüzenle");



        }

        private void ogrenciProfilFotoButton_Click(object sender, EventArgs e)
        {
            Image profileImage;
            Bitmap profileBitmap;

            OpenFileDialog file = new OpenFileDialog();
            file.Title = "Lütfen bir resim seçin";
            file.Filter = "image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            DialogResult result = file.ShowDialog();
            if (result == DialogResult.OK)
            {
                profileImage = Image.FromFile(file.FileName);
                profileBitmap = (Bitmap)profileImage;
                OgrenciProfilFotoEdit.Image = profileBitmap;
  
            }
        }

        private void ogrenciDegisiklikKaydet_Click(object sender, EventArgs e)
        {
            
        }

        private void DuzenleSayfaGeriButton_Click(object sender, EventArgs e)
        {
            baslikIcon.Image = Resources.liste;
            sayfaBaslik.Text = "ÖĞRENCİLER";
            Sayfa8.SetPage("ÖgrencilerSayfasi");
        }

        private void duzenleSayfaOnaylaButton_Click(object sender, EventArgs e)
        {
            secilenOgrenci.tcno = ogrenciTcNoEditBox.Text;
            secilenOgrenci.ad = ogrenciAdEditBox.Text;
            secilenOgrenci.soyad = ogrenciSoyadEditBox.Text;
            secilenOgrenci.email = ogrenciEmailEditBox.Text;
            secilenOgrenci.bolum = ogrenciBolumEditBox.Text;
            secilenOgrenci.telno = ogrenciTelnoEditBox.Text;
            secilenOgrenci.dogumtarihi = ogrenciDogumtarEditBox.Value.ToString("yyyy-MM-dd");
            secilenOgrenci.profilfoto =imageToByteArray(OgrenciProfilFotoEdit.Image);
            DataAccess.ogrenciGuncelle(secilenOgrenci);
            baslikIcon.Image = Resources.liste;
            sayfaBaslik.Text = "ÖĞRENCİLER";
            Sayfa8.SetPage("ÖgrencilerSayfasi");
        }

        private void yeniOgrenciEkleButton_Click(object sender, EventArgs e)
        {

        }


        private void ogrenciSilButton_Click(object sender, EventArgs e)
        {
            string tcno = "";
            foreach (DataGridViewRow row in OgrenciGridList.Rows)
            {
                if (row.Selected)
                {

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        int index = cell.ColumnIndex;
                        if (index == 1)
                        {
                            tcno = cell.Value.ToString();
                        }
                    }
                    secilenOgrenci = DataAccess.ogrenciAraTcNo(tcno)[0];
                }
            }

            DataAccess.ogrenciSil(secilenOgrenci);

            
        }

        private void DuzenleListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuPanel5_Click(object sender, EventArgs e)
        {

        }

        private void profilKaydetButton_Click(object sender, EventArgs e)
        {
            girisYapanYonetici.ad = AdTextBox.Text;
            girisYapanYonetici.soyad = SoyadTextBox.Text;
            girisYapanYonetici.email = EmailTextBox.Text;
            girisYapanYonetici.sifre = SifreTextBox.Text;
            girisYapanYonetici.telno = TelefonNoTextBox.Text;
            girisYapanYonetici.dogumtarihi = DogumtarihiBox.Value.ToString("yyyy-MM-dd");
            girisYapanYonetici.profilfoto = imageToByteArray(ProfilFoto1.Image);
            DataAccess.yoneticiGuncelle(girisYapanYonetici);
            baslikIcon.Image = Resources.profil;
            sayfaBaslik.Text = "PROFİLİM";
            Sayfa8.SetPage("Profil");
        }

        private void ogrenciKaydetButton_Click(object sender, EventArgs e)
        {

        }

        private void ogrenciAraBox_TextChanged(object sender, EventArgs e)
        {
            string value = ogrenciAraBox.Text;
            List<Ogrenci> ogrenciList = DataAccess.ogrenciAra(value);
            OgrenciGridList.Rows.Clear();
          
                foreach (Ogrenci ogrenci in ogrenciList)
                {
                    OgrenciGridList.Rows.Add();
                    OgrenciGridList.Rows[OgrenciGridList.Rows.Count - 1].Cells[0].Value = OgrenciGridList.Rows.Count;
                    OgrenciGridList.Rows[OgrenciGridList.Rows.Count - 1].Cells[1].Value = ogrenci.tcno;
                    OgrenciGridList.Rows[OgrenciGridList.Rows.Count - 1].Cells[2].Value = ogrenci.ad;
                    OgrenciGridList.Rows[OgrenciGridList.Rows.Count - 1].Cells[3].Value = ogrenci.soyad;
                    OgrenciGridList.Rows[OgrenciGridList.Rows.Count - 1].Cells[4].Value = ogrenci.telno;
                    OgrenciGridList.Rows[OgrenciGridList.Rows.Count - 1].Cells[5].Value = ogrenci.email;
                    OgrenciGridList.Rows[OgrenciGridList.Rows.Count - 1].Cells[6].Value = ogrenci.bolum;
                    OgrenciGridList.Rows[OgrenciGridList.Rows.Count - 1].Cells[7].Value = ogrenci.dogumtarihi;

                }
           
        }

        private void yoneticiAraBox_TextChanged(object sender, EventArgs e)
        {
            string value = yoneticiAraBox.Text;
            List<Yonetici> yoneticiList = DataAccess.YoneticiAra(value);
            YoneticiGridList.Rows.Clear();

            foreach (Yonetici yonetici in yoneticiList)
            {
                YoneticiGridList.Rows.Add();
                YoneticiGridList.Rows[YoneticiGridList.Rows.Count - 1].Cells[0].Value = YoneticiGridList.Rows.Count;
                YoneticiGridList.Rows[YoneticiGridList.Rows.Count - 1].Cells[1].Value = yonetici.tcno;
                YoneticiGridList.Rows[YoneticiGridList.Rows.Count - 1].Cells[2].Value = yonetici.ad;
                YoneticiGridList.Rows[YoneticiGridList.Rows.Count - 1].Cells[3].Value = yonetici.soyad;
                YoneticiGridList.Rows[YoneticiGridList.Rows.Count - 1].Cells[4].Value = yonetici.telno;
                YoneticiGridList.Rows[YoneticiGridList.Rows.Count - 1].Cells[5].Value = yonetici.email;
                YoneticiGridList.Rows[YoneticiGridList.Rows.Count - 1].Cells[6].Value = yonetici.dogumtarihi;

            }
        }

        private void yoneticiSilButton_Click(object sender, EventArgs e)
        {
            string tcno = "";

            foreach (DataGridViewRow row in YoneticiGridList.Rows)
            {
                if (row.Selected)
                {

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        int index = cell.ColumnIndex;
                        if (index == 1)
                        {
                            tcno = cell.Value.ToString();
                        }
                    }
                    secilenYonetici = DataAccess.YoneticiAraTcNo(tcno)[0];
                }
            }

            DataAccess.yoneticiSil(secilenYonetici);
        }

        private void yeniOgrenciButton_Click(object sender, EventArgs e)
        {
            baslikIcon.Image = Resources.add_circle_512;
            sayfaBaslik.Text = "ÖĞRENCİ EKLE";
            Sayfa8.SetPage("ÖğrenciKaydet");
        }

        private void yoneticiYenileButton_Click(object sender, EventArgs e)
        {

            List<Yonetici> yoneticiList = DataAccess.yoneticiYukle();
            YoneticiGridList.Rows.Clear();

            foreach (Yonetici yonetici in yoneticiList)
            {
                YoneticiGridList.Rows.Add();
                YoneticiGridList.Rows[YoneticiGridList.Rows.Count - 1].Cells[0].Value = YoneticiGridList.Rows.Count;
                YoneticiGridList.Rows[YoneticiGridList.Rows.Count - 1].Cells[1].Value = yonetici.tcno;
                YoneticiGridList.Rows[YoneticiGridList.Rows.Count - 1].Cells[2].Value = yonetici.ad;
                YoneticiGridList.Rows[YoneticiGridList.Rows.Count - 1].Cells[3].Value = yonetici.soyad;
                YoneticiGridList.Rows[YoneticiGridList.Rows.Count - 1].Cells[4].Value = yonetici.telno;
                YoneticiGridList.Rows[YoneticiGridList.Rows.Count - 1].Cells[5].Value = yonetici.email;
                YoneticiGridList.Rows[YoneticiGridList.Rows.Count - 1].Cells[6].Value = yonetici.dogumtarihi;

            }
        }

        private void yoneticiDuzenleButton_Click(object sender, EventArgs e)
        {
            string tcno = "";

            foreach (DataGridViewRow row in YoneticiGridList.Rows)
            {
                if (row.Selected)
                {

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        int index = cell.ColumnIndex;
                        if (index == 1)
                        {
                            tcno = cell.Value.ToString();
                        }
                    }
                    secilenYonetici = DataAccess.YoneticiAraTcNo(tcno)[0];
                }
            }


            yoneticiTcNoEditBox.Text = secilenYonetici.tcno;
            yoneticiAdEditBox.Text = secilenYonetici.ad;
            yoneticiSoyadEditBox.Text = secilenYonetici.soyad;
            yoneticiSifreEditBox.Text = secilenYonetici.sifre;
            yoneticiEmailEditBox.Text = secilenYonetici.email;
            yoneticiDogumTarEditBox.Value = DateTime.Parse(secilenYonetici.dogumtarihi);
            yoneticiTelnoEditBox.Text = secilenYonetici.telno;
            Image image = byteArrayToImage(secilenYonetici.profilfoto);
            Bitmap profileBitmap = (Bitmap)image;
            yoneticiPfEditBox.Image = profileBitmap;
            baslikIcon.Image = Resources.edit1;
            sayfaBaslik.Text = "YÖNETİCİ DÜZENLE";
            Sayfa8.SetPage("YöneticiDüzenle");
        }

        private void bunifuTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox3_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void yoneticiPfEditButton_Click(object sender, EventArgs e)
        {
            Image profileImage;
            Bitmap profileBitmap;

            OpenFileDialog file = new OpenFileDialog();
            file.Title = "Lütfen bir resim seçin";
            file.Filter = "image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            DialogResult result = file.ShowDialog();
            if (result == DialogResult.OK)
            {
                profileImage = Image.FromFile(file.FileName);
                profileBitmap = (Bitmap)profileImage;
                yoneticiPfEditBox.Image = profileBitmap;

            }
        }

        private void yoneticiEditGeriButton_Click(object sender, EventArgs e)
        {
            baslikIcon.Image = Resources.yonetici;
            sayfaBaslik.Text = "YÖNETİCİLER";
            Sayfa8.SetPage("YöneticilerSayfası");
        }

        private void yoneticiEditOnaylaButton_Click(object sender, EventArgs e)
        {
            
            secilenYonetici.tcno = yoneticiTcNoEditBox.Text;
            secilenYonetici.ad = yoneticiAdEditBox.Text;
            secilenYonetici.soyad = yoneticiSoyadEditBox.Text;
            secilenYonetici.email = yoneticiEmailEditBox.Text;
            secilenYonetici.sifre = yoneticiSifreEditBox.Text;
            secilenYonetici.telno = yoneticiTelnoEditBox.Text;
            secilenYonetici.dogumtarihi = yoneticiDogumTarEditBox.Value.ToString("yyyy-MM-dd");
            secilenYonetici.profilfoto = imageToByteArray(yoneticiPfEditBox.Image);
            DataAccess.yoneticiGuncelle(secilenYonetici);
            baslikIcon.Image = Resources.yonetici;
            sayfaBaslik.Text = "YÖNETİCİLER";
            Sayfa8.SetPage("YöneticilerSayfası");

        }

        private void ogrenciEkleButton_Click(object sender, EventArgs e)
        {
            baslikIcon.Image = Resources.add_circle_512;
            sayfaBaslik.Text = "ÖĞRENCİ EKLE";
            Sayfa8.SetPage("ÖğrenciKaydet");
        }

        private void yoneticiEkleButton_Click(object sender, EventArgs e)
        {
            baslikIcon.Image = Resources.add_circle_512;
            sayfaBaslik.Text = "YÖNETİCİ EKLE";
            Sayfa8.SetPage("YöneticiKaydet");
        }

        private void OgrenciKaydetGeriButton_Click(object sender, EventArgs e)
        {
            baslikIcon.Image = Resources.liste;
            sayfaBaslik.Text = "ÖĞRENCİLER";
            Sayfa8.SetPage("ÖgrencilerSayfasi");
        }

        private void yoneticiKaydetGeriButton_Click(object sender, EventArgs e)
        {
            baslikIcon.Image = Resources.yonetici;
            sayfaBaslik.Text = "YÖNETİCİLER";
            Sayfa8.SetPage("YöneticilerSayfası");
        }

        private void profilSifreGosterCheck_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {

            if (profilSifreGosterCheck.Checked)
            {
                SifreTextBox.PasswordChar = '\0';
            }
            else
            {
                SifreTextBox.PasswordChar = '*';
            }
        }

        private void yoneticiSifreKaydetTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void yoneticiSifreKaydetCheck_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {

            if (yoneticiSifreKaydetCheck.Checked)
            {
                yoneticiSifreKaydetTextBox.PasswordChar = '\0';
            }
            else
            {
                yoneticiSifreKaydetTextBox.PasswordChar = '*';
            }
        }

        private void yoneticiSifreEditCheck_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (yoneticiSifreEditCheck.Checked)
            {
                yoneticiSifreEditBox.PasswordChar = '\0';
            }
            else
            {
                yoneticiSifreEditBox.PasswordChar = '*';
            }
        }

        private void ogrenciKaydetOnaylaButton_Click(object sender, EventArgs e)
        {
            Ogrenci yeniogrenci = new Ogrenci();

            yeniogrenci.tcno = ogrenciTcnoKaydetTextBox.Text;
            yeniogrenci.ad = ogrenciAdKaydetTextBox.Text;
            yeniogrenci.soyad = ogrenciSoyadKaydetTextBox.Text;
            yeniogrenci.email = ogrenciEmailKaydetTextBox.Text;
            yeniogrenci.bolum = ogrenciBolumKaydetTextBox.Text;
            yeniogrenci.telno = ogrenciTelNoKaydetTextBox.Text;
            yeniogrenci.dogumtarihi = ogrenciDogumTarKaydetTextBox.Value.ToString("yyyy-MM-dd");
            yeniogrenci.profilfoto = imageToByteArray(ogrenciPfotoKaydetBox.Image);
            DataAccess.ogrenciKaydet(yeniogrenci);
            baslikIcon.Image = Resources.liste;
            sayfaBaslik.Text = "ÖĞRENCİLER";
            Sayfa8.SetPage("ÖgrencilerSayfasi");


        }

        private void yoneticiKaydetOnaylaButton_Click(object sender, EventArgs e)
        {
            Yonetici yeniyonetici = new Yonetici();
            yeniyonetici.tcno = yoneticiTcNoKaydetTextBox.Text;
            yeniyonetici.ad = yoneticiAdKaydetTextBox.Text;
            yeniyonetici.soyad = yoneticiSoyadKaydetTextBox.Text;
            yeniyonetici.email = yoneticiEmailKaydetTextBox.Text;
            yeniyonetici.sifre = yoneticiSifreKaydetTextBox.Text;
            yeniyonetici.telno = yoneticiTelnoKaydetTextBox.Text;
            yeniyonetici.dogumtarihi = yoneticiDogumtarKaydetBox.Value.ToString("yyyy-MM-dd");
            yeniyonetici.profilfoto = imageToByteArray(yoneticiPfKaydetBox.Image);
            DataAccess.yoneticiKaydet(yeniyonetici);
            baslikIcon.Image = Resources.liste;
            sayfaBaslik.Text = "YÖNETİCİLER";
            Sayfa8.SetPage("YöneticilerSayfası");
        }

        private void OgrenciProfilFotoEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
