using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpressPaint
{
    public partial class Form1 : Form
    {
        Bitmap original = new Bitmap(640, 400);
        public Form1()
        {
            InitializeComponent();
        }

        private void odpriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlgOdpri.Filter = "Slike(*.jpg,*.png,*.bmp)|*.jpg;*.png;*.bmp|Vse|*.*";
            DialogResult a = dlgOdpri.ShowDialog();
            if (a != DialogResult.OK)
                return;
            string imeDatoteke = dlgOdpri.FileName;
            original = new Bitmap(imeDatoteke);
            pictureBox1.Image = original;
            PosodobiSliko();
        }
        private void NastaviDrsnike()
        {
            if (original.Width < pictureBox1.Width)
            {
                hScrollBar1.Visible = false;
            }
            else
            {
                hScrollBar1.Visible = true;
                hScrollBar1.Maximum = original.Width - pictureBox1.Width;
            }
            if (original.Height < pictureBox1.Height)
            {
                vScrollBar1.Visible = false;
            }
            else
            {
                vScrollBar1.Visible = true;
                vScrollBar1.Maximum = original.Height - pictureBox1.Height;
            }
        }
        private void PosodobiSliko()
        {
            NastaviDrsnike();
            Graphics g = pictureBox1.CreateGraphics();
            Rectangle r1 = new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height);//kje rišem
            Rectangle r2 = new Rectangle(hScrollBar1.Value, vScrollBar1.Value,
                pictureBox1.Width, pictureBox1.Height);//kateri del slike rišem
            g.DrawImage(original, r1, r2, GraphicsUnit.Pixel);
            pictureBox1.Update();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            PosodobiSliko();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            PosodobiSliko();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            PosodobiSliko();
        }

        private void navpičnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color pixel;
            for (int x = 0; x < original.Width / 2; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    pixel = original.GetPixel(x, y);
                    original.SetPixel(original.Width - x - 1, y,pixel);
                }
                PosodobiSliko();
            }
           
        }

        private void negativToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    Color barva = original.GetPixel(x, y);
                    int rdeča =255- barva.R;
                    int zelena = 255 - barva.G;
                    int modra = 255 - barva.B;
                    barva = Color.FromArgb(rdeča, zelena, modra);
                    original.SetPixel(x, y, barva);
                }
                PosodobiSliko();
            }
        }

        private void za90ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            original.RotateFlip(RotateFlipType.Rotate90FlipNone);
            PosodobiSliko();
        }

        private void shraniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Slike(*.jpg)|*.jpg|Vse|*.*";
            DialogResult a= saveFileDialog1.ShowDialog();
            if (a != DialogResult.OK)
                return;
            string imeD = saveFileDialog1.FileName;
            original.Save(imeD, System.Drawing.Imaging.ImageFormat.Bmp);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle r = new Rectangle(0, 0, original.Width, original.Height);
            g.DrawImage(original, r, r, GraphicsUnit.Pixel);
        }

        private void natisniSlikoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            printDialog1.ShowDialog();
            printDocument1.Print();
        }
    }
}
