namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kaydetbutton = new System.Windows.Forms.Button();
            this.Yükseklik = new System.Windows.Forms.Label();
            this.Genişlik = new System.Windows.Forms.Label();
            this.yuksekliktextBox = new System.Windows.Forms.TextBox();
            this.genliktextBox = new System.Windows.Forms.TextBox();
            this.formatcomboBox = new System.Windows.Forms.ComboBox();
            this.yuklebutton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.stopbutton = new System.Windows.Forms.Button();
            this.oynatbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // kaydetbutton
            // 
            this.kaydetbutton.Location = new System.Drawing.Point(916, 47);
            this.kaydetbutton.Name = "kaydetbutton";
            this.kaydetbutton.Size = new System.Drawing.Size(189, 30);
            this.kaydetbutton.TabIndex = 0;
            this.kaydetbutton.Text = "Kaydet";
            this.kaydetbutton.UseVisualStyleBackColor = true;
            this.kaydetbutton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.kaydetbutton_MouseClick);
            // 
            // Yükseklik
            // 
            this.Yükseklik.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Yükseklik.Location = new System.Drawing.Point(270, 51);
            this.Yükseklik.Name = "Yükseklik";
            this.Yükseklik.Size = new System.Drawing.Size(91, 22);
            this.Yükseklik.TabIndex = 1;
            this.Yükseklik.Text = "Yükseklik";
            // 
            // Genişlik
            // 
            this.Genişlik.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Genişlik.Location = new System.Drawing.Point(12, 52);
            this.Genişlik.Name = "Genişlik";
            this.Genişlik.Size = new System.Drawing.Size(114, 20);
            this.Genişlik.TabIndex = 2;
            this.Genişlik.Text = "Genişlik";
            // 
            // yuksekliktextBox
            // 
            this.yuksekliktextBox.Location = new System.Drawing.Point(379, 50);
            this.yuksekliktextBox.Name = "yuksekliktextBox";
            this.yuksekliktextBox.Size = new System.Drawing.Size(126, 22);
            this.yuksekliktextBox.TabIndex = 3;
            // 
            // genliktextBox
            // 
            this.genliktextBox.Location = new System.Drawing.Point(141, 51);
            this.genliktextBox.Name = "genliktextBox";
            this.genliktextBox.Size = new System.Drawing.Size(114, 22);
            this.genliktextBox.TabIndex = 4;
            // 
            // formatcomboBox
            // 
            this.formatcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.formatcomboBox.FormattingEnabled = true;
            this.formatcomboBox.Items.AddRange(new object[] {
            "4:4:4",
            "4:2:2",
            "4:2:0"});
            this.formatcomboBox.Location = new System.Drawing.Point(536, 49);
            this.formatcomboBox.Name = "formatcomboBox";
            this.formatcomboBox.Size = new System.Drawing.Size(159, 24);
            this.formatcomboBox.TabIndex = 5;
            // 
            // yuklebutton
            // 
            this.yuklebutton.Location = new System.Drawing.Point(719, 47);
            this.yuklebutton.Name = "yuklebutton";
            this.yuklebutton.Size = new System.Drawing.Size(168, 27);
            this.yuklebutton.TabIndex = 6;
            this.yuklebutton.Text = "Dosya Yükle";
            this.yuklebutton.UseVisualStyleBackColor = true;
            this.yuklebutton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.yuklebutton_MouseClick);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox.Location = new System.Drawing.Point(32, 140);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1073, 627);
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // stopbutton
            // 
            this.stopbutton.Location = new System.Drawing.Point(916, 93);
            this.stopbutton.Name = "stopbutton";
            this.stopbutton.Size = new System.Drawing.Size(189, 30);
            this.stopbutton.TabIndex = 8;
            this.stopbutton.Text = "Durdur";
            this.stopbutton.UseVisualStyleBackColor = true;
            this.stopbutton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.stopbutton_MouseClick);
            // 
            // oynatbutton
            // 
            this.oynatbutton.Location = new System.Drawing.Point(719, 93);
            this.oynatbutton.Name = "oynatbutton";
            this.oynatbutton.Size = new System.Drawing.Size(168, 27);
            this.oynatbutton.TabIndex = 9;
            this.oynatbutton.Text = "Oynat";
            this.oynatbutton.UseVisualStyleBackColor = true;
            this.oynatbutton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.oynatbutton_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1192, 779);
            this.Controls.Add(this.oynatbutton);
            this.Controls.Add(this.stopbutton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.yuklebutton);
            this.Controls.Add(this.formatcomboBox);
            this.Controls.Add(this.kaydetbutton);
            this.Controls.Add(this.genliktextBox);
            this.Controls.Add(this.yuksekliktextBox);
            this.Controls.Add(this.Genişlik);
            this.Controls.Add(this.Yükseklik);
            this.Name = "Form1";
            this.Text = "YUV TO RGB";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kaydetbutton;
        private System.Windows.Forms.Label Yükseklik;
        private System.Windows.Forms.Label Genişlik;
        private System.Windows.Forms.TextBox genliktextBox;
        private System.Windows.Forms.TextBox yuksekliktextBox;
        private System.Windows.Forms.ComboBox formatcomboBox;
        private System.Windows.Forms.Button yuklebutton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button stopbutton;
        private System.Windows.Forms.Button oynatbutton;
    }
}

