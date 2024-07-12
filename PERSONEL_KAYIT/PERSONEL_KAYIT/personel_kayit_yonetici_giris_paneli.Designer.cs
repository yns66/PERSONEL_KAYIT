namespace PERSONEL_KAYIT
{
    partial class personel_kayit_yonetici_giris_paneli
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtkullaniciad = new System.Windows.Forms.TextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(654, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "YÖNETİCİ GİRİŞ PANELİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(218, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "ŞİFRE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(88, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "KULLANICI ADI: ";
            // 
            // txtkullaniciad
            // 
            this.txtkullaniciad.Location = new System.Drawing.Point(333, 118);
            this.txtkullaniciad.Name = "txtkullaniciad";
            this.txtkullaniciad.Size = new System.Drawing.Size(210, 38);
            this.txtkullaniciad.TabIndex = 3;
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(333, 174);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(210, 38);
            this.txtsifre.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "GİRİŞ YAP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // personel_kayit_yonetici_giris_paneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(737, 334);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txtkullaniciad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "personel_kayit_yonetici_giris_paneli";
            this.Text = "personel_kayit_yonetici_giris_paneli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtkullaniciad;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Button button1;
    }
}