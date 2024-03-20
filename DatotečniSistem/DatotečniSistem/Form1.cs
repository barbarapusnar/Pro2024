using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DatotečniSistem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrikaži_Click(object sender, EventArgs e)
        {
            try
            {
                string pot = txtVnos.Text;
                DirectoryInfo mapa = new DirectoryInfo(pot);
                if (mapa.Exists)
                {
                    IzpišiVsebino(mapa.FullName);
                    return;
                }
                //kaj pa, če je uporabnik vnesel datoteko
                FileInfo f = new FileInfo(pot);
                if (f.Exists)
                {
                    IzpišiVsebino(f.Directory.FullName);
                    return;
                }
                throw new Exception("Ni ne datoteke ne mape s tem imenom");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Počisti()
        {
            lstDat.Items.Clear();
            lstMape.Items.Clear();
            txtMapa.Clear();
        }
        private void IzpišiVsebino(string fullName)
        {
            Počisti();
            DirectoryInfo d = new DirectoryInfo(fullName);
            txtMapa.Text = d.FullName;
            foreach (DirectoryInfo d1 in d.GetDirectories())
            {
                lstMape.Items.Add(d1.Name);
            }
            foreach (FileInfo f in d.GetFiles())
            {
                lstDat.Items.Add(f.Name);
            }
        }

        private void lstMape_SelectedIndexChanged(object sender, EventArgs e)
        {
            //v seznamu imam samo ime mape, za klic IzpišiVsebino rabim pa
            //polno pot
            string izbrana = lstMape.SelectedItem.ToString(); //ime mape
            string polnaPot =Path.Combine( txtMapa.Text ,izbrana);
            IzpišiVsebino(polnaPot);
        }

        private void btnGor_Click(object sender, EventArgs e)
        {
            //v txtMapa.Text imam polno pot do mape, moram iti en nivo višje
            try
            {
                DirectoryInfo d = new DirectoryInfo(txtMapa.Text);
                string starševskaMapa = "";
                if (d.Parent!=null)
                    starševskaMapa = d.Parent.FullName;
                else
                    throw new Exception("Ne moreš več gor");
                IzpišiVsebino(starševskaMapa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstDat_SelectedIndexChanged(object sender, EventArgs e)
        {
            string izbrana = lstDat.SelectedItem.ToString(); //ime mape
            string polnaPot = Path.Combine(txtMapa.Text, izbrana);
            txtDat.Text = polnaPot;
            FileInfo f = new FileInfo(polnaPot);
            txtVelikost.Text = f.Length.ToString()+" B";
        }

        private void btnPremakni_Click(object sender, EventArgs e)
        {
            string pot = Path.Combine(txtMapa.Text, lstDat.SelectedItem.ToString());
            string nova = txtNovo.Text; //vnesi polno pot do nove lokacije
            DialogResult a = MessageBox.Show("Resnično želiš premakniti datoteko?", "Opozorilo",
                MessageBoxButtons.YesNo);
            if (a == DialogResult.No)
                return;
            File.Move(pot, nova); 
            IzpišiVsebino(txtMapa.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string pot = Path.Combine(txtMapa.Text, lstDat.SelectedItem.ToString());
            string nova = txtNovo.Text; //vnesi polno pot do nove lokacije
            DialogResult a = MessageBox.Show("Resnično želiš kopirati datoteko?", "Opozorilo",
                MessageBoxButtons.YesNo);
            if (a == DialogResult.No)
                return;
            File.Copy(pot, nova);
            IzpišiVsebino(txtMapa.Text);
        }
    }
}
