namespace TezNTVHaberCekme
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
            this.haberal = new System.Windows.Forms.Button();
            this.haberler = new System.Windows.Forms.ListBox();
            this.linkBox = new System.Windows.Forms.ListBox();
            this.newsBox = new System.Windows.Forms.ListBox();
            this.headBox = new System.Windows.Forms.ListBox();
            this.dbKaydet = new System.Windows.Forms.Button();
            this.veriGet = new System.Windows.Forms.Button();
            this.listHaber = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.listHaber)).BeginInit();
            this.SuspendLayout();
            // 
            // haberal
            // 
            this.haberal.Location = new System.Drawing.Point(155, 678);
            this.haberal.Name = "haberal";
            this.haberal.Size = new System.Drawing.Size(253, 29);
            this.haberal.TabIndex = 0;
            this.haberal.Text = "Haber Al";
            this.haberal.UseVisualStyleBackColor = true;
            this.haberal.Click += new System.EventHandler(this.haberal_Click);
            // 
            // haberler
            // 
            this.haberler.FormattingEnabled = true;
            this.haberler.Location = new System.Drawing.Point(12, 12);
            this.haberler.Name = "haberler";
            this.haberler.Size = new System.Drawing.Size(536, 186);
            this.haberler.TabIndex = 1;
            this.haberler.SelectedIndexChanged += new System.EventHandler(this.haberler_SelectedIndexChanged);
            // 
            // linkBox
            // 
            this.linkBox.FormattingEnabled = true;
            this.linkBox.Location = new System.Drawing.Point(12, 204);
            this.linkBox.Name = "linkBox";
            this.linkBox.Size = new System.Drawing.Size(536, 173);
            this.linkBox.TabIndex = 2;
            // 
            // newsBox
            // 
            this.newsBox.FormattingEnabled = true;
            this.newsBox.Location = new System.Drawing.Point(554, 12);
            this.newsBox.Name = "newsBox";
            this.newsBox.Size = new System.Drawing.Size(491, 186);
            this.newsBox.TabIndex = 3;
            // 
            // headBox
            // 
            this.headBox.FormattingEnabled = true;
            this.headBox.Location = new System.Drawing.Point(554, 204);
            this.headBox.Name = "headBox";
            this.headBox.Size = new System.Drawing.Size(491, 173);
            this.headBox.TabIndex = 4;
            // 
            // dbKaydet
            // 
            this.dbKaydet.Location = new System.Drawing.Point(427, 679);
            this.dbKaydet.Name = "dbKaydet";
            this.dbKaydet.Size = new System.Drawing.Size(221, 28);
            this.dbKaydet.TabIndex = 5;
            this.dbKaydet.Text = "Veritabanına Kaydet";
            this.dbKaydet.UseVisualStyleBackColor = true;
            this.dbKaydet.Click += new System.EventHandler(this.dbKaydet_Click);
            // 
            // veriGet
            // 
            this.veriGet.Location = new System.Drawing.Point(691, 679);
            this.veriGet.Name = "veriGet";
            this.veriGet.Size = new System.Drawing.Size(221, 28);
            this.veriGet.TabIndex = 7;
            this.veriGet.Text = "Veritabanından Verileri Getir";
            this.veriGet.UseVisualStyleBackColor = true;
            this.veriGet.Click += new System.EventHandler(this.veriGet_Click);
            // 
            // listHaber
            // 
            this.listHaber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listHaber.Location = new System.Drawing.Point(12, 383);
            this.listHaber.Name = "listHaber";
            this.listHaber.Size = new System.Drawing.Size(1033, 262);
            this.listHaber.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 741);
            this.Controls.Add(this.listHaber);
            this.Controls.Add(this.veriGet);
            this.Controls.Add(this.dbKaydet);
            this.Controls.Add(this.headBox);
            this.Controls.Add(this.newsBox);
            this.Controls.Add(this.linkBox);
            this.Controls.Add(this.haberler);
            this.Controls.Add(this.haberal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listHaber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button haberal;
        private System.Windows.Forms.ListBox haberler;
        private System.Windows.Forms.ListBox linkBox;
        private System.Windows.Forms.ListBox newsBox;
        private System.Windows.Forms.ListBox headBox;
        private System.Windows.Forms.Button dbKaydet;
        private System.Windows.Forms.Button veriGet;
        private System.Windows.Forms.DataGridView listHaber;
    }
}

