namespace Izpit3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radUSD = new System.Windows.Forms.RadioButton();
            this.radJPY = new System.Windows.Forms.RadioButton();
            this.radGBP = new System.Windows.Forms.RadioButton();
            this.txtEUR = new System.Windows.Forms.TextBox();
            this.txtR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labR = new System.Windows.Forms.Label();
            this.btnIzračunaj = new System.Windows.Forms.Button();
            this.btnPOčisti = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radGBP);
            this.groupBox1.Controls.Add(this.radJPY);
            this.groupBox1.Controls.Add(this.radUSD);
            this.groupBox1.Location = new System.Drawing.Point(51, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tečaji";
            // 
            // radUSD
            // 
            this.radUSD.AutoSize = true;
            this.radUSD.Checked = true;
            this.radUSD.Location = new System.Drawing.Point(29, 44);
            this.radUSD.Name = "radUSD";
            this.radUSD.Size = new System.Drawing.Size(66, 28);
            this.radUSD.TabIndex = 0;
            this.radUSD.TabStop = true;
            this.radUSD.Text = "USD";
            this.radUSD.UseVisualStyleBackColor = true;
            this.radUSD.CheckedChanged += new System.EventHandler(this.radUSD_CheckedChanged);
            // 
            // radJPY
            // 
            this.radJPY.AutoSize = true;
            this.radJPY.Location = new System.Drawing.Point(29, 78);
            this.radJPY.Name = "radJPY";
            this.radJPY.Size = new System.Drawing.Size(61, 28);
            this.radJPY.TabIndex = 1;
            this.radJPY.Text = "JPY";
            this.radJPY.UseVisualStyleBackColor = true;
            this.radJPY.CheckedChanged += new System.EventHandler(this.radJPY_CheckedChanged);
            // 
            // radGBP
            // 
            this.radGBP.AutoSize = true;
            this.radGBP.Location = new System.Drawing.Point(29, 112);
            this.radGBP.Name = "radGBP";
            this.radGBP.Size = new System.Drawing.Size(66, 28);
            this.radGBP.TabIndex = 2;
            this.radGBP.Text = "GBP";
            this.radGBP.UseVisualStyleBackColor = true;
            this.radGBP.CheckedChanged += new System.EventHandler(this.radGBP_CheckedChanged);
            // 
            // txtEUR
            // 
            this.txtEUR.Location = new System.Drawing.Point(403, 97);
            this.txtEUR.Name = "txtEUR";
            this.txtEUR.Size = new System.Drawing.Size(100, 29);
            this.txtEUR.TabIndex = 1;
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(403, 155);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(100, 29);
            this.txtR.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(544, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "EUR";
            // 
            // labR
            // 
            this.labR.AutoSize = true;
            this.labR.Location = new System.Drawing.Point(544, 157);
            this.labR.Name = "labR";
            this.labR.Size = new System.Drawing.Size(48, 24);
            this.labR.TabIndex = 4;
            this.labR.Text = "USD";
            // 
            // btnIzračunaj
            // 
            this.btnIzračunaj.Location = new System.Drawing.Point(51, 274);
            this.btnIzračunaj.Name = "btnIzračunaj";
            this.btnIzračunaj.Size = new System.Drawing.Size(192, 44);
            this.btnIzračunaj.TabIndex = 5;
            this.btnIzračunaj.Text = "Izračunaj";
            this.btnIzračunaj.UseVisualStyleBackColor = true;
            this.btnIzračunaj.Click += new System.EventHandler(this.btnIzračunaj_Click);
            // 
            // btnPOčisti
            // 
            this.btnPOčisti.Location = new System.Drawing.Point(388, 274);
            this.btnPOčisti.Name = "btnPOčisti";
            this.btnPOčisti.Size = new System.Drawing.Size(192, 44);
            this.btnPOčisti.TabIndex = 6;
            this.btnPOčisti.Text = "Počisti";
            this.btnPOčisti.UseVisualStyleBackColor = true;
            this.btnPOčisti.Click += new System.EventHandler(this.btnPOčisti_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 362);
            this.Controls.Add(this.btnPOčisti);
            this.Controls.Add(this.btnIzračunaj);
            this.Controls.Add(this.labR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.txtEUR);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Tečajna lista";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radGBP;
        private System.Windows.Forms.RadioButton radJPY;
        private System.Windows.Forms.RadioButton radUSD;
        private System.Windows.Forms.TextBox txtEUR;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labR;
        private System.Windows.Forms.Button btnIzračunaj;
        private System.Windows.Forms.Button btnPOčisti;
    }
}

