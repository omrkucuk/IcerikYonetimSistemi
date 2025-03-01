using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
namespace IcerikUretimSistemi.UI.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            KullaniciListele();
        }

        // ListView için örnek veri ekleme
        void KullaniciListele()
        {
            // Önce FlowLayoutPanel içindeki her şeyi temizle
            flpKullanicilar.Controls.Clear();

            // Örnek kullanıcı listesi
            List<(string ad, string kullaniciAdi)> kullanicilar = new List<(string, string)>
    {
        ("Ahmet Yılmaz", "ahmet123"),
        ("Mehmet Demir", "mehmet99"),
        ("Elif Karaca", "elif.k"),
        ("Zeynep Çelik", "zeynepc"),
        ("Burak Kaya", "burak.kaya")
    };

            foreach (var kullanici in kullanicilar)
            {
                // Kullanıcı kartı (Panel)
                Panel pnl = new Panel();
                pnl.Size = new Size(250, 100); // Kartın boyutu
                pnl.BackColor = Color.White;
                pnl.BorderStyle = BorderStyle.FixedSingle;
                pnl.Margin = new Padding(10); // Kartlar arası boşluk

                // Kullanıcı adı etiketi
                Label lblAd = new Label();
                lblAd.Text = kullanici.ad;
                lblAd.Font = new Font("Arial", 12, FontStyle.Bold);
                lblAd.Location = new Point(10, 10);
                lblAd.AutoSize = true;

                // Kullanıcı adı (username) etiketi
                Label lblKullaniciAdi = new Label();
                lblKullaniciAdi.Text = $"@{kullanici.kullaniciAdi}";
                lblKullaniciAdi.Font = new Font("Arial", 10, FontStyle.Italic);
                lblKullaniciAdi.ForeColor = Color.Gray;
                lblKullaniciAdi.Location = new Point(10, 40);
                lblKullaniciAdi.AutoSize = true;

                // Takip Et butonu
                Button btnTakip = new Button();
                btnTakip.Text = "Takip Et";
                btnTakip.Size = new Size(80, 30);
                btnTakip.Location = new Point(10, 60);
                btnTakip.BackColor = Color.LightBlue;
                btnTakip.Click += (s, e) => MessageBox.Show($"{kullanici.ad} takip edildi!");

                // Panel içine elemanları ekle
                pnl.Controls.Add(lblAd);
                pnl.Controls.Add(lblKullaniciAdi);
                pnl.Controls.Add(btnTakip);

                // FlowLayoutPanel içine kartı ekle
                flpKullanicilar.Controls.Add(pnl);
            }
        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            ıconPictureBox1.IconChar = IconChar.Bars;
            ıconPictureBox1.IconSize = 50;

            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = IconChar.Bars;  // Bars ikonunu kullanıyoruz
            iconButton1.IconSize = iconButton1.Width;  // İkonun boyutunu butonun genişliğine ayarlıyoruz
            //iconButton1. = ContentAlignment.MiddleCenter;  // İkonu butonun ortasına yerleştiriyoruz
            iconButton1.Text = "";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            foreach (Panel pnl in flpKullanicilar.Controls)
            {
                Label lblAd = pnl.Controls.OfType<Label>().FirstOrDefault();
                Label lblKullaniciAdi = pnl.Controls.OfType<Label>().Skip(1).FirstOrDefault();

                if (lblAd != null && lblKullaniciAdi != null)
                {
                    bool goster = lblAd.Text.ToLower().Contains(textBox1.Text.ToLower()) ||
                                  lblKullaniciAdi.Text.ToLower().Contains(textBox1.Text.ToLower());

                    pnl.Visible = goster;
                }
            }
        }
    }
}
