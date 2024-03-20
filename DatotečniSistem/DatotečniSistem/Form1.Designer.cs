namespace DatotečniSistem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtVnos = new System.Windows.Forms.TextBox();
            this.btnPrikaži = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstMape = new System.Windows.Forms.ListBox();
            this.lstDat = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGor = new System.Windows.Forms.Button();
            this.txtMapa = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDat = new System.Windows.Forms.TextBox();
            this.txtVelikost = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPremakni = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNovo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vnesi ime mape in klikni Prikaži";
            // 
            // txtVnos
            // 
            this.txtVnos.Location = new System.Drawing.Point(18, 61);
            this.txtVnos.Name = "txtVnos";
            this.txtVnos.Size = new System.Drawing.Size(304, 31);
            this.txtVnos.TabIndex = 1;
            // 
            // btnPrikaži
            // 
            this.btnPrikaži.Location = new System.Drawing.Point(391, 61);
            this.btnPrikaži.Name = "btnPrikaži";
            this.btnPrikaži.Size = new System.Drawing.Size(120, 31);
            this.btnPrikaži.TabIndex = 2;
            this.btnPrikaži.Text = "Prikaži";
            this.btnPrikaži.UseVisualStyleBackColor = true;
            this.btnPrikaži.Click += new System.EventHandler(this.btnPrikaži_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lstMape);
            this.groupBox1.Controls.Add(this.lstDat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnGor);
            this.groupBox1.Controls.Add(this.txtMapa);
            this.groupBox1.Location = new System.Drawing.Point(18, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 925);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vsebina mape";
            // 
            // lstMape
            // 
            this.lstMape.FormattingEnabled = true;
            this.lstMape.ItemHeight = 25;
            this.lstMape.Location = new System.Drawing.Point(299, 127);
            this.lstMape.Name = "lstMape";
            this.lstMape.Size = new System.Drawing.Size(209, 329);
            this.lstMape.TabIndex = 5;
            this.lstMape.SelectedIndexChanged += new System.EventHandler(this.lstMape_SelectedIndexChanged);
            // 
            // lstDat
            // 
            this.lstDat.FormattingEnabled = true;
            this.lstDat.ItemHeight = 25;
            this.lstDat.Location = new System.Drawing.Point(24, 127);
            this.lstDat.Name = "lstDat";
            this.lstDat.Size = new System.Drawing.Size(209, 329);
            this.lstDat.TabIndex = 4;
            this.lstDat.SelectedIndexChanged += new System.EventHandler(this.lstDat_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mape";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Datoteke";
            // 
            // btnGor
            // 
            this.btnGor.Location = new System.Drawing.Point(422, 31);
            this.btnGor.Name = "btnGor";
            this.btnGor.Size = new System.Drawing.Size(92, 31);
            this.btnGor.TabIndex = 1;
            this.btnGor.Text = "Gor";
            this.btnGor.UseVisualStyleBackColor = true;
            this.btnGor.Click += new System.EventHandler(this.btnGor_Click);
            // 
            // txtMapa
            // 
            this.txtMapa.Location = new System.Drawing.Point(19, 31);
            this.txtMapa.Name = "txtMapa";
            this.txtMapa.ReadOnly = true;
            this.txtMapa.Size = new System.Drawing.Size(341, 31);
            this.txtMapa.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtVelikost);
            this.groupBox2.Controls.Add(this.txtDat);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(33, 493);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(474, 178);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Če je datoteka izbrana";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ime";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Velikost";
            // 
            // txtDat
            // 
            this.txtDat.Location = new System.Drawing.Point(133, 44);
            this.txtDat.Name = "txtDat";
            this.txtDat.ReadOnly = true;
            this.txtDat.Size = new System.Drawing.Size(218, 31);
            this.txtDat.TabIndex = 2;
            // 
            // txtVelikost
            // 
            this.txtVelikost.Location = new System.Drawing.Point(133, 85);
            this.txtVelikost.Name = "txtVelikost";
            this.txtVelikost.ReadOnly = true;
            this.txtVelikost.Size = new System.Drawing.Size(218, 31);
            this.txtVelikost.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNovo);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.btnPremakni);
            this.groupBox3.Location = new System.Drawing.Point(33, 704);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(475, 133);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Premikanje, kopiranje, brisanje";
            // 
            // btnPremakni
            // 
            this.btnPremakni.Location = new System.Drawing.Point(17, 44);
            this.btnPremakni.Name = "btnPremakni";
            this.btnPremakni.Size = new System.Drawing.Size(138, 30);
            this.btnPremakni.TabIndex = 0;
            this.btnPremakni.Text = "Premakni....";
            this.btnPremakni.UseVisualStyleBackColor = true;
            this.btnPremakni.Click += new System.EventHandler(this.btnPremakni_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(161, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "Kopiraj...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(305, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 30);
            this.button3.TabIndex = 2;
            this.button3.Text = "Briši";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nova lokacija";
            // 
            // txtNovo
            // 
            this.txtNovo.Location = new System.Drawing.Point(161, 88);
            this.txtNovo.Name = "txtNovo";
            this.txtNovo.Size = new System.Drawing.Size(282, 31);
            this.txtNovo.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 1061);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPrikaži);
            this.Controls.Add(this.txtVnos);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVnos;
        private System.Windows.Forms.Button btnPrikaži;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstMape;
        private System.Windows.Forms.ListBox lstDat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGor;
        private System.Windows.Forms.TextBox txtMapa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtVelikost;
        private System.Windows.Forms.TextBox txtDat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNovo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPremakni;
    }
}

