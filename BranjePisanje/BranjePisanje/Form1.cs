using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BranjePisanje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void odpriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlgOpen.Filter = "Tekstovne dat|*.txt;*.cs|Vse datoteke|*.*";
            DialogResult a = dlgOpen.ShowDialog();
            if (a != DialogResult.OK)
                return;
            string dat = dlgOpen.FileName;
            this.Text = dat;
            //beri datoteko
            txtVsebina.Clear();
            StreamReader sr = new StreamReader(dat);
            string r = "";
            while (r != null)
            {
                r = sr.ReadLine();
                txtVsebina.Text += r + Environment.NewLine;
            }
            //sr.Close();
        }

        private void shraniKotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlgSave.Filter = "Tekstovne|*.txt|Vse datoteke|*.*";
            DialogResult a = dlgSave.ShowDialog();
            if (a != DialogResult.OK)
                return;
            string dat = dlgSave.FileName;
            StreamWriter sw = new StreamWriter(dat);
            sw.Write(txtVsebina.Text);
            sw.Close();
        }
    }
}
