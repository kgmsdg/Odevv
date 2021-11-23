
namespace Nortwind_DB_First
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstCategory = new System.Windows.Forms.ListBox();
            this.lstProduct = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.nUrunFiyati = new System.Windows.Forms.NumericUpDown();
            this.btnProductInsert = new System.Windows.Forms.Button();
            this.bntGncll = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nUrunFiyati)).BeginInit();
            this.SuspendLayout();
            // 
            // lstCategory
            // 
            this.lstCategory.FormattingEnabled = true;
            this.lstCategory.ItemHeight = 20;
            this.lstCategory.Location = new System.Drawing.Point(12, 12);
            this.lstCategory.Name = "lstCategory";
            this.lstCategory.Size = new System.Drawing.Size(293, 604);
            this.lstCategory.TabIndex = 0;
            this.lstCategory.SelectedIndexChanged += new System.EventHandler(this.lstCategory_SelectedIndexChanged);
            // 
            // lstProduct
            // 
            this.lstProduct.FormattingEnabled = true;
            this.lstProduct.ItemHeight = 20;
            this.lstProduct.Location = new System.Drawing.Point(311, 12);
            this.lstProduct.Name = "lstProduct";
            this.lstProduct.Size = new System.Drawing.Size(293, 604);
            this.lstProduct.TabIndex = 1;
            this.lstProduct.SelectedIndexChanged += new System.EventHandler(this.lstProduct_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(610, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(293, 604);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(12, 638);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(125, 27);
            this.txtUrunAdi.TabIndex = 4;
            // 
            // nUrunFiyati
            // 
            this.nUrunFiyati.DecimalPlaces = 2;
            this.nUrunFiyati.Location = new System.Drawing.Point(143, 638);
            this.nUrunFiyati.Name = "nUrunFiyati";
            this.nUrunFiyati.Size = new System.Drawing.Size(150, 27);
            this.nUrunFiyati.TabIndex = 5;
            this.nUrunFiyati.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnProductInsert
            // 
            this.btnProductInsert.Location = new System.Drawing.Point(12, 671);
            this.btnProductInsert.Name = "btnProductInsert";
            this.btnProductInsert.Size = new System.Drawing.Size(125, 54);
            this.btnProductInsert.TabIndex = 6;
            this.btnProductInsert.Text = "Ekle";
            this.btnProductInsert.UseVisualStyleBackColor = true;
            this.btnProductInsert.Click += new System.EventHandler(this.btnProductInsert_Click);
            // 
            // bntGncll
            // 
            this.bntGncll.Location = new System.Drawing.Point(143, 671);
            this.bntGncll.Name = "bntGncll";
            this.bntGncll.Size = new System.Drawing.Size(125, 54);
            this.bntGncll.TabIndex = 8;
            this.bntGncll.Text = "Güncelle";
            this.bntGncll.UseVisualStyleBackColor = true;
            this.bntGncll.Click += new System.EventHandler(this.bntGncll_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(274, 671);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(125, 54);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 750);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.bntGncll);
            this.Controls.Add(this.btnProductInsert);
            this.Controls.Add(this.nUrunFiyati);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lstProduct);
            this.Controls.Add(this.lstCategory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUrunFiyati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCategory;
        private System.Windows.Forms.ListBox lstProduct;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.NumericUpDown nUrunFiyati;
        private System.Windows.Forms.Button btnProductInsert;
        private System.Windows.Forms.Button bntGncll;
        private System.Windows.Forms.Button btnSil;
    }
}

