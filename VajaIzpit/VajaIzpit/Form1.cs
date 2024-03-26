using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VajaIzpit
{
    public partial class Form1 : Form
    {
        Color ozadje = Color.FromName("Green");
        Color ospredje = Color.FromArgb(100, 255, 0, 0);
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush br = new SolidBrush(ozadje);
            g.FillRectangle(br, 45, 20, 150, 120);
            Brush br1 = new SolidBrush(ospredje);
            g.FillRectangle(br1, 65, 35, 170, 130);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string barva = txtIme.Text;
            ozadje = Color.FromName(barva);
            pictureBox1.Invalidate();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("kliknil si na " + e.X + ", " + e.Y+
            //    "\n"+
            //    e.Clicks+" "+e.Button);
            if (e.X >= 45 && e.X <= 195 && e.Y >= 20 && e.Y <= 140)
            {
                //če klikneš na pravokotnik v ozadju mu spremeni barvo
                //v Azure
                ozadje = Color.Azure;
                pictureBox1.Invalidate();
                
            }
        }
    }
}
