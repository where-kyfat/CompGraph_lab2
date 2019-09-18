using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace ImageGrayWF
{
	public partial class Form1 : Form
	{
		private Image image1;
		private Bitmap gray1;
		private Bitmap gray2;
        private Bitmap pb2;
		public Form1()
		{
			InitializeComponent();
			image1 = pictureBox.Image;
            //Вручную создает картинку во втором picturebox и заливает ее белым
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pb2 = new Bitmap(pictureBox1.Image);

            for (int x = 0; x < pictureBox1.Width; x++)
            {
                for (int y = 0; y < pictureBox1.Height; y++)
                {
                    pb2.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                }
            }
            pictureBox1.Image = pb2;
        }

        //Чтобы не нажимать ресет постоянно
        private void Reset()
        {
            pictureBox.Image = image1;
            pictureBox1.Image = pb2;
        }

        //Отрисовка гистограммы
        //Передается только массив 0..256 с количеством пикселей такого оттенка (т.к. R=G=B в оттенках серого)
        private void DrawGist(int[] gist)
        {
            var w = pictureBox1.Width;
            var h = pictureBox1.Height;
            Bitmap im = new Bitmap(pictureBox1.Image);

            //Выглядит кривовато, но сделано так для того чтоб размер picturebox можно было менять как угодно,
            //до тех пор пока его ширина больше 256
            double scaleX = (double)w / 256;
            double scaleY = (double)h / gist.Max();
            for (int i = 0; i < w/scaleX; i++)
                for (int j = h-1; j > h - (int)(gist[i]*scaleY); j--)
                {
                    //третий цикл нужен для отрисовки столбца нужной ширины
                    for (int k = 0; k < scaleX; k++)
                    {
                        im.SetPixel((i*(int)scaleX)+k, j, Color.FromArgb(i,i,i));
                        pictureBox1.Image = im;
                    }
                }
            
        }

		private void ResetButton_Click(object sender, EventArgs e)
		{
            Reset();
		}

        //Оттенки серого по первой формуле
		private void RGBToGrey1Button_Click(object sender, EventArgs e)
		{
            Reset();
            int[] gist = new int[256];
			Bitmap ImageBitmap = new Bitmap(pictureBox.Image);
			for (int x = 0; x < ImageBitmap.Width; x++)
			{
				for (int y = 0; y < ImageBitmap.Height; y++)
				{
					Color bitmapColor = ImageBitmap.GetPixel(x, y);
					int colorGray = (int)(bitmapColor.R * 0.299 +
					bitmapColor.G * 0.587 + bitmapColor.B * 0.114);
					ImageBitmap.SetPixel(x, y, Color.FromArgb(colorGray,colorGray,colorGray));
                    ++gist[colorGray];
				}
			}
			gray1 = ImageBitmap;
			pictureBox.Image = ImageBitmap;
            DrawGist(gist);
		}

        //По второй
		private void RGBToGrey2Button_Click(object sender, EventArgs e)
		{
            Reset();
            int[] gist = new int[256];
			Bitmap ImageBitmap = new Bitmap(pictureBox.Image);
			for (int x = 0; x < ImageBitmap.Width; x++)
			{
				for (int y = 0; y < ImageBitmap.Height; y++)
				{
					Color bitmapColor = ImageBitmap.GetPixel(x, y);
					int colorGray = (int)(bitmapColor.R * 0.2126 +
					bitmapColor.G * 0.7152 + bitmapColor.B * 0.0722);
					ImageBitmap.SetPixel(x, y, Color.FromArgb(colorGray, colorGray, colorGray));
                    ++gist[colorGray];
                }
			}
			gray2 = ImageBitmap;
			pictureBox.Image = ImageBitmap;
            DrawGist(gist);
        }

		private void Button1_Click(object sender, EventArgs e)
		{
            Reset();
			Bitmap ImageBitmap = new Bitmap(pictureBox.Image);
			for (int x = 0; x < ImageBitmap.Width; x++)
			{
				for (int y = 0; y < ImageBitmap.Height; y++)
				{
					Color bitmapColor1 = gray1.GetPixel(x, y);
					Color bitmapColor2 = gray2.GetPixel(x, y);
                    int color1 = bitmapColor1.R;
					int color2 = bitmapColor1.G;
                    int color3 = bitmapColor1.B;
                    if ((bitmapColor1.R != bitmapColor2.R) || (bitmapColor1.G != bitmapColor2.G) || (bitmapColor1.B != bitmapColor2.B))
                    {
                        color1 = 255;
                        color2 = 255;
                        color3 = 255;
                    }

                    ImageBitmap.SetPixel(x, y, Color.FromArgb(color1, color2, color3));
				}
			}
			pictureBox.Image = ImageBitmap;
		}
    }
}
