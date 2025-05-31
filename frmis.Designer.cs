namespace mezunbilgisistemi_proje_ödevi_
{
    partial class frmis
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
            this.btnkaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtisegiris = new System.Windows.Forms.TextBox();
            this.txtistenayrilis = new System.Windows.Forms.TextBox();
            this.txtkamuozel = new System.Windows.Forms.TextBox();
            this.txtsektor = new System.Windows.Forms.TextBox();
            this.txtunvan = new System.Windows.Forms.TextBox();
            this.txtpozisyon = new System.Windows.Forms.TextBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnhepsindençık = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnsil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(340, 491);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(183, 75);
            this.btnkaydet.TabIndex = 6;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(378, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 48);
            this.label1.TabIndex = 5;
            this.label1.Text = "İş Bilgileri";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(77, 88);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(898, 374);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtisegiris
            // 
            this.txtisegiris.Location = new System.Drawing.Point(86, 649);
            this.txtisegiris.Name = "txtisegiris";
            this.txtisegiris.Size = new System.Drawing.Size(100, 22);
            this.txtisegiris.TabIndex = 7;
            // 
            // txtistenayrilis
            // 
            this.txtistenayrilis.Location = new System.Drawing.Point(207, 649);
            this.txtistenayrilis.Name = "txtistenayrilis";
            this.txtistenayrilis.Size = new System.Drawing.Size(100, 22);
            this.txtistenayrilis.TabIndex = 8;
            // 
            // txtkamuozel
            // 
            this.txtkamuozel.Location = new System.Drawing.Point(340, 649);
            this.txtkamuozel.Name = "txtkamuozel";
            this.txtkamuozel.Size = new System.Drawing.Size(100, 22);
            this.txtkamuozel.TabIndex = 9;
            // 
            // txtsektor
            // 
            this.txtsektor.Location = new System.Drawing.Point(477, 649);
            this.txtsektor.Name = "txtsektor";
            this.txtsektor.Size = new System.Drawing.Size(100, 22);
            this.txtsektor.TabIndex = 10;
            // 
            // txtunvan
            // 
            this.txtunvan.Location = new System.Drawing.Point(601, 649);
            this.txtunvan.Name = "txtunvan";
            this.txtunvan.Size = new System.Drawing.Size(100, 22);
            this.txtunvan.TabIndex = 11;
            // 
            // txtpozisyon
            // 
            this.txtpozisyon.Location = new System.Drawing.Point(748, 649);
            this.txtpozisyon.Name = "txtpozisyon";
            this.txtpozisyon.Size = new System.Drawing.Size(100, 22);
            this.txtpozisyon.TabIndex = 12;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(900, 644);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(99, 33);
            this.btnekle.TabIndex = 13;
            this.btnekle.Text = "ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnhepsindençık
            // 
            this.btnhepsindençık.Location = new System.Drawing.Point(654, 491);
            this.btnhepsindençık.Name = "btnhepsindençık";
            this.btnhepsindençık.Size = new System.Drawing.Size(194, 75);
            this.btnhepsindençık.TabIndex = 14;
            this.btnhepsindençık.Text = "Hepsinden Çık";
            this.btnhepsindençık.UseVisualStyleBackColor = true;
            this.btnhepsindençık.Click += new System.EventHandler(this.btnhepsindençık_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 614);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "İşe Giriş Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 614);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "İşten Ayrılış Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 613);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "kamu/özel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(501, 614);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Sektör";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(634, 614);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Unvan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(777, 614);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Pozisyon";
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(900, 491);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(111, 49);
            this.btnsil.TabIndex = 21;
            this.btnsil.Text = "Seçili Kaydı Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // frmis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 710);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnhepsindençık);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.txtpozisyon);
            this.Controls.Add(this.txtunvan);
            this.Controls.Add(this.txtsektor);
            this.Controls.Add(this.txtkamuozel);
            this.Controls.Add(this.txtistenayrilis);
            this.Controls.Add(this.txtisegiris);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmis";
            this.Text = "frmis";
            this.Load += new System.EventHandler(this.frmis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtisegiris;
        private System.Windows.Forms.TextBox txtistenayrilis;
        private System.Windows.Forms.TextBox txtkamuozel;
        private System.Windows.Forms.TextBox txtsektor;
        private System.Windows.Forms.TextBox txtunvan;
        private System.Windows.Forms.TextBox txtpozisyon;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnhepsindençık;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnsil;
    }
}