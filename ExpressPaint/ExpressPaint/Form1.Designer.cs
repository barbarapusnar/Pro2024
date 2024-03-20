namespace ExpressPaint
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.datotekaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odpriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shraniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.izhodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vrtenjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.za90ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.za180ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.za270ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zrcaljenjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navpičnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vodoravnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posvetliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.potemniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negativToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgOdpri = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tiskanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.natisniSlikoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(764, 529);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(747, 24);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 529);
            this.vScrollBar1.TabIndex = 1;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hScrollBar1.Location = new System.Drawing.Point(0, 536);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(747, 17);
            this.hScrollBar1.TabIndex = 2;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datotekaToolStripMenuItem,
            this.vrtenjeToolStripMenuItem,
            this.zrcaljenjeToolStripMenuItem,
            this.filtriToolStripMenuItem,
            this.tiskanjeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(764, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // datotekaToolStripMenuItem
            // 
            this.datotekaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odpriToolStripMenuItem,
            this.shraniToolStripMenuItem,
            this.toolStripSeparator1,
            this.izhodToolStripMenuItem});
            this.datotekaToolStripMenuItem.Name = "datotekaToolStripMenuItem";
            this.datotekaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.datotekaToolStripMenuItem.Text = "Datoteka";
            // 
            // odpriToolStripMenuItem
            // 
            this.odpriToolStripMenuItem.Name = "odpriToolStripMenuItem";
            this.odpriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.odpriToolStripMenuItem.Text = "Odpri";
            this.odpriToolStripMenuItem.Click += new System.EventHandler(this.odpriToolStripMenuItem_Click);
            // 
            // shraniToolStripMenuItem
            // 
            this.shraniToolStripMenuItem.Name = "shraniToolStripMenuItem";
            this.shraniToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.shraniToolStripMenuItem.Text = "Shrani";
            this.shraniToolStripMenuItem.Click += new System.EventHandler(this.shraniToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // izhodToolStripMenuItem
            // 
            this.izhodToolStripMenuItem.Name = "izhodToolStripMenuItem";
            this.izhodToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.izhodToolStripMenuItem.Text = "Izhod";
            // 
            // vrtenjeToolStripMenuItem
            // 
            this.vrtenjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.za90ToolStripMenuItem,
            this.za180ToolStripMenuItem,
            this.za270ToolStripMenuItem});
            this.vrtenjeToolStripMenuItem.Name = "vrtenjeToolStripMenuItem";
            this.vrtenjeToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.vrtenjeToolStripMenuItem.Text = "Vrtenje";
            // 
            // za90ToolStripMenuItem
            // 
            this.za90ToolStripMenuItem.Name = "za90ToolStripMenuItem";
            this.za90ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.za90ToolStripMenuItem.Text = "Za 90°";
            this.za90ToolStripMenuItem.Click += new System.EventHandler(this.za90ToolStripMenuItem_Click);
            // 
            // za180ToolStripMenuItem
            // 
            this.za180ToolStripMenuItem.Name = "za180ToolStripMenuItem";
            this.za180ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.za180ToolStripMenuItem.Text = "Za 180°";
            // 
            // za270ToolStripMenuItem
            // 
            this.za270ToolStripMenuItem.Name = "za270ToolStripMenuItem";
            this.za270ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.za270ToolStripMenuItem.Text = "Za 270°";
            // 
            // zrcaljenjeToolStripMenuItem
            // 
            this.zrcaljenjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navpičnoToolStripMenuItem,
            this.vodoravnoToolStripMenuItem});
            this.zrcaljenjeToolStripMenuItem.Name = "zrcaljenjeToolStripMenuItem";
            this.zrcaljenjeToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.zrcaljenjeToolStripMenuItem.Text = "Zrcaljenje";
            // 
            // navpičnoToolStripMenuItem
            // 
            this.navpičnoToolStripMenuItem.Name = "navpičnoToolStripMenuItem";
            this.navpičnoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.navpičnoToolStripMenuItem.Text = "Navpično";
            this.navpičnoToolStripMenuItem.Click += new System.EventHandler(this.navpičnoToolStripMenuItem_Click);
            // 
            // vodoravnoToolStripMenuItem
            // 
            this.vodoravnoToolStripMenuItem.Name = "vodoravnoToolStripMenuItem";
            this.vodoravnoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vodoravnoToolStripMenuItem.Text = "Vodoravno";
            // 
            // filtriToolStripMenuItem
            // 
            this.filtriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.posvetliToolStripMenuItem,
            this.potemniToolStripMenuItem,
            this.negativToolStripMenuItem});
            this.filtriToolStripMenuItem.Name = "filtriToolStripMenuItem";
            this.filtriToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.filtriToolStripMenuItem.Text = "Filtri";
            // 
            // posvetliToolStripMenuItem
            // 
            this.posvetliToolStripMenuItem.Name = "posvetliToolStripMenuItem";
            this.posvetliToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.posvetliToolStripMenuItem.Text = "Posvetli";
            // 
            // potemniToolStripMenuItem
            // 
            this.potemniToolStripMenuItem.Name = "potemniToolStripMenuItem";
            this.potemniToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.potemniToolStripMenuItem.Text = "Potemni";
            // 
            // negativToolStripMenuItem
            // 
            this.negativToolStripMenuItem.Name = "negativToolStripMenuItem";
            this.negativToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.negativToolStripMenuItem.Text = "Negativ";
            this.negativToolStripMenuItem.Click += new System.EventHandler(this.negativToolStripMenuItem_Click);
            // 
            // dlgOdpri
            // 
            this.dlgOdpri.FileName = "openFileDialog";
            // 
            // tiskanjeToolStripMenuItem
            // 
            this.tiskanjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.natisniSlikoToolStripMenuItem});
            this.tiskanjeToolStripMenuItem.Name = "tiskanjeToolStripMenuItem";
            this.tiskanjeToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.tiskanjeToolStripMenuItem.Text = "Tiskanje";
            // 
            // natisniSlikoToolStripMenuItem
            // 
            this.natisniSlikoToolStripMenuItem.Name = "natisniSlikoToolStripMenuItem";
            this.natisniSlikoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.natisniSlikoToolStripMenuItem.Text = "Natisni sliko";
            this.natisniSlikoToolStripMenuItem.Click += new System.EventHandler(this.natisniSlikoToolStripMenuItem_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 553);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datotekaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odpriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shraniToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem izhodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vrtenjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem za90ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem za180ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem za270ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zrcaljenjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem navpičnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vodoravnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem posvetliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem potemniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negativToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog dlgOdpri;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem tiskanjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem natisniSlikoToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

