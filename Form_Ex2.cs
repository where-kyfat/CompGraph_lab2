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
    public partial class Form_Ex2 : Form
    {
        private Image OriginalImage;
        private Bitmap EmptyPictureBox;
        private Form_Main FormMain;
        public Form_Ex2(Form_Main form_Main)
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

        private void Reset()
        {
            pictureBox_Image.Image = OriginalImage;
            pictureBox_Gist.Image = EmptyPictureBox;
        }

        private void DrawGist(int[] gist, char color)
        {
            int GistWidth = pictureBox_Gist.Width;
            int GistHeight = pictureBox_Gist.Height;
            Bitmap GistImage = new Bitmap(pictureBox_Gist.Image);

            //Выглядит кривовато, но сделано так для того чтоб размер picturebox можно было менять как угодно,
            //до тех пор пока его ширина больше 256
            double scaleX = GistWidth / 256.0;
            double scaleY = (double)GistHeight / gist.Max();
            for (int x = 0; x < GistWidth / scaleX; x++)
                for (int y = GistHeight - 1; y > GistHeight - (int)(gist[x] * scaleY); y--)
                {
                    //третий цикл нужен для отрисовки столбца нужной ширины
                    for (int k = 0; k < scaleX; k++)
                    {
                        switch (color)
                        {
                            case 'R':
                                GistImage.SetPixel((x * (int)scaleX) + k, y, Color.FromArgb(x, 0, 0));
                                break;
                            case 'G':
                                GistImage.SetPixel((x * (int)scaleX) + k, y, Color.FromArgb(0, x, 0));
                                break;
                            case 'B':
                                GistImage.SetPixel((x * (int)scaleX) + k, y, Color.FromArgb(0, 0, x));
                                break;
                            default:
                                break;
                        }

                        pictureBox_Gist.Image = GistImage;
                    }
                }
        }

        private void Form_Ex2_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormMain.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Reset();
            int[] gist = new int[256];
            Bitmap ImageBitmap = new Bitmap(pictureBox_Image.Image);
            for (int x = 0; x < ImageBitmap.Width; x++)
            {
                for (int y = 0; y < ImageBitmap.Height; y++)
                {
                    Color bitmapColor = ImageBitmap.GetPixel(x, y);
                    ImageBitmap.SetPixel(x, y, Color.FromArgb(bitmapColor.R, 0, 0));
                    ++gist[bitmapColor.R];
                }
            }
            pictureBox_Image.Image = ImageBitmap;
            DrawGist(gist, 'R');
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Reset();
            int[] gist = new int[256];
            Bitmap ImageBitmap = new Bitmap(pictureBox_Image.Image);
            for (int x = 0; x < ImageBitmap.Width; x++)
            {
                for (int y = 0; y < ImageBitmap.Height; y++)
                {
                    Color bitmapColor = ImageBitmap.GetPixel(x, y);
                    ImageBitmap.SetPixel(x, y, Color.FromArgb(0, bitmapColor.G, 0));
                    ++gist[bitmapColor.G];
                }
            }
            pictureBox_Image.Image = ImageBitmap;
            DrawGist(gist, 'G');
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Reset();
            int[] gist = new int[256];
            Bitmap ImageBitmap = new Bitmap(pictureBox_Image.Image);
            for (int x = 0; x < ImageBitmap.Width; x++)
            {
                for (int y = 0; y < ImageBitmap.Height; y++)
                {
                    Color bitmapColor = ImageBitmap.GetPixel(x, y);
                    ImageBitmap.SetPixel(x, y, Color.FromArgb(0, 0, bitmapColor.B));
                    ++gist[bitmapColor.B];
                }
            }
            pictureBox_Image.Image = ImageBitmap;
            DrawGist(gist, 'B');
        }
    }
}