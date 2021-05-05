
namespace eHousing.WinUI.Forms.Estate
{
    partial class frmMyEstates
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvMyEstates = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyEstates)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvMyEstates);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 425);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "My Estates";
            // 
            // dgvMyEstates
            // 
            this.dgvMyEstates.AllowUserToAddRows = false;
            this.dgvMyEstates.AllowUserToDeleteRows = false;
            this.dgvMyEstates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyEstates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMyEstates.Location = new System.Drawing.Point(3, 18);
            this.dgvMyEstates.Name = "dgvMyEstates";
            this.dgvMyEstates.ReadOnly = true;
            this.dgvMyEstates.RowHeadersWidth = 51;
            this.dgvMyEstates.Size = new System.Drawing.Size(769, 404);
            this.dgvMyEstates.TabIndex = 0;
            // 
            // frmMyEstates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMyEstates";
            this.Text = "frmMyEstates";
            this.Load += new System.EventHandler(this.frmMyEstates_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyEstates)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvMyEstates;
    }
}