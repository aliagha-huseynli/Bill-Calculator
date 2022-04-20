namespace Fatura_Hesap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txT1 = new System.Windows.Forms.TextBox();
            this.txT2 = new System.Windows.Forms.TextBox();
            this.txT3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblEnerjiFonu = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTOPLAM = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblTRT = new System.Windows.Forms.Label();
            this.lblBTV = new System.Windows.Forms.Label();
            this.lblKDV = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblTuketim = new System.Windows.Forms.Label();
            this.lblDağıtım = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txTekZaman = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(381, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "HESAPLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(215, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fatura Hesapla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(37, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "T1 (Gündüz)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(37, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "T2 (Puant)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(37, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "T3 (Gece)";
            // 
            // txT1
            // 
            this.txT1.Location = new System.Drawing.Point(133, 184);
            this.txT1.Name = "txT1";
            this.txT1.Size = new System.Drawing.Size(133, 20);
            this.txT1.TabIndex = 5;
            // 
            // txT2
            // 
            this.txT2.Location = new System.Drawing.Point(133, 222);
            this.txT2.Name = "txT2";
            this.txT2.Size = new System.Drawing.Size(133, 20);
            this.txT2.TabIndex = 6;
            // 
            // txT3
            // 
            this.txT3.Location = new System.Drawing.Point(133, 257);
            this.txT3.Name = "txT3";
            this.txT3.Size = new System.Drawing.Size(133, 20);
            this.txT3.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(334, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "BTV %5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(334, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "TRT Payı %2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(334, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Enerji Fonu %1";
            // 
            // lblEnerjiFonu
            // 
            this.lblEnerjiFonu.AutoSize = true;
            this.lblEnerjiFonu.Location = new System.Drawing.Point(493, 185);
            this.lblEnerjiFonu.Name = "lblEnerjiFonu";
            this.lblEnerjiFonu.Size = new System.Drawing.Size(29, 13);
            this.lblEnerjiFonu.TabIndex = 11;
            this.lblEnerjiFonu.Text = "...TL";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(334, 273);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "KDV %18";
            // 
            // lblTOPLAM
            // 
            this.lblTOPLAM.AutoSize = true;
            this.lblTOPLAM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTOPLAM.Location = new System.Drawing.Point(279, 382);
            this.lblTOPLAM.Name = "lblTOPLAM";
            this.lblTOPLAM.Size = new System.Drawing.Size(39, 20);
            this.lblTOPLAM.TabIndex = 14;
            this.lblTOPLAM.Text = "...TL";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(115, 382);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 20);
            this.label14.TabIndex = 17;
            this.label14.Text = "Toplam";
            // 
            // lblTRT
            // 
            this.lblTRT.AutoSize = true;
            this.lblTRT.Location = new System.Drawing.Point(493, 219);
            this.lblTRT.Name = "lblTRT";
            this.lblTRT.Size = new System.Drawing.Size(29, 13);
            this.lblTRT.TabIndex = 18;
            this.lblTRT.Text = "...TL";
            // 
            // lblBTV
            // 
            this.lblBTV.AutoSize = true;
            this.lblBTV.Location = new System.Drawing.Point(493, 249);
            this.lblBTV.Name = "lblBTV";
            this.lblBTV.Size = new System.Drawing.Size(29, 13);
            this.lblBTV.TabIndex = 19;
            this.lblBTV.Text = "...TL";
            // 
            // lblKDV
            // 
            this.lblKDV.AutoSize = true;
            this.lblKDV.Location = new System.Drawing.Point(493, 275);
            this.lblKDV.Name = "lblKDV";
            this.lblKDV.Size = new System.Drawing.Size(29, 13);
            this.lblKDV.TabIndex = 20;
            this.lblKDV.Text = "...TL";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(50, 302);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 20);
            this.label15.TabIndex = 21;
            this.label15.Text = "Tüketim";
            // 
            // lblTuketim
            // 
            this.lblTuketim.AutoSize = true;
            this.lblTuketim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTuketim.Location = new System.Drawing.Point(201, 302);
            this.lblTuketim.Name = "lblTuketim";
            this.lblTuketim.Size = new System.Drawing.Size(39, 20);
            this.lblTuketim.TabIndex = 22;
            this.lblTuketim.Text = "...TL";
            // 
            // lblDağıtım
            // 
            this.lblDağıtım.AutoSize = true;
            this.lblDağıtım.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDağıtım.Location = new System.Drawing.Point(201, 335);
            this.lblDağıtım.Name = "lblDağıtım";
            this.lblDağıtım.Size = new System.Drawing.Size(39, 20);
            this.lblDağıtım.TabIndex = 24;
            this.lblDağıtım.Text = "...TL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(50, 335);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Dağıtım";
            // 
            // txTekZaman
            // 
            this.txTekZaman.Location = new System.Drawing.Point(133, 151);
            this.txTekZaman.Name = "txTekZaman";
            this.txTekZaman.Size = new System.Drawing.Size(133, 20);
            this.txTekZaman.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(37, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 15);
            this.label8.TabIndex = 25;
            this.label8.Text = "Tek Zaman";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tek Zaman",
            "Üç Zaman"});
            this.comboBox1.Location = new System.Drawing.Point(133, 102);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 21);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(37, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 15);
            this.label10.TabIndex = 28;
            this.label10.Text = "Paket Türünü:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(592, 477);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txTekZaman);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblDağıtım);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblTuketim);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblKDV);
            this.Controls.Add(this.lblBTV);
            this.Controls.Add(this.lblTRT);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblTOPLAM);
            this.Controls.Add(this.lblEnerjiFonu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txT3);
            this.Controls.Add(this.txT2);
            this.Controls.Add(this.txT1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "FaturaMatik";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txT1;
        private System.Windows.Forms.TextBox txT2;
        private System.Windows.Forms.TextBox txT3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblEnerjiFonu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTOPLAM;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblTRT;
        private System.Windows.Forms.Label lblBTV;
        private System.Windows.Forms.Label lblKDV;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblTuketim;
        private System.Windows.Forms.Label lblDağıtım;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txTekZaman;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
    }
}

