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
            this.label2 = new System.Windows.Forms.Label();
            this.numericudSatir = new System.Windows.Forms.NumericUpDown();
            this.numericudSutun = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericudSatir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericudSutun)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_OYNA
            // 
            this.btn_OYNA.Location = new System.Drawing.Point(48, 87);
            this.btn_OYNA.Name = "btn_OYNA";
            this.btn_OYNA.Size = new System.Drawing.Size(181, 31);
            this.btn_OYNA.TabIndex = 2;
            this.btn_OYNA.Text = "OYNA";
            this.btn_OYNA.UseVisualStyleBackColor = true;
            this.btn_OYNA.UseWaitCursor = true;
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
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sütun Sayısı";
            this.label2.UseWaitCursor = true;
            // 
            // numericudSatir
            // 
            this.numericudSatir.Location = new System.Drawing.Point(109, 23);
            this.numericudSatir.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericudSatir.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericudSatir.Name = "numericudSatir";
            this.numericudSatir.Size = new System.Drawing.Size(120, 20);
            this.numericudSatir.TabIndex = 3;
            this.numericudSatir.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // numericudSutun
            // 
            this.numericudSutun.Location = new System.Drawing.Point(109, 49);
            this.numericudSutun.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericudSutun.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericudSutun.Name = "numericudSutun";
            this.numericudSutun.Size = new System.Drawing.Size(120, 20);
            this.numericudSutun.TabIndex = 3;
            this.numericudSutun.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 206);
            this.Controls.Add(this.numericudSutun);
            this.Controls.Add(this.numericudSatir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_OYNA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Altın Toplama Oyunu - Menü";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericudSatir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericudSutun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OYNA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericudSatir;
        private System.Windows.Forms.NumericUpDown numericudSutun;
    }
}

