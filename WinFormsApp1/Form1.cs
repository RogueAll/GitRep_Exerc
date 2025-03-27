using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            GlobVar.rotatorointaor=270;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            GlobVar.rotatorointaor=180;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            GlobVar.rotatorointaor=90;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (GlobVar.rotatorointaor) {
                case 90:
                    pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    break;
                case 180:
                    pictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    break;
                case 270:
                    pictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    break;

            }
            
            Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image=Image.FromFile(@"C:\Users\student\Desktop\picture.jpg");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap pic = new Bitmap(pictureBox1.Image);
            for (int y = 0; (y
                        <= (pic.Height - 1)); y++)
            {
                for (int x = 0; (x
                            <= (pic.Width - 1)); x++)
                {
                    Color inv = pic.GetPixel(x, y);
                    inv = Color.FromArgb(255, (255 - inv.R), (255 - inv.G), (255 - inv.B));
                    pic.SetPixel(x, y, inv);
                    pictureBox1.Image = pic;
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
            Refresh();
        }
    }
}
