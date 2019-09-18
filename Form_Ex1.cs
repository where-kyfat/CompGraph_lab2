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
		private Image OriginalImage;
		private Bitmap gray1;
		private Bitmap gray2;
        private Bitmap EmptyPictureBox;
		public Form_Ex1(Form_Main form_Main)
		{
			InitializeComponent();
            FormMain = form_Main;
			OriginalImage = pictureBox_Image.Image;
            //Вручную создает картинку во втором picturebox и заливает ее белым
            pictureBox_Gist.Image = new Bitmap(pictureBox_Gist.Width, pictureBox_Gist.Height);
            EmptyPictureBox = new Bitmap(pictureBox_Gist.Image);
           
            for (int x = 0; x < pictureBox_Gist.Width; x++)
            {
                for (int y = 0; y < pictureBox_Gist.Height; y++)
                {
                    EmptyPictureBox.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                }
            }
            pictureBox_Gist.Image = EmptyPictureBox;
        }

        //Чтобы не нажимать ресет постоянно
        private void Reset()
        {
            pictureBox_Image.Image = OriginalImage;
            pictureBox_Gist.Image = EmptyPictureBox;
        }

        //Отрисовка гистограммы
        //Передается только массив 0..256 с количеством пикселей такого оттенка (т.к. R=G=B в оттенках серого)
        private void DrawGist(int[] gist)
        {
            int GistWidth = pictureBox_Gist.Width;
            int GistHeight = pictureBox_Gist.Height;
            Bitmap GistImage = new Bitmap(pictureBox_Gist.Image);

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
                        pictureBox_Gist.Image = GistImage;
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
			Bitmap ImageBitmap = new Bitmap(pictureBox_Image.Image);
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
			pictureBox_Image.Image = ImageBitmap;
            DrawGist(gist);
		}

        //По второй
		private void RGBToGrey2Button_Click(object sender, EventArgs e)
		{
            Reset();
            int[] gist = new int[256];
			Bitmap ImageBitmap = new Bitmap(pictureBox_Image.Image);
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
			pictureBox_Image.Image = ImageBitmap;
            DrawGist(gist);
        }

        private void Form_Ex1_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormMain.Show();
        }

        private void Button_Difference(object sender, EventArgs e)
        {
            Reset();
            Bitmap DifferenceOfGray_Image = new Bitmap(pictureBox_Image.Image);
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
            pictureBox_Image.Image = DifferenceOfGray_Image;
        }
    }
}
