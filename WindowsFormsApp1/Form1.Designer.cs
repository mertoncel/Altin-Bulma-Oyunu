namespace WindowsFormsApp1
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
            this.btn_OYNA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_satirSayisi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_sutunSayisi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_OYNA
            // 
            this.btn_OYNA.Location = new System.Drawing.Point(107, 117);
            this.btn_OYNA.Name = "btn_OYNA";
            this.btn_OYNA.Size = new System.Drawing.Size(84, 31);
            this.btn_OYNA.TabIndex = 1;
            this.btn_OYNA.Text = "OYNA";
            this.btn_OYNA.UseVisualStyleBackColor = true;
            this.btn_OYNA.Click += new System.EventHandler(this.btn_OYNA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Satır Sayısı";
            // 
            // txt_satirSayisi
            // 
            this.txt_satirSayisi.Location = new System.Drawing.Point(109, 20);
            this.txt_satirSayisi.Name = "txt_satirSayisi";
            this.txt_satirSayisi.Size = new System.Drawing.Size(100, 20);
            this.txt_satirSayisi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sütun Sayısı";
            // 
            // txt_sutunSayisi
            // 
            this.txt_sutunSayisi.Location = new System.Drawing.Point(109, 46);
            this.txt_sutunSayisi.Name = "txt_sutunSayisi";
            this.txt_sutunSayisi.Size = new System.Drawing.Size(100, 20);
            this.txt_sutunSayisi.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 206);
            this.Controls.Add(this.txt_sutunSayisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_satirSayisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_OYNA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OYNA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_satirSayisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_sutunSayisi;
    }
}

