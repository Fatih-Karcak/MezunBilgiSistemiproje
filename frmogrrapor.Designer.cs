namespace mezunbilgisistemi_proje_ödevi_
{
    partial class frmogrrapor
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnturkiyedoktora = new System.Windows.Forms.Button();
            this.btnyurtdısıdoktora = new System.Windows.Forms.Button();
            this.btnyukseklisans = new System.Windows.Forms.Button();
            this.btnturkiyeyukseklisans = new System.Windows.Forms.Button();
            this.btnyurtdısıyukseklisans = new System.Windows.Forms.Button();
            this.btn35yil = new System.Windows.Forms.Button();
            this.btn10yil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(321, 68);
            this.button1.TabIndex = 0;
            this.button1.Text = "Doktora Yapanları listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnturkiyedoktora
            // 
            this.btnturkiyedoktora.Location = new System.Drawing.Point(21, 170);
            this.btnturkiyedoktora.Name = "btnturkiyedoktora";
            this.btnturkiyedoktora.Size = new System.Drawing.Size(321, 62);
            this.btnturkiyedoktora.TabIndex = 1;
            this.btnturkiyedoktora.Text = "Türkiyede doktora yapanları listele";
            this.btnturkiyedoktora.UseVisualStyleBackColor = true;
            this.btnturkiyedoktora.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnyurtdısıdoktora
            // 
            this.btnyurtdısıdoktora.Location = new System.Drawing.Point(21, 266);
            this.btnyurtdısıdoktora.Name = "btnyurtdısıdoktora";
            this.btnyurtdısıdoktora.Size = new System.Drawing.Size(321, 50);
            this.btnyurtdısıdoktora.TabIndex = 2;
            this.btnyurtdısıdoktora.Text = "yurtdışında doktora yapanları listele";
            this.btnyurtdısıdoktora.UseVisualStyleBackColor = true;
            this.btnyurtdısıdoktora.Click += new System.EventHandler(this.btnyurtdısıdoktora_Click);
            // 
            // btnyukseklisans
            // 
            this.btnyukseklisans.Location = new System.Drawing.Point(21, 366);
            this.btnyukseklisans.Name = "btnyukseklisans";
            this.btnyukseklisans.Size = new System.Drawing.Size(321, 52);
            this.btnyukseklisans.TabIndex = 3;
            this.btnyukseklisans.Text = "yükseklisans yapanları listele";
            this.btnyukseklisans.UseVisualStyleBackColor = true;
            this.btnyukseklisans.Click += new System.EventHandler(this.btnyukseklisans_Click);
            // 
            // btnturkiyeyukseklisans
            // 
            this.btnturkiyeyukseklisans.Location = new System.Drawing.Point(21, 455);
            this.btnturkiyeyukseklisans.Name = "btnturkiyeyukseklisans";
            this.btnturkiyeyukseklisans.Size = new System.Drawing.Size(321, 57);
            this.btnturkiyeyukseklisans.TabIndex = 4;
            this.btnturkiyeyukseklisans.Text = "Türkiyede Yüksek lisans yapanları listele";
            this.btnturkiyeyukseklisans.UseVisualStyleBackColor = true;
            this.btnturkiyeyukseklisans.Click += new System.EventHandler(this.btnturkiyeyukseklisans_Click);
            // 
            // btnyurtdısıyukseklisans
            // 
            this.btnyurtdısıyukseklisans.Location = new System.Drawing.Point(21, 540);
            this.btnyurtdısıyukseklisans.Name = "btnyurtdısıyukseklisans";
            this.btnyurtdısıyukseklisans.Size = new System.Drawing.Size(321, 60);
            this.btnyurtdısıyukseklisans.TabIndex = 5;
            this.btnyurtdısıyukseklisans.Text = "yurtdışında yüksek lisans yapanları listele";
            this.btnyurtdısıyukseklisans.UseVisualStyleBackColor = true;
            this.btnyurtdısıyukseklisans.Click += new System.EventHandler(this.btnyurtdısıyukseklisans_Click);
            // 
            // btn35yil
            // 
            this.btn35yil.Location = new System.Drawing.Point(379, 58);
            this.btn35yil.Name = "btn35yil";
            this.btn35yil.Size = new System.Drawing.Size(307, 68);
            this.btn35yil.TabIndex = 6;
            this.btn35yil.Text = "Mezuniyetinin ardından 3-5 yıl arası işe girenler";
            this.btn35yil.UseVisualStyleBackColor = true;
            this.btn35yil.Click += new System.EventHandler(this.btn35yil_Click);
            // 
            // btn10yil
            // 
            this.btn10yil.Location = new System.Drawing.Point(379, 170);
            this.btn10yil.Name = "btn10yil";
            this.btn10yil.Size = new System.Drawing.Size(307, 62);
            this.btn10yil.TabIndex = 7;
            this.btn10yil.Text = "10 yıl içinde yönetici olanlar";
            this.btn10yil.UseVisualStyleBackColor = true;
            this.btn10yil.Click += new System.EventHandler(this.btn10yil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(390, 268);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(848, 427);
            this.dataGridView1.TabIndex = 8;
            // 
            // frmogrrapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 726);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn10yil);
            this.Controls.Add(this.btn35yil);
            this.Controls.Add(this.btnyurtdısıyukseklisans);
            this.Controls.Add(this.btnturkiyeyukseklisans);
            this.Controls.Add(this.btnyukseklisans);
            this.Controls.Add(this.btnyurtdısıdoktora);
            this.Controls.Add(this.btnturkiyedoktora);
            this.Controls.Add(this.button1);
            this.Name = "frmogrrapor";
            this.Text = "frmogrrapor";
            this.Load += new System.EventHandler(this.frmogrrapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnturkiyedoktora;
        private System.Windows.Forms.Button btnyurtdısıdoktora;
        private System.Windows.Forms.Button btnyukseklisans;
        private System.Windows.Forms.Button btnturkiyeyukseklisans;
        private System.Windows.Forms.Button btnyurtdısıyukseklisans;
        private System.Windows.Forms.Button btn35yil;
        private System.Windows.Forms.Button btn10yil;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}