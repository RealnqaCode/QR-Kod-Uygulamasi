using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace QrKodOkuyucu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnQrCreate_Click(object sender, EventArgs e)
        {
            string text = txtInput.Text.ToString();

            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                MessageBox.Show("Metin Girip Tekrar Deneyin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var Writer = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new ZXing.Common.EncodingOptions
                {
                    Width = 300,
                    Height = 300
                }
            };

            var Create = Writer.Write(text);

            pbQrCode.Image = Create;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (pbQrCode.Image == null)
            {
                MessageBox.Show("İlk Önce Qr Kodu Olusturun", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveFileDialog sfd= new SaveFileDialog
            {
                Filter = "PNG|*.png"
            };


            if (sfd.ShowDialog() == DialogResult.OK)
            {
                pbQrCode.Image.Save(sfd.FileName,System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void btnOku_Click(object sender, EventArgs e)
        {       
        
            
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Resim Dosyaları|*.png;*.jpg;*.jpeg;*.bmp";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                
                Bitmap image = new Bitmap(openFile.FileName);

                
                BarcodeReader reader = new BarcodeReader();
                var result = reader.Decode(image);

               
                if (result != null)
                {
                    MessageBox.Show("Panayo Kopyalandı : \n" + result.Text, "Okuma işlemı başarılı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Clipboard.SetText(result.Text);
                }
                else
                {
                    txtInput.Clear();
                    MessageBox.Show("Qr Kod Okunamadı");
                }
            }
        }

    }
}

