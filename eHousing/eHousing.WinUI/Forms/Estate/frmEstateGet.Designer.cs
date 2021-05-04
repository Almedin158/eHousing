
namespace eHousing.WinUI.Forms.Estate
{
    partial class frmEstateGet
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
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.cbStreet = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEstateType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvEstates = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstates)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose City:";
            // 
            // cbCity
            // 
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(19, 34);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(249, 24);
            this.cbCity.TabIndex = 1;
            this.cbCity.SelectedIndexChanged += new System.EventHandler(this.cbCity_SelectedIndexChanged);
            // 
            // cbStreet
            // 
            this.cbStreet.FormattingEnabled = true;
            this.cbStreet.Location = new System.Drawing.Point(18, 87);
            this.cbStreet.Name = "cbStreet";
            this.cbStreet.Size = new System.Drawing.Size(249, 24);
            this.cbStreet.TabIndex = 3;
            this.cbStreet.SelectedIndexChanged += new System.EventHandler(this.cbStreet_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose Street:";
            // 
            // cbEstateType
            // 
            this.cbEstateType.FormattingEnabled = true;
            this.cbEstateType.Location = new System.Drawing.Point(18, 141);
            this.cbEstateType.Name = "cbEstateType";
            this.cbEstateType.Size = new System.Drawing.Size(249, 24);
            this.cbEstateType.TabIndex = 5;
            this.cbEstateType.SelectedIndexChanged += new System.EventHandler(this.cbEstateType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Choose Estate Type:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvEstates);
            this.groupBox1.Location = new System.Drawing.Point(16, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(835, 352);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estates";
            // 
            // dgvEstates
            // 
            this.dgvEstates.AllowUserToAddRows = false;
            this.dgvEstates.AllowUserToDeleteRows = false;
            this.dgvEstates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEstates.Location = new System.Drawing.Point(3, 18);
            this.dgvEstates.Name = "dgvEstates";
            this.dgvEstates.ReadOnly = true;
            this.dgvEstates.RowHeadersWidth = 51;
            this.dgvEstates.RowTemplate.Height = 24;
            this.dgvEstates.Size = new System.Drawing.Size(829, 331);
            this.dgvEstates.TabIndex = 0;
            this.dgvEstates.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvEstates_MouseDoubleClick);
            // 
            // frmEstateGet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 609);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbEstateType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbStreet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCity);
            this.Controls.Add(this.label1);
            this.Name = "frmEstateGet";
            this.Text = "frmEstateGet";
            this.Load += new System.EventHandler(this.frmEstateGet_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.ComboBox cbStreet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEstateType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvEstates;
    }
}