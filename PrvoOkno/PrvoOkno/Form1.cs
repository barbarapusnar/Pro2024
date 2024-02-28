using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrvoOkno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //txtPrvo.Focus();
        }

        private void Seštej(object sender, EventArgs e)
        {
            //dobi vsebino textboxov
            int prvo = int.Parse(txtPrvo.Text);
            int drugo = int.Parse(txtDrugo.Text);
            double r = 0;
            if (radPlus.Checked==true)
                r = prvo + drugo;
            if (radMinus.Checked == true)
                r = prvo - drugo;
            if (radKrat.Checked == true)
                r = prvo * drugo;
            if (radDeli.Checked == true)
                r = Math.Round( (double)prvo / drugo,2);
            txtRezultat.Text = r+"";
            if (chkNeg.Checked == true && r < 0)
                txtRezultat.BackColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPrvo.Text = "";
            txtDrugo.Clear();
            txtRezultat.Clear();
            txtRezultat.BackColor = SystemColors.Control;
            txtPrvo.Focus();
        }
    }
}
