using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;


namespace Editor001
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public int det = 0;

        private Bitmap griYap(Bitmap bmp)
        {   

            for (int i = 0; i < bmp.Height - 1; i++)
            {
                for (int j = 0; j < bmp.Width - 1; j++)
                {
                    int deger = (bmp.GetPixel(j, i).R + bmp.GetPixel(j, i).G + bmp.GetPixel(j, i).B) / 3;

                    Color renk;
                    renk = Color.FromArgb(deger, deger, deger);

                    bmp.SetPixel(j, i, renk);
                }
            }
            return bmp;
        }
        private Bitmap redYap(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Height ; i++)
            {
                for (int j = 0; j < bmp.Width ; j++)
                {
                    int deger = bmp.GetPixel(j, i).R ;

                    Color renk;
                    renk = Color.FromArgb(deger, deger, deger);

                    bmp.SetPixel(j, i, renk);
                }
            }
            return bmp;
        }
        private Bitmap greenYap(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Height ; i++)
            {
                for (int j = 0; j < bmp.Width ; j++)
                {
                    int deger = bmp.GetPixel(j, i).G;

                    Color renk;
                    renk = Color.FromArgb(deger, deger, deger);

                    bmp.SetPixel(j, i, renk);
                }
            }
            return bmp;
        }
        private Bitmap blueYap(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Height ; i++)
            {
                for (int j = 0; j < bmp.Width ; j++)
                {
                    int deger = bmp.GetPixel(j, i).B;

                    Color renk;
                    renk = Color.FromArgb(deger, deger, deger);

                    bmp.SetPixel(j, i, renk);
                }
            }
            return bmp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public OpenFileDialog sfd = new OpenFileDialog();  

        private void sec_Click(object sender, EventArgs e)
        {
            if(det != 1)
                pictureBox3.Image = pictureBox1.Image;
            

            if (pictureBox3.Image == null)
            {
                MessageBox.Show("Henüz Bir Resim Seçmediniz!");
            }
            else {
                
                Bitmap image2 = new Bitmap(pictureBox3.Image);
                

                if (comboBox1.SelectedIndex == 0)
                {
                    det = 1;
                    pictureBox1.Image = pictureBox3.Image;

                }
                if (comboBox1.SelectedIndex == 1)
                {
                    det = 1;
                    Bitmap red = redYap(image2);
                    pictureBox1.Image = red;
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    det = 1;
                    Bitmap green = greenYap(image2);
                    pictureBox1.Image = green;

                }
                if (comboBox1.SelectedIndex == 3)
                {
                    det = 1;
                    Bitmap blue = blueYap(image2);
                    pictureBox1.Image = blue;

                }
             }
        }

        
        private void Olcekle_Click(object sender, EventArgs e)
        {
            Bitmap image5 = new Bitmap(pictureBox1.Image);
            int width = image5.Width;
            int height = image5.Height;
            int i;
            int w = Convert.ToInt32(txtw.Text);
            int h = Convert.ToInt32(txth.Text);
            Image originalImage = image5;
            Image resizedImage = originalImage.GetThumbnailImage(w, h, null, IntPtr.Zero);
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox1.Image = resizedImage;
            pictureBox3.Image = resizedImage;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
                      
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dereceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Henüz Bir Resim Seçmediniz!");
            }
            else
            {
            Bitmap image3 = new Bitmap(pictureBox1.Image);
            image3.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Image = image3;
            pictureBox3.Image = image3;
            }
                
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfd.Filter = "BMP|*.bmp|JPEG|*.jpg|PNG Resimleri|*.png|GIF|*.gif|TIF|*.tif|WMF|*.wmf|All Files|*.*";
            if (sfd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }
            pictureBox1.ImageLocation = sfd.FileName;
            pictureBox3.ImageLocation = sfd.FileName;
            pictureBox3.Image = pictureBox1.Image;
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Png Image|*.png|Bitmap Image|*.bmp";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();


            if (saveFileDialog1.FileName != "")
            {

                System.IO.FileStream fs =
                   (System.IO.FileStream)saveFileDialog1.OpenFile();

                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        this.pictureBox1.Image.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Png);
                        break;

                    case 2:
                        this.pictureBox1.Image.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Bmp);
                        break;


                }

                fs.Close();
            }
        }

        private void resmiYenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = sfd.FileName;
            pictureBox3.Image = pictureBox1.Image;
            det = 0;
        }

        private void yeniSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            sfd.FileName = null;
        }

        private void sYTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Henüz Bir Resim Seçmediniz!");
            }
            else
            {
            Bitmap image3 = new Bitmap(pictureBox1.Image);
            image3.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureBox1.Image = image3;
            pictureBox3.Image = image3;
            }
                
        }

        private void griTonlamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Henüz Bir Resim Seçmediniz!");
            }
            else
            {
                Bitmap image = new Bitmap(pictureBox1.Image);
                Bitmap gri = griYap(image);

                pictureBox1.Image = gri;
            }
        }

        private void terslemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Henüz Bir Resim Seçmediniz!");
            }
            else
            {
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                int width = bmp.Width;
                int height = bmp.Height;
                int x, y;
                Color r;
                for (x = 0; x < width; x++)
                {
                    for (y = 0; y < height; y++)
                    {
                        r = bmp.GetPixel(x, y);
                        r = Color.FromArgb(255 - r.R, 255 - r.G, 255 - r.B);
                        bmp.SetPixel(x, y, r);
                    }
                }
                pictureBox1.Image = bmp;
                pictureBox3.Image = bmp;
            }
        }

        private void aynalamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Henüz Bir Resim Seçmediniz!");
            }

            else
            {
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                int width = bmp.Width;
                int height = bmp.Height;
                int x = 0;
                int y = 0;

                Color[][] matrix;
                matrix = new Color[width][];
                for (int i = width - 1; i >= 0; i--)
                {
                    matrix[x] = new Color[height];
                    y = 0;
                    for (int j = 0; j < height; j++)
                    {
                        matrix[x][y] = bmp.GetPixel(i, j);
                        y++;
                    }
                    x++;

                }
                Bitmap newmirror = new Bitmap(width, height);
                y = 0;
                x = 0;
                for (int i = width - 1; i >= 0; i--)
                {
                    y = 0;
                    for (int j = 0; j < height; j++)
                    {
                        newmirror.SetPixel(x, y, bmp.GetPixel(i, j));
                        y++;
                    }
                    x++;
                }

                pictureBox1.Image = newmirror;
                pictureBox3.Image = pictureBox1.Image;

            }
        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Histogram Hazır Değil !");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Png Image|*.png|Bitmap Image|*.bmp";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();


            if (saveFileDialog1.FileName != "")
            {

                System.IO.FileStream fs =
                   (System.IO.FileStream)saveFileDialog1.OpenFile();

                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        this.pictureBox1.Image.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Png);
                        break;

                    case 2:
                        this.pictureBox1.Image.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Bmp);
                        break;


                }

                fs.Close();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            sfd.Filter = "BMP|*.bmp|JPEG|*.jpg|PNG Resimleri|*.png|All Files|*.*";
            if (sfd.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }
            pictureBox1.ImageLocation = sfd.FileName;
            pictureBox3.ImageLocation = sfd.FileName;
            pictureBox3.Image = pictureBox1.Image;
        }

        private void txth_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtw_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}