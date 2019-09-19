using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageGrayWF
{
    public partial class Form_Ex3 : Form
    {
        private Form_Main FormMain;
        private Image OriginImage;

        public Form_Ex3(Form_Main form_Main)
        {
            InitializeComponent();
            FormMain = form_Main;
            OriginImage = ImagePictureBox.Image;
        }

        private void Form_Ex3_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormMain.Show();
        }

        private void ColorToHSV(Color color, out double hue, out double saturation, out double value)
        {
            int max = Math.Max(color.R, Math.Max(color.G, color.B));
            int min = Math.Min(color.R, Math.Min(color.G, color.B));

            hue = color.GetHue();
            saturation = (max == 0) ? 0 : 1d - (1d * min / max);
            value = max / 255d;
        }

        private Color ColorFromHSV(double hue, double saturation, double value)
        {
            int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
            double f = hue / 60 - Math.Floor(hue / 60);

            value = value * 255;
            int v = Convert.ToInt32(value);
            int p = Convert.ToInt32(value * (1 - saturation));
            int q = Convert.ToInt32(value * (1 - f * saturation));
            int t = Convert.ToInt32(value * (1 - (1 - f) * saturation));

            if (hi == 0)
                return Color.FromArgb(255, v, t, p);
            else if (hi == 1)
                return Color.FromArgb(255, q, v, p);
            else if (hi == 2)
                return Color.FromArgb(255, p, v, t);
            else if (hi == 3)
                return Color.FromArgb(255, p, q, v);
            else if (hi == 4)
                return Color.FromArgb(255, t, p, v);
            else
                return Color.FromArgb(255, v, p, q);
        }



        private void RGBtoHSVbutton_Click_Click(object sender, EventArgs e)
        {
            ImagePictureBox.Image = OriginImage;
            double hue;
            double saturation;
            double value;
            Bitmap RGBtoHSV_Image = new Bitmap(OriginImage);


            for (int x = 0; x < RGBtoHSV_Image.Width; x++)
            {
                for (int y = 0; y < RGBtoHSV_Image.Height; y++)
                {
                    Color color = RGBtoHSV_Image.GetPixel(x, y);
                    ColorToHSV(color, out hue, out saturation, out value);
                    hue += HueTrackBar.Value % 360;
                    saturation += SaturationTrackBar.Value / 1000.0;
                    saturation = saturation > 1 ? saturation - 1: saturation;
                    value += BrightnessTrackBar.Value / 100.0;
                    value = value > 1 ? value - 1 : value;
                    Color color1 = ColorFromHSV(hue, saturation, value);
                    RGBtoHSV_Image.SetPixel(x, y, Color.FromArgb(color1.R, color1.G, color1.B));
                }
            }
            ImagePictureBox.Image = RGBtoHSV_Image;
            Image image = RGBtoHSV_Image;
        }

        private void SaveImageButton_Click(object sender, EventArgs e)
        {
            //создание диалогового окна "Сохранить как..", для сохранения изображения
            SaveFileDialog savedialog = new SaveFileDialog();
            savedialog.Title = "Сохранить картинку как...";
            savedialog.OverwritePrompt = true;
            savedialog.CheckPathExists = true;
            savedialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
            savedialog.ShowHelp = true;
            if (savedialog.ShowDialog() == DialogResult.OK) //если в диалоговом окне нажата кнопка "ОК"
            {
                try
                {
                    ImagePictureBox.Image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                catch
                {
                    MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
