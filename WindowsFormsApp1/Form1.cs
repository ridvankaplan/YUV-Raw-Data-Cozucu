namespace WindowsFormsApp1
{
    using System;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.IO;
    using System.Windows.Forms;

    public partial class Form1 : System.Windows.Forms.Form
    {
        public string path = null;

        public Bitmap[] bmpDizi = new Bitmap[5000];

        internal int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void oynatbutton_MouseClick(object sender, MouseEventArgs e)
        {
            this.count = 0;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void kaydetbutton_MouseClick(object sender, MouseEventArgs e)
        {
            string yukseklik = yuksekliktextBox.Text;
            string genlik = genliktextBox.Text;
            int format_index = formatcomboBox.SelectedIndex;

            if (!sayiKontrol(yukseklik) || !sayiKontrol(genlik) || format_index == -1 || this.path == null)
            {
                MessageBox.Show("Bilgileri Doğru Doldurunuz!!!");
                return;
            }

            Byte[] bytes = File.ReadAllBytes(this.path);
            int toplamByte = bytes.Length;
            int alan = (int.Parse(yukseklik) * int.Parse(genlik));
            int frameSayi = 10000;
            timer1.Interval = 40;

            switch (format_index)
            {
                case 0:
                    frameSayi = toplamByte / (alan * 3);
                    kaydet(bytes, frameSayi, alan, int.Parse(yukseklik), int.Parse(genlik), "444", alan * 2);
                    break;
                case 1:
                    frameSayi = (toplamByte / (alan * 2));
                    kaydet(bytes, frameSayi, alan, int.Parse(yukseklik), int.Parse(genlik), "422", alan * 1);
                    break;
                case 2:
                    frameSayi = (toplamByte / (alan * 3 / 2));
                    kaydet(bytes, frameSayi, alan, int.Parse(yukseklik), int.Parse(genlik), "420", alan / 2);
                    break;

            }
        }

        private void kaydet(byte[] bytes, int frameSayi, int alan, int yukseklik, int genlik, String isim, int atla)
        {
            Bitmap bmp;
            Byte[] yBytes = new byte[10000000];
            Byte[] rBytes = new byte[yBytes.Length];
            Byte[] gBytes = new byte[yBytes.Length];
            Byte[] bBytes = new byte[yBytes.Length];

            int sayac = 0;
            for (int i = 0; i < (frameSayi * alan)+(frameSayi*atla);)
            {
                yBytes = yAl(frameSayi, alan, bytes, i, i + alan);
                rBytes = rgbAl(yBytes);
                gBytes = rgbAl(yBytes);
                bBytes = rgbAl(yBytes);
                bmp = rgbtobitmap(rBytes, gBytes, bBytes, yukseklik, genlik);
                this.bmpDizi[sayac] = bmp;
                sayac++;
                String tmp = i + isim + ".bmp";
                bmp.Save("C:/Users/Rıdvan/Desktop/ResimCikti/" + tmp, ImageFormat.Bmp);
                i += alan + atla;
            }
        }

        private byte[] yAl(double frameSayi, int alan, byte[] bytes, int baslangic, int bitis)
        {
            Byte[] yBytes = new byte[(int)Math.Round(frameSayi) * alan];
            int sayac = 0;
            yBytes[sayac] = bytes[baslangic];
            sayac++;
            for (int i = baslangic + 1; i < bitis; i++)
            {
                yBytes[sayac] = bytes[i];
                sayac++;

            }
            return yBytes;
        }

        private Bitmap rgbtobitmap(byte[] r, byte[] g, byte[] b, int yukseklik, int genlik)
        {
            Bitmap bmp = new Bitmap(genlik, yukseklik, PixelFormat.Format24bppRgb);
            int pos = 0;
            for (int y = 0; y < yukseklik; y++)
            {
                for (int x = 0; x < genlik; x++)
                {
                    bmp.SetPixel(x, y, Color.FromArgb(r[pos], g[pos], b[pos]));
                    pos += 1;
                }
            }
            return bmp;
        }

        private byte[] rgbAl(byte[] rgb)
        {

            Byte[] rBytes = new byte[rgb.Length];
            for (int i = 0; i < rgb.Length; i++)
            {
                rBytes[i] = rgb[i];
            }
            return rBytes;
        }

        private bool sayiKontrol(String sayi)
        {
            try
            {
                int gecici = int.Parse(sayi);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void yuklebutton_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Yuv Dosyaları| *.yuv";
            file.InitialDirectory = ".";
            file.Title = "Bir resim dosyası seçiniz"; ;
            if (file.ShowDialog() == DialogResult.OK)
            {
                this.path = file.FileName;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            pictureBox.Image = bmpDizi[count];
            count++;
        }

        private void stopbutton_MouseClick(object sender, MouseEventArgs e)
        {
            timer1.Stop();
        }
    }
}
