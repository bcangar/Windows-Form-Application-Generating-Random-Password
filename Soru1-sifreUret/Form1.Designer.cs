namespace Soru1_sifreUret
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
            this.chkKucukH = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkBuyukH = new System.Windows.Forms.CheckBox();
            this.chkRakam = new System.Windows.Forms.CheckBox();
            this.chkOzel = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nudSifreSayi = new System.Windows.Forms.NumericUpDown();
            this.nudSifreeUzunluk = new System.Windows.Forms.NumericUpDown();
            this.btnUret = new System.Windows.Forms.Button();
            this.txtSifreler = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreSayi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreeUzunluk)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 221);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şifre Sayısı:";
            // 
            // chkKucukH
            // 
            this.chkKucukH.AutoSize = true;
            this.chkKucukH.Location = new System.Drawing.Point(98, 64);
            this.chkKucukH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkKucukH.Name = "chkKucukH";
            this.chkKucukH.Size = new System.Drawing.Size(107, 24);
            this.chkKucukH.TabIndex = 2;
            this.chkKucukH.Text = "Küçük Harf";
            this.chkKucukH.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parametreler";
            // 
            // chkBuyukH
            // 
            this.chkBuyukH.AutoSize = true;
            this.chkBuyukH.Location = new System.Drawing.Point(98, 98);
            this.chkBuyukH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkBuyukH.Name = "chkBuyukH";
            this.chkBuyukH.Size = new System.Drawing.Size(107, 24);
            this.chkBuyukH.TabIndex = 2;
            this.chkBuyukH.Text = "Büyük Harf";
            this.chkBuyukH.UseVisualStyleBackColor = true;
            // 
            // chkRakam
            // 
            this.chkRakam.AutoSize = true;
            this.chkRakam.Location = new System.Drawing.Point(98, 132);
            this.chkRakam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkRakam.Name = "chkRakam";
            this.chkRakam.Size = new System.Drawing.Size(79, 24);
            this.chkRakam.TabIndex = 2;
            this.chkRakam.Text = "Rakam";
            this.chkRakam.UseVisualStyleBackColor = true;
            // 
            // chkOzel
            // 
            this.chkOzel.AutoSize = true;
            this.chkOzel.Location = new System.Drawing.Point(98, 159);
            this.chkOzel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkOzel.Name = "chkOzel";
            this.chkOzel.Size = new System.Drawing.Size(124, 24);
            this.chkOzel.TabIndex = 2;
            this.chkOzel.Text = "Özel Karakter";
            this.chkOzel.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 252);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Şifre Uzunluğu:";
            // 
            // nudSifreSayi
            // 
            this.nudSifreSayi.Location = new System.Drawing.Point(167, 214);
            this.nudSifreSayi.Name = "nudSifreSayi";
            this.nudSifreSayi.Size = new System.Drawing.Size(120, 26);
            this.nudSifreSayi.TabIndex = 4;
            // 
            // nudSifreeUzunluk
            // 
            this.nudSifreeUzunluk.Location = new System.Drawing.Point(167, 246);
            this.nudSifreeUzunluk.Name = "nudSifreeUzunluk";
            this.nudSifreeUzunluk.Size = new System.Drawing.Size(120, 26);
            this.nudSifreeUzunluk.TabIndex = 4;
            // 
            // btnUret
            // 
            this.btnUret.Location = new System.Drawing.Point(186, 295);
            this.btnUret.Name = "btnUret";
            this.btnUret.Size = new System.Drawing.Size(101, 35);
            this.btnUret.TabIndex = 5;
            this.btnUret.Text = "Üret";
            this.btnUret.UseVisualStyleBackColor = true;
            this.btnUret.Click += new System.EventHandler(this.btnUret_Click);
            // 
            // txtSifreler
            // 
            this.txtSifreler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSifreler.Location = new System.Drawing.Point(315, 12);
            this.txtSifreler.Multiline = true;
            this.txtSifreler.Name = "txtSifreler";
            this.txtSifreler.ReadOnly = true;
            this.txtSifreler.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSifreler.Size = new System.Drawing.Size(311, 362);
            this.txtSifreler.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(636, 381);
            this.Controls.Add(this.txtSifreler);
            this.Controls.Add(this.btnUret);
            this.Controls.Add(this.nudSifreeUzunluk);
            this.Controls.Add(this.nudSifreSayi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkOzel);
            this.Controls.Add(this.chkRakam);
            this.Controls.Add(this.chkBuyukH);
            this.Controls.Add(this.chkKucukH);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreSayi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreeUzunluk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkKucukH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkBuyukH;
        private System.Windows.Forms.CheckBox chkRakam;
        private System.Windows.Forms.CheckBox chkOzel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudSifreSayi;
        private System.Windows.Forms.NumericUpDown nudSifreeUzunluk;
        private System.Windows.Forms.Button btnUret;
        private System.Windows.Forms.TextBox txtSifreler;
    }
}

