namespace PrvoOkno
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
            this.mojGumb = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrvo = new System.Windows.Forms.TextBox();
            this.txtDrugo = new System.Windows.Forms.TextBox();
            this.txtRezultat = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radPlus = new System.Windows.Forms.RadioButton();
            this.radMinus = new System.Windows.Forms.RadioButton();
            this.radKrat = new System.Windows.Forms.RadioButton();
            this.radDeli = new System.Windows.Forms.RadioButton();
            this.chkNeg = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mojGumb
            // 
            this.mojGumb.Location = new System.Drawing.Point(46, 227);
            this.mojGumb.Name = "mojGumb";
            this.mojGumb.Size = new System.Drawing.Size(142, 61);
            this.mojGumb.TabIndex = 7;
            this.mojGumb.Text = "Izračunaj";
            this.mojGumb.UseVisualStyleBackColor = true;
            this.mojGumb.Click += new System.EventHandler(this.Seštej);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prvo število";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Drugo število";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rezultat";
            // 
            // txtPrvo
            // 
            this.txtPrvo.Location = new System.Drawing.Point(298, 35);
            this.txtPrvo.Name = "txtPrvo";
            this.txtPrvo.Size = new System.Drawing.Size(100, 31);
            this.txtPrvo.TabIndex = 4;
            // 
            // txtDrugo
            // 
            this.txtDrugo.Location = new System.Drawing.Point(298, 92);
            this.txtDrugo.Name = "txtDrugo";
            this.txtDrugo.Size = new System.Drawing.Size(100, 31);
            this.txtDrugo.TabIndex = 5;
            // 
            // txtRezultat
            // 
            this.txtRezultat.Location = new System.Drawing.Point(298, 155);
            this.txtRezultat.Name = "txtRezultat";
            this.txtRezultat.ReadOnly = true;
            this.txtRezultat.Size = new System.Drawing.Size(100, 31);
            this.txtRezultat.TabIndex = 6;
            this.txtRezultat.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 61);
            this.button1.TabIndex = 8;
            this.button1.Text = "Počisti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radDeli);
            this.groupBox1.Controls.Add(this.radKrat);
            this.groupBox1.Controls.Add(this.radMinus);
            this.groupBox1.Controls.Add(this.radPlus);
            this.groupBox1.Location = new System.Drawing.Point(471, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 190);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operacija";
            // 
            // radPlus
            // 
            this.radPlus.AutoSize = true;
            this.radPlus.Checked = true;
            this.radPlus.Location = new System.Drawing.Point(26, 42);
            this.radPlus.Name = "radPlus";
            this.radPlus.Size = new System.Drawing.Size(137, 29);
            this.radPlus.TabIndex = 0;
            this.radPlus.TabStop = true;
            this.radPlus.Text = "Seštevanje";
            this.radPlus.UseVisualStyleBackColor = true;
            // 
            // radMinus
            // 
            this.radMinus.AutoSize = true;
            this.radMinus.Location = new System.Drawing.Point(26, 77);
            this.radMinus.Name = "radMinus";
            this.radMinus.Size = new System.Drawing.Size(139, 29);
            this.radMinus.TabIndex = 1;
            this.radMinus.Text = "Odštevanje";
            this.radMinus.UseVisualStyleBackColor = true;
            // 
            // radKrat
            // 
            this.radKrat.AutoSize = true;
            this.radKrat.Location = new System.Drawing.Point(26, 112);
            this.radKrat.Name = "radKrat";
            this.radKrat.Size = new System.Drawing.Size(124, 29);
            this.radKrat.TabIndex = 2;
            this.radKrat.Text = "Množenje";
            this.radKrat.UseVisualStyleBackColor = true;
            // 
            // radDeli
            // 
            this.radDeli.AutoSize = true;
            this.radDeli.Location = new System.Drawing.Point(26, 147);
            this.radDeli.Name = "radDeli";
            this.radDeli.Size = new System.Drawing.Size(108, 29);
            this.radDeli.TabIndex = 3;
            this.radDeli.Text = "Deljenje";
            this.radDeli.UseVisualStyleBackColor = true;
            // 
            // chkNeg
            // 
            this.chkNeg.AutoSize = true;
            this.chkNeg.Location = new System.Drawing.Point(471, 250);
            this.chkNeg.Name = "chkNeg";
            this.chkNeg.Size = new System.Drawing.Size(214, 54);
            this.chkNeg.TabIndex = 10;
            this.chkNeg.Text = "Pobarvaj, če je \r\nvrednost negativna";
            this.chkNeg.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 312);
            this.Controls.Add(this.chkNeg);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtRezultat);
            this.Controls.Add(this.txtDrugo);
            this.Controls.Add(this.txtPrvo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mojGumb);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Prvo okno";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mojGumb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrvo;
        private System.Windows.Forms.TextBox txtDrugo;
        private System.Windows.Forms.TextBox txtRezultat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radDeli;
        private System.Windows.Forms.RadioButton radKrat;
        private System.Windows.Forms.RadioButton radMinus;
        private System.Windows.Forms.RadioButton radPlus;
        private System.Windows.Forms.CheckBox chkNeg;
    }
}

