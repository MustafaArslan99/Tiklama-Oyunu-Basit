namespace IdleGame
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
            this.lbl_yazi = new System.Windows.Forms.Label();
            this.btn_basla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_yazi
            // 
            this.lbl_yazi.AutoSize = true;
            this.lbl_yazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yazi.Location = new System.Drawing.Point(111, 54);
            this.lbl_yazi.Name = "lbl_yazi";
            this.lbl_yazi.Size = new System.Drawing.Size(177, 25);
            this.lbl_yazi.TabIndex = 0;
            this.lbl_yazi.Text = "Oyuna Hoşgeldiniz";
            // 
            // btn_basla
            // 
            this.btn_basla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_basla.Location = new System.Drawing.Point(116, 144);
            this.btn_basla.Name = "btn_basla";
            this.btn_basla.Size = new System.Drawing.Size(172, 76);
            this.btn_basla.TabIndex = 1;
            this.btn_basla.Text = "Oyuna Başla";
            this.btn_basla.UseVisualStyleBackColor = true;
            this.btn_basla.Click += new System.EventHandler(this.btn_basla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btn_basla);
            this.Controls.Add(this.lbl_yazi);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_yazi;
        private System.Windows.Forms.Button btn_basla;
    }
}

