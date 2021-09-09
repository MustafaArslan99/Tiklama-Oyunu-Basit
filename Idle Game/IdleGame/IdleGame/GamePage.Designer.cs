namespace IdleGame
{
    partial class GamePage
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_para = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_saniyelikkazanc = new System.Windows.Forms.Label();
            this.btn_item1 = new System.Windows.Forms.Button();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btn_item2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_tiklama1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TimerKontrol = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Para : ";
            // 
            // lbl_para
            // 
            this.lbl_para.AutoSize = true;
            this.lbl_para.Location = new System.Drawing.Point(74, 9);
            this.lbl_para.Name = "lbl_para";
            this.lbl_para.Size = new System.Drawing.Size(13, 13);
            this.lbl_para.TabIndex = 1;
            this.lbl_para.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "+1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Saniyelik kazanç : ";
            // 
            // lbl_saniyelikkazanc
            // 
            this.lbl_saniyelikkazanc.AutoSize = true;
            this.lbl_saniyelikkazanc.Location = new System.Drawing.Point(420, 9);
            this.lbl_saniyelikkazanc.Name = "lbl_saniyelikkazanc";
            this.lbl_saniyelikkazanc.Size = new System.Drawing.Size(13, 13);
            this.lbl_saniyelikkazanc.TabIndex = 4;
            this.lbl_saniyelikkazanc.Text = "0";
            // 
            // btn_item1
            // 
            this.btn_item1.Location = new System.Drawing.Point(136, 110);
            this.btn_item1.Name = "btn_item1";
            this.btn_item1.Size = new System.Drawing.Size(76, 40);
            this.btn_item1.TabIndex = 5;
            this.btn_item1.Text = "25 Para";
            this.btn_item1.UseVisualStyleBackColor = true;
            this.btn_item1.Click += new System.EventHandler(this.btn_item1_Click);
            // 
            // Timer1
            // 
            this.Timer1.Interval = 1000;
            this.Timer1.Tick += new System.EventHandler(this.Buton1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Saniyelik Kazanç +1";
            // 
            // btn_item2
            // 
            this.btn_item2.Location = new System.Drawing.Point(136, 160);
            this.btn_item2.Name = "btn_item2";
            this.btn_item2.Size = new System.Drawing.Size(76, 40);
            this.btn_item2.TabIndex = 5;
            this.btn_item2.Text = "40 Para";
            this.btn_item2.UseVisualStyleBackColor = true;
            this.btn_item2.Click += new System.EventHandler(this.btn_item2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Saniyelik Kazanç +2";
            // 
            // btn_tiklama1
            // 
            this.btn_tiklama1.Location = new System.Drawing.Point(373, 110);
            this.btn_tiklama1.Name = "btn_tiklama1";
            this.btn_tiklama1.Size = new System.Drawing.Size(76, 40);
            this.btn_tiklama1.TabIndex = 5;
            this.btn_tiklama1.Text = "50 Para";
            this.btn_tiklama1.UseVisualStyleBackColor = true;
            this.btn_tiklama1.Click += new System.EventHandler(this.btn_tiklama1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tıklama Kazanç +1";
            // 
            // TimerKontrol
            // 
            this.TimerKontrol.Interval = 10;
            this.TimerKontrol.Tick += new System.EventHandler(this.TimerKontrol_Tick);
            // 
            // GamePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_item2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_tiklama1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_item1);
            this.Controls.Add(this.lbl_saniyelikkazanc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_para);
            this.Controls.Add(this.label1);
            this.Name = "GamePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GamePage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GamePage_FormClosed);
            this.Load += new System.EventHandler(this.GamePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_para;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_saniyelikkazanc;
        private System.Windows.Forms.Button btn_item1;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_item2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_tiklama1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer TimerKontrol;
    }
}