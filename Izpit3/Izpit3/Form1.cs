using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Izpit3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radJPY_CheckedChanged(object sender, EventArgs e)
        {
            labR.Text = "JPY";
        }

        private void radGBP_CheckedChanged(object sender, EventArgs e)
        {
            labR.Text = "GBP";
        }

        private void radUSD_CheckedChanged(object sender, EventArgs e)
        {
            labR.Text = "USD";
        }

        private void btnIzračunaj_Click(object sender, EventArgs e)
        {
            double vnos = double.Parse(txtEUR.Text);
            double rezultat = 0;
            //            1EUR = 1,2810 USD
            //1EUR = 159,1828 JPY
            //1 EUR = 0,6644 GBP

            if (radUSD.Checked == true)
                rezultat = 1.281 * vnos;
            if (radJPY.Checked == true)
                rezultat = 158.1828 * vnos;
            if (radGBP.Checked == true)
                rezultat = 0.6644 * vnos;
            txtR.Text = rezultat + "";
        }

        private void btnPOčisti_Click(object sender, EventArgs e)
        {
            txtEUR.Clear();
            txtR.Clear();
            radUSD.Checked = true;
        }
    }
}
