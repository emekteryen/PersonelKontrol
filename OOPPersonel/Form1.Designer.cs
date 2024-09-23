namespace OOPPersonel
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
            this.lstPersonel = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.dtpIs = new System.Windows.Forms.DateTimePicker();
            this.dtpDogum = new System.Windows.Forms.DateTimePicker();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGoster = new System.Windows.Forms.Button();
            this.cmbDepartman = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lstPersonel
            // 
            this.lstPersonel.FormattingEnabled = true;
            this.lstPersonel.Location = new System.Drawing.Point(12, 12);
            this.lstPersonel.Name = "lstPersonel";
            this.lstPersonel.Size = new System.Drawing.Size(120, 160);
            this.lstPersonel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(138, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(138, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(138, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Departman:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(138, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ise Giris Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(138, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Dogum Tarihi:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(268, 12);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(150, 20);
            this.txtAd.TabIndex = 6;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(268, 56);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(150, 20);
            this.txtSoyad.TabIndex = 7;
            // 
            // dtpIs
            // 
            this.dtpIs.Location = new System.Drawing.Point(268, 125);
            this.dtpIs.Name = "dtpIs";
            this.dtpIs.Size = new System.Drawing.Size(150, 20);
            this.dtpIs.TabIndex = 9;
            // 
            // dtpDogum
            // 
            this.dtpDogum.Location = new System.Drawing.Point(268, 164);
            this.dtpDogum.Name = "dtpDogum";
            this.dtpDogum.Size = new System.Drawing.Size(150, 20);
            this.dtpDogum.TabIndex = 10;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(143, 212);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(275, 59);
            this.btnEkle.TabIndex = 11;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(424, 12);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(226, 59);
            this.btnGoster.TabIndex = 12;
            this.btnGoster.Text = "Departman Goster";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // cmbDepartman
            // 
            this.cmbDepartman.FormattingEnabled = true;
            this.cmbDepartman.Items.AddRange(new object[] {
            "Yazılım ve Veritabanı",
            "Sistem ve Ag Guvenlik Uzmanlığı",
            "3d Teknik",
            "Teknik Ekip",
            "Yazılım Muh."});
            this.cmbDepartman.Location = new System.Drawing.Point(268, 87);
            this.cmbDepartman.Name = "cmbDepartman";
            this.cmbDepartman.Size = new System.Drawing.Size(150, 21);
            this.cmbDepartman.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 348);
            this.Controls.Add(this.cmbDepartman);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dtpDogum);
            this.Controls.Add(this.dtpIs);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstPersonel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPersonel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.DateTimePicker dtpIs;
        private System.Windows.Forms.DateTimePicker dtpDogum;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.ComboBox cmbDepartman;
    }
}

