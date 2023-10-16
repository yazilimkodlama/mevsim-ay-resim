namespace mevsim_1
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
            this.cmbMevsimler = new System.Windows.Forms.ComboBox();
            this.lstAylar = new System.Windows.Forms.ListBox();
            this.cmbAylar = new System.Windows.Forms.ComboBox();
            this.lblMevsim = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMevsimler
            // 
            this.cmbMevsimler.FormattingEnabled = true;
            this.cmbMevsimler.Items.AddRange(new object[] {
            "İlkbahar",
            "Yaz",
            "Sonbahar",
            "Kış"});
            this.cmbMevsimler.Location = new System.Drawing.Point(80, 57);
            this.cmbMevsimler.Name = "cmbMevsimler";
            this.cmbMevsimler.Size = new System.Drawing.Size(209, 32);
            this.cmbMevsimler.TabIndex = 0;
            this.cmbMevsimler.SelectedIndexChanged += new System.EventHandler(this.cmbMevsimler_SelectedIndexChanged);
            // 
            // lstAylar
            // 
            this.lstAylar.FormattingEnabled = true;
            this.lstAylar.ItemHeight = 24;
            this.lstAylar.Location = new System.Drawing.Point(295, 57);
            this.lstAylar.Name = "lstAylar";
            this.lstAylar.Size = new System.Drawing.Size(194, 196);
            this.lstAylar.TabIndex = 1;
            // 
            // cmbAylar
            // 
            this.cmbAylar.FormattingEnabled = true;
            this.cmbAylar.Items.AddRange(new object[] {
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık"});
            this.cmbAylar.Location = new System.Drawing.Point(568, 57);
            this.cmbAylar.Name = "cmbAylar";
            this.cmbAylar.Size = new System.Drawing.Size(209, 32);
            this.cmbAylar.TabIndex = 2;
            this.cmbAylar.SelectedIndexChanged += new System.EventHandler(this.cmbAylar_SelectedIndexChanged);
            // 
            // lblMevsim
            // 
            this.lblMevsim.AutoSize = true;
            this.lblMevsim.Location = new System.Drawing.Point(907, 60);
            this.lblMevsim.Name = "lblMevsim";
            this.lblMevsim.Size = new System.Drawing.Size(60, 24);
            this.lblMevsim.TabIndex = 3;
            this.lblMevsim.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(800, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 475);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMevsim);
            this.Controls.Add(this.cmbAylar);
            this.Controls.Add(this.lstAylar);
            this.Controls.Add(this.cmbMevsimler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMevsimler;
        private System.Windows.Forms.ListBox lstAylar;
        private System.Windows.Forms.ComboBox cmbAylar;
        private System.Windows.Forms.Label lblMevsim;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

