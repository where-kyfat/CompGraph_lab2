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
	public partial class Form_Ex1 : Form
	{
        private Form_Main FormMain;
		private Bitmap gray1;
		private Bitmap gray2;
		public Form_Ex1(Form_Main form_Main)
		{
			InitializeComponent();

            FormMain = form_Main;

            RGBToGrey1();
            RGBToGrey2();
            DrawDifference();
        }


        //Отрисовка гистограммы
        //Передается только массив 0..256 с количеством пикселей такого оттенка (т.к. R=G=B в оттенках серого)
        private void DrawGist(int[] gist, PictureBox pictureBox)
        {
            int GistWidth = pictureBox.Width;
            int GistHeight = pictureBox.Height;
            Bitmap GistImage = new Bitmap(GistWidth, GistHeight);

            //Выглядит кривовато, но сделано так для того чтоб размер picturebox можно было менять как угодно,
            //до тех пор пока его ширина больше 256
            double scaleX = GistWidth / 256.0;
            double scaleY = (double)GistHeight / gist.Max();
            for (int x = 0; x < GistWidth/scaleX; x++)
                for (int y = GistHeight-1; y > GistHeight - (int)(gist[x]*scaleY); y--)
                {
                    //третий цикл нужен для отрисовки столбца нужной ширины
                    for (int k = 0; k < scaleX; k++)
                    {
                        GistImage.SetPixel((x*(int)scaleX)+k, y, Color.FromArgb(x,x,x));
                        pictureBox.Image = GistImage;
                    }
                }
        }


        //Оттенки серого по первой формуле
		private void RGBToGrey1()
		{
            int[] gist = new int[256];
			Bitmap ImageBitmap = new Bitmap(pictureBox_OriginImage.Image);
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
			pictureBox_Gray1.Image = ImageBitmap;
            DrawGist(gist, pictureBox_Gray1Gist);
		}

        //По второй
		private void RGBToGrey2()
		{
            int[] gist = new int[256];
			Bitmap ImageBitmap = new Bitmap(pictureBox_OriginImage.Image);
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
            pictureBox_Gray2.Image = ImageBitmap;
            DrawGist(gist, pictureBox_Gray2Gist);
        }

        private void DrawDifference()
        {
            Bitmap DifferenceOfGray_Image = new Bitmap(pictureBox_OriginImage.Image);
            for (int x = 0; x < DifferenceOfGray_Image.Width; x++)
            {
                for (int y = 0; y < DifferenceOfGray_Image.Height; y++)
                {
                    Color Gray1Color = gray1.GetPixel(x, y);
                    Color Gray2Color = gray2.GetPixel(x, y);
                    int color = Gray1Color.R;
                    if (Gray1Color.R != Gray2Color.R)
                    {
                        color = 255;
                    }

                    DifferenceOfGray_Image.SetPixel(x, y, Color.FromArgb(color, color, color));
                }
            }
            pictureBox_Difference.Image = DifferenceOfGray_Image;
        }

        private void Form_Ex1_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormMain.Show();
        }
    }
}
