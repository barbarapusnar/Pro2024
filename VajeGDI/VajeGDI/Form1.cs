using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace VajeGDI
{
    public partial class Form1 : Form
    {
        int S_CELICA = 100; //širina enega kvadratka
        int[,] STANJE ={
             {0,0,0,0,0,0,0},
             {0,0,0,1,0,0,0},
             {0,0,1,2,0,0,0},
             {0,1,2,1,2,0,0},
             {1,1,2,2,1,2,0}
         };
        int ST_VRSTIC = 5;
        int ST_STOLPCEV = 7;
        int igralec = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            ST_VRSTIC = STANJE.GetLength(0);
            ST_STOLPCEV = STANJE.GetLength(1);
            narišiVodoravne(g);
            narišiNavpične(g);
            narišiKrožce(g);
        }

        private void narišiKrožce(Graphics g)
        {
            SolidBrush barva =new SolidBrush(Color.Red);
            //preglej celo tabelo stanje
            //če je 1 nariši zelen krog, če je 2 nariši rdeč krog
            for (int k = 0; k < ST_VRSTIC; k++)
            {
                for (int j = 0; j < ST_STOLPCEV; j++)
                {
                    if (STANJE[k, j] != 0)
                    {
                        if (STANJE[k, j] == 1)
                            barva = new SolidBrush(Color.Red);
                        else
                            barva = new SolidBrush(Color.Green);
                        g.FillEllipse(barva, j*100+5, k*100+5, 90, 90);
                    }
                }
            }
        }

        private void narišiNavpične(Graphics g)
        {
            Pen p = new Pen(Color.Black);
            for (int k = 0; k <= ST_STOLPCEV; k++)
            {
                g.DrawLine(p,k*100, 0, k*100, ST_VRSTIC * 100) ;
            }
        }
        private void narišiVodoravne(Graphics g)
        {
            Pen p = new Pen(Color.Black);
            for (int k = 0; k <= ST_VRSTIC; k++)
            {
                g.DrawLine(p, 0, k*100, ST_STOLPCEV * 100, k * 100);
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            // MessageBox.Show("Kliknil si na " + e.X + ", " + e.Y);
            int vrstica = e.Y / 100;
            int stolpec = e.X / 100;
            
            STANJE[vrstica, stolpec] = igralec;
            igralec = 3 - igralec;
            pictureBox1.Invalidate();
        }
    }
}
