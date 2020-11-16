namespace WindowsFormsApp1
{
    partial class form_menu
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
            this.numericudAltinYuzde = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label6 = new System.Windows.Forms.Label();
            this.nud_A_HamleMaliyet = new System.Windows.Forms.NumericUpDown();
            this.nud_A_HedefBelirlemeMaliyet = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nud_B_HamleMaliyet = new System.Windows.Forms.NumericUpDown();
            this.nud_B_HedefBelirlemeMaliyet = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nud_C_HamleMaliyet = new System.Windows.Forms.NumericUpDown();
            this.nud_C_HedefBelirlemeMaliyet = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nud_D_HamleMaliyet = new System.Windows.Forms.NumericUpDown();
            this.nud_D_HedefBelirlemeMaliyet = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.nud_AdimSayilari = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.nud_AltinSayilari = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.numericudGizliAltinYuzde = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericudSatir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericudSutun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericudAltinYuzde)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_A_HamleMaliyet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_A_HedefBelirlemeMaliyet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_B_HamleMaliyet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_B_HedefBelirlemeMaliyet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_C_HamleMaliyet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_C_HedefBelirlemeMaliyet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_D_HamleMaliyet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_D_HedefBelirlemeMaliyet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_AdimSayilari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_AltinSayilari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericudGizliAltinYuzde)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_OYNA
            // 
            this.btn_OYNA.Location = new System.Drawing.Point(254, 197);
            this.btn_OYNA.Name = "btn_OYNA";
            this.btn_OYNA.Size = new System.Drawing.Size(158, 122);
            this.btn_OYNA.TabIndex = 2;
            this.btn_OYNA.Text = "OYNA";
            this.btn_OYNA.UseVisualStyleBackColor = true;
            this.btn_OYNA.UseWaitCursor = true;
            this.btn_OYNA.Click += new System.EventHandler(this.btn_OYNA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = " Satır Sayısı";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Altın Yüzdesi";
            this.label2.UseWaitCursor = true;
            // 
            // numericudSatir
            // 
            this.numericudSatir.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericudSatir.Location = new System.Drawing.Point(98, 14);
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
            this.numericudSatir.UseWaitCursor = true;
            this.numericudSatir.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // numericudSutun
            // 
            this.numericudSutun.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericudSutun.Location = new System.Drawing.Point(98, 40);
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
            this.numericudSutun.UseWaitCursor = true;
            this.numericudSutun.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // numericudAltinYuzde
            // 
            this.numericudAltinYuzde.Location = new System.Drawing.Point(99, 67);
            this.numericudAltinYuzde.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericudAltinYuzde.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericudAltinYuzde.Name = "numericudAltinYuzde";
            this.numericudAltinYuzde.Size = new System.Drawing.Size(120, 20);
            this.numericudAltinYuzde.TabIndex = 3;
            this.numericudAltinYuzde.UseWaitCursor = true;
            this.numericudAltinYuzde.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sütun Sayısı";
            this.label3.UseWaitCursor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericudGizliAltinYuzde);
            this.groupBox1.Controls.Add(this.numericudAltinYuzde);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericudSutun);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericudSatir);
            this.groupBox1.Location = new System.Drawing.Point(12, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 122);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TAHTA";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nud_D_HedefBelirlemeMaliyet);
            this.groupBox2.Controls.Add(this.nud_C_HedefBelirlemeMaliyet);
            this.groupBox2.Controls.Add(this.nud_B_HedefBelirlemeMaliyet);
            this.groupBox2.Controls.Add(this.nud_AltinSayilari);
            this.groupBox2.Controls.Add(this.nud_AdimSayilari);
            this.groupBox2.Controls.Add(this.nud_A_HedefBelirlemeMaliyet);
            this.groupBox2.Controls.Add(this.nud_D_HamleMaliyet);
            this.groupBox2.Controls.Add(this.nud_C_HamleMaliyet);
            this.groupBox2.Controls.Add(this.nud_B_HamleMaliyet);
            this.groupBox2.Controls.Add(this.nud_A_HamleMaliyet);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 157);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OYUNCULAR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hamle Maliyeti";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Hedef Belirleme Maliyeti";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "A";
            // 
            // nud_A_HamleMaliyet
            // 
            this.nud_A_HamleMaliyet.Location = new System.Drawing.Point(132, 39);
            this.nud_A_HamleMaliyet.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_A_HamleMaliyet.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_A_HamleMaliyet.Name = "nud_A_HamleMaliyet";
            this.nud_A_HamleMaliyet.Size = new System.Drawing.Size(49, 20);
            this.nud_A_HamleMaliyet.TabIndex = 4;
            this.nud_A_HamleMaliyet.UseWaitCursor = true;
            this.nud_A_HamleMaliyet.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nud_A_HedefBelirlemeMaliyet
            // 
            this.nud_A_HedefBelirlemeMaliyet.Location = new System.Drawing.Point(132, 62);
            this.nud_A_HedefBelirlemeMaliyet.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_A_HedefBelirlemeMaliyet.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_A_HedefBelirlemeMaliyet.Name = "nud_A_HedefBelirlemeMaliyet";
            this.nud_A_HedefBelirlemeMaliyet.Size = new System.Drawing.Size(49, 20);
            this.nud_A_HedefBelirlemeMaliyet.TabIndex = 4;
            this.nud_A_HedefBelirlemeMaliyet.UseWaitCursor = true;
            this.nud_A_HedefBelirlemeMaliyet.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(221, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "B";
            // 
            // nud_B_HamleMaliyet
            // 
            this.nud_B_HamleMaliyet.Location = new System.Drawing.Point(201, 39);
            this.nud_B_HamleMaliyet.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_B_HamleMaliyet.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_B_HamleMaliyet.Name = "nud_B_HamleMaliyet";
            this.nud_B_HamleMaliyet.Size = new System.Drawing.Size(49, 20);
            this.nud_B_HamleMaliyet.TabIndex = 4;
            this.nud_B_HamleMaliyet.UseWaitCursor = true;
            this.nud_B_HamleMaliyet.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nud_B_HedefBelirlemeMaliyet
            // 
            this.nud_B_HedefBelirlemeMaliyet.Location = new System.Drawing.Point(201, 62);
            this.nud_B_HedefBelirlemeMaliyet.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_B_HedefBelirlemeMaliyet.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_B_HedefBelirlemeMaliyet.Name = "nud_B_HedefBelirlemeMaliyet";
            this.nud_B_HedefBelirlemeMaliyet.Size = new System.Drawing.Size(49, 20);
            this.nud_B_HedefBelirlemeMaliyet.TabIndex = 4;
            this.nud_B_HedefBelirlemeMaliyet.UseWaitCursor = true;
            this.nud_B_HedefBelirlemeMaliyet.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(288, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "C";
            // 
            // nud_C_HamleMaliyet
            // 
            this.nud_C_HamleMaliyet.Location = new System.Drawing.Point(271, 39);
            this.nud_C_HamleMaliyet.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_C_HamleMaliyet.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_C_HamleMaliyet.Name = "nud_C_HamleMaliyet";
            this.nud_C_HamleMaliyet.Size = new System.Drawing.Size(49, 20);
            this.nud_C_HamleMaliyet.TabIndex = 4;
            this.nud_C_HamleMaliyet.UseWaitCursor = true;
            this.nud_C_HamleMaliyet.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nud_C_HedefBelirlemeMaliyet
            // 
            this.nud_C_HedefBelirlemeMaliyet.Location = new System.Drawing.Point(271, 62);
            this.nud_C_HedefBelirlemeMaliyet.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_C_HedefBelirlemeMaliyet.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_C_HedefBelirlemeMaliyet.Name = "nud_C_HedefBelirlemeMaliyet";
            this.nud_C_HedefBelirlemeMaliyet.Size = new System.Drawing.Size(49, 20);
            this.nud_C_HedefBelirlemeMaliyet.TabIndex = 4;
            this.nud_C_HedefBelirlemeMaliyet.UseWaitCursor = true;
            this.nud_C_HedefBelirlemeMaliyet.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(359, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "D";
            // 
            // nud_D_HamleMaliyet
            // 
            this.nud_D_HamleMaliyet.Location = new System.Drawing.Point(341, 39);
            this.nud_D_HamleMaliyet.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_D_HamleMaliyet.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_D_HamleMaliyet.Name = "nud_D_HamleMaliyet";
            this.nud_D_HamleMaliyet.Size = new System.Drawing.Size(49, 20);
            this.nud_D_HamleMaliyet.TabIndex = 4;
            this.nud_D_HamleMaliyet.UseWaitCursor = true;
            this.nud_D_HamleMaliyet.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nud_D_HedefBelirlemeMaliyet
            // 
            this.nud_D_HedefBelirlemeMaliyet.Location = new System.Drawing.Point(341, 62);
            this.nud_D_HedefBelirlemeMaliyet.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_D_HedefBelirlemeMaliyet.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_D_HedefBelirlemeMaliyet.Name = "nud_D_HedefBelirlemeMaliyet";
            this.nud_D_HedefBelirlemeMaliyet.Size = new System.Drawing.Size(49, 20);
            this.nud_D_HedefBelirlemeMaliyet.TabIndex = 4;
            this.nud_D_HedefBelirlemeMaliyet.UseWaitCursor = true;
            this.nud_D_HedefBelirlemeMaliyet.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Adım Sayıları";
            // 
            // nud_AdimSayilari
            // 
            this.nud_AdimSayilari.Location = new System.Drawing.Point(132, 86);
            this.nud_AdimSayilari.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_AdimSayilari.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_AdimSayilari.Name = "nud_AdimSayilari";
            this.nud_AdimSayilari.Size = new System.Drawing.Size(258, 20);
            this.nud_AdimSayilari.TabIndex = 4;
            this.nud_AdimSayilari.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_AdimSayilari.UseWaitCursor = true;
            this.nud_AdimSayilari.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Altın Sayıları";
            // 
            // nud_AltinSayilari
            // 
            this.nud_AltinSayilari.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_AltinSayilari.Location = new System.Drawing.Point(133, 114);
            this.nud_AltinSayilari.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.nud_AltinSayilari.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nud_AltinSayilari.Name = "nud_AltinSayilari";
            this.nud_AltinSayilari.Size = new System.Drawing.Size(258, 20);
            this.nud_AltinSayilari.TabIndex = 4;
            this.nud_AltinSayilari.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_AltinSayilari.UseWaitCursor = true;
            this.nud_AltinSayilari.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Gizli Altın Yüzdesi";
            this.label12.UseWaitCursor = true;
            // 
            // numericudGizliAltinYuzde
            // 
            this.numericudGizliAltinYuzde.Location = new System.Drawing.Point(98, 93);
            this.numericudGizliAltinYuzde.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericudGizliAltinYuzde.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericudGizliAltinYuzde.Name = "numericudGizliAltinYuzde";
            this.numericudGizliAltinYuzde.Size = new System.Drawing.Size(120, 20);
            this.numericudGizliAltinYuzde.TabIndex = 3;
            this.numericudGizliAltinYuzde.UseWaitCursor = true;
            this.numericudGizliAltinYuzde.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // form_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 334);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_OYNA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "form_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Altın Toplama Oyunu - Menü";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericudSatir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericudSutun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericudAltinYuzde)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_A_HamleMaliyet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_A_HedefBelirlemeMaliyet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_B_HamleMaliyet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_B_HedefBelirlemeMaliyet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_C_HamleMaliyet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_C_HedefBelirlemeMaliyet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_D_HamleMaliyet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_D_HedefBelirlemeMaliyet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_AdimSayilari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_AltinSayilari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericudGizliAltinYuzde)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_OYNA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericudSatir;
        private System.Windows.Forms.NumericUpDown numericudSutun;
        private System.Windows.Forms.NumericUpDown numericudAltinYuzde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.NumericUpDown nud_D_HedefBelirlemeMaliyet;
        private System.Windows.Forms.NumericUpDown nud_C_HedefBelirlemeMaliyet;
        private System.Windows.Forms.NumericUpDown nud_B_HedefBelirlemeMaliyet;
        private System.Windows.Forms.NumericUpDown nud_A_HedefBelirlemeMaliyet;
        private System.Windows.Forms.NumericUpDown nud_D_HamleMaliyet;
        private System.Windows.Forms.NumericUpDown nud_C_HamleMaliyet;
        private System.Windows.Forms.NumericUpDown nud_B_HamleMaliyet;
        private System.Windows.Forms.NumericUpDown nud_A_HamleMaliyet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericudGizliAltinYuzde;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nud_AltinSayilari;
        private System.Windows.Forms.NumericUpDown nud_AdimSayilari;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}

