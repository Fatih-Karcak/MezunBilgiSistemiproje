namespace mezunbilgisistemi_proje_ödevi_
{
    partial class frmegitimbilgileri
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.txtakademik = new System.Windows.Forms.TextBox();
            this.txtbaslangic = new System.Windows.Forms.TextBox();
            this.txtbitis = new System.Windows.Forms.TextBox();
            this.txtulke = new System.Windows.Forms.TextBox();
            this.txtsehir = new System.Windows.Forms.TextBox();
            this.txtuniversite = new System.Windows.Forms.TextBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnhepsindençık = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(73, 93);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(898, 374);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(374, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Eğitim Bilgileri";
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(402, 486);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(183, 75);
            this.btnkaydet.TabIndex = 3;
            this.btnkaydet.Text = "Kayıtları Güncelle";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // txtakademik
            // 
            this.txtakademik.Location = new System.Drawing.Point(88, 694);
            this.txtakademik.Name = "txtakademik";
            this.txtakademik.Size = new System.Drawing.Size(100, 22);
            this.txtakademik.TabIndex = 4;
            // 
            // txtbaslangic
            // 
            this.txtbaslangic.Location = new System.Drawing.Point(219, 693);
            this.txtbaslangic.Name = "txtbaslangic";
            this.txtbaslangic.Size = new System.Drawing.Size(100, 22);
            this.txtbaslangic.TabIndex = 5;
            // 
            // txtbitis
            // 
            this.txtbitis.Location = new System.Drawing.Point(345, 693);
            this.txtbitis.Name = "txtbitis";
            this.txtbitis.Size = new System.Drawing.Size(100, 22);
            this.txtbitis.TabIndex = 6;
            // 
            // txtulke
            // 
            this.txtulke.Location = new System.Drawing.Point(466, 693);
            this.txtulke.Name = "txtulke";
            this.txtulke.Size = new System.Drawing.Size(100, 22);
            this.txtulke.TabIndex = 7;
            // 
            // txtsehir
            // 
            this.txtsehir.Location = new System.Drawing.Point(584, 693);
            this.txtsehir.Name = "txtsehir";
            this.txtsehir.Size = new System.Drawing.Size(100, 22);
            this.txtsehir.TabIndex = 8;
            // 
            // txtuniversite
            // 
            this.txtuniversite.Location = new System.Drawing.Point(711, 693);
            this.txtuniversite.Name = "txtuniversite";
            this.txtuniversite.Size = new System.Drawing.Size(100, 22);
            this.txtuniversite.TabIndex = 9;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(849, 672);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(164, 46);
            this.btnekle.TabIndex = 10;
            this.btnekle.Text = "Yeni Kayıt Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 658);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Akademik Eğitim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 658);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Bitiş Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(495, 658);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Ülke";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(610, 658);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Şehir";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(735, 658);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Üniversite";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(216, 658);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Başlangıç Tarihi";
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(695, 486);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(154, 75);
            this.btnsil.TabIndex = 23;
            this.btnsil.Text = "Seçili Kaydı Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnhepsindençık
            // 
            this.btnhepsindençık.Location = new System.Drawing.Point(1024, 564);
            this.btnhepsindençık.Name = "btnhepsindençık";
            this.btnhepsindençık.Size = new System.Drawing.Size(120, 58);
            this.btnhepsindençık.TabIndex = 24;
            this.btnhepsindençık.Text = "Hepsinden Çık";
            this.btnhepsindençık.UseVisualStyleBackColor = true;
            this.btnhepsindençık.Click += new System.EventHandler(this.btnhepsindençık_Click);
            // 
            // frmegitimbilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1528, 863);
            this.Controls.Add(this.btnhepsindençık);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.txtuniversite);
            this.Controls.Add(this.txtsehir);
            this.Controls.Add(this.txtulke);
            this.Controls.Add(this.txtbitis);
            this.Controls.Add(this.txtbaslangic);
            this.Controls.Add(this.txtakademik);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmegitimbilgileri";
            this.Text = "frmegitimbilgileri";
            this.Load += new System.EventHandler(this.frmegitimbilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.TextBox txtakademik;
        private System.Windows.Forms.TextBox txtbaslangic;
        private System.Windows.Forms.TextBox txtbitis;
        private System.Windows.Forms.TextBox txtulke;
        private System.Windows.Forms.TextBox txtsehir;
        private System.Windows.Forms.TextBox txtuniversite;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnhepsindençık;
    }
}