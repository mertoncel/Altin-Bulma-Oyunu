namespace WindowsFormsApp1
{
    partial class OzetTablo
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
            this.dgw_ozetTablo = new System.Windows.Forms.DataGridView();
            this.dOyuncusuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aOyuncusuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOyuncusuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOyuncusuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_ozetTablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOyuncusuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aOyuncusuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOyuncusuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOyuncusuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_ozetTablo
            // 
            this.dgw_ozetTablo.AllowUserToAddRows = false;
            this.dgw_ozetTablo.AllowUserToDeleteRows = false;
            this.dgw_ozetTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_ozetTablo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_ozetTablo.Location = new System.Drawing.Point(0, 0);
            this.dgw_ozetTablo.Name = "dgw_ozetTablo";
            this.dgw_ozetTablo.ReadOnly = true;
            this.dgw_ozetTablo.Size = new System.Drawing.Size(444, 357);
            this.dgw_ozetTablo.TabIndex = 0;
            // 
            // dOyuncusuBindingSource
            // 
            this.dOyuncusuBindingSource.DataSource = typeof(WindowsFormsApp1.DOyuncusu);
            // 
            // aOyuncusuBindingSource
            // 
            this.aOyuncusuBindingSource.DataSource = typeof(WindowsFormsApp1.AOyuncusu);
            // 
            // bOyuncusuBindingSource
            // 
            this.bOyuncusuBindingSource.DataSource = typeof(WindowsFormsApp1.BOyuncusu);
            // 
            // cOyuncusuBindingSource
            // 
            this.cOyuncusuBindingSource.DataSource = typeof(WindowsFormsApp1.COyuncusu);
            // 
            // OzetTablo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 357);
            this.Controls.Add(this.dgw_ozetTablo);
            this.Name = "OzetTablo";
            this.Text = "OzetTablo";
            this.Load += new System.EventHandler(this.OzetTablo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_ozetTablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOyuncusuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aOyuncusuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOyuncusuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOyuncusuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_ozetTablo;
        private System.Windows.Forms.BindingSource dOyuncusuBindingSource;
        private System.Windows.Forms.BindingSource aOyuncusuBindingSource;
        private System.Windows.Forms.BindingSource bOyuncusuBindingSource;
        private System.Windows.Forms.BindingSource cOyuncusuBindingSource;
    }
}