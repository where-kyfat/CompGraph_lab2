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
		public Form1()
		{
			InitializeComponent();
			image1 = pictureBox.Image;
		}

		private void ResetButton_Click(object sender, EventArgs e)
		{
			pictureBox.Image = image1;
		}

		private void RGBToGrey1Button_Click(object sender, EventArgs e)
		{
			Bitmap ImageBitmap = new Bitmap(pictureBox.Image);
			for (int x = 0; x < ImageBitmap.Width; x++)
			{
				for (int y = 0; y < ImageBitmap.Height; y++)
				{
					Color bitmapColor = ImageBitmap.GetPixel(x, y);
					int colorGray = (int)(bitmapColor.R * 0.299 +
					bitmapColor.G * 0.587 + bitmapColor.B * 0.114);
					ImageBitmap.SetPixel(x, y, Color.FromArgb(colorGray,colorGray,colorGray));
				}
			}
			gray1 = ImageBitmap;
			pictureBox.Image = ImageBitmap;
		}

		private void RGBToGrey2Button_Click(object sender, EventArgs e)
		{
			Bitmap ImageBitmap = new Bitmap(pictureBox.Image);
			for (int x = 0; x < ImageBitmap.Width; x++)
			{
				for (int y = 0; y < ImageBitmap.Height; y++)
				{
					Color bitmapColor = ImageBitmap.GetPixel(x, y);
					int colorGray = (int)(bitmapColor.R * 0.2126 +
					bitmapColor.G * 0.7152 + bitmapColor.B * 0.0722);
					ImageBitmap.SetPixel(x, y, Color.FromArgb(colorGray, colorGray, colorGray));
				}
			}
			gray2 = ImageBitmap;
			pictureBox.Image = ImageBitmap;
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			Bitmap ImageBitmap = new Bitmap(pictureBox.Image);
			for (int x = 0; x < ImageBitmap.Width; x++)
			{
				for (int y = 0; y < ImageBitmap.Height; y++)
				{
					Color bitmapColor1 = gray1.GetPixel(x, y);
					Color bitmapColor2 = gray2.GetPixel(x, y);
					int color1 = Math.Abs(bitmapColor1.R - bitmapColor2.R);
					int color2 = Math.Abs(bitmapColor1.G - bitmapColor2.G);
					int color3 = Math.Abs(bitmapColor1.B - bitmapColor2.B);

					ImageBitmap.SetPixel(x, y, Color.FromArgb(color1, color2, color3));
				}
			}
			pictureBox.Image = ImageBitmap;
		}
	}
}
