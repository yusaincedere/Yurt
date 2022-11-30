using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yurt
{
    public partial class GirisEkrani : Form
    {
        int sayac = 1;
        bool kontrol = false;
        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string tcNo = tcNoText.Text;
            string password = passwordText.Text;

            List<Yonetici> girisYapanYonetici = DataAccess.YoneticiAra(tcNo, password);

            if(girisYapanYonetici.Count > 0)
            {
                YoneticiEkrani yoneticiEkrani = new YoneticiEkrani(girisYapanYonetici[0]);
                yoneticiEkrani.Show();
                this.Hide();
               
                
            }
            else
            {
                girisMesaj.Text = "TCNO VEYA ŞİFRE HATALI";
                girisMesaj.ForeColor = Color.Red;
                girisMesaj.Visible = true;
            }



        }

        private void GirisEkrani_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void kapatButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void genisletButton_Click(object sender, EventArgs e)
        {
            changeSize();
        }
        private void changeSize()
        {
            if (sayac % 2 == 0)
            {
                this.WindowState = FormWindowState.Normal;

            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
            sayac += 1;
        }

        private void kucultButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCheckBox1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (sifreGosterGirisCheck.Checked)
            {
                passwordText.PasswordChar = '\0';
            }
            else
            {
                passwordText.PasswordChar = '*';
            }
        }
    }
}
