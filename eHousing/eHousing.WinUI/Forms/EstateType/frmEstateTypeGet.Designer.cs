
namespace eHousing.WinUI.Forms.EstateType
{
    partial class frmEstateTypeGet
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
            this.dgvEstateType = new System.Windows.Forms.DataGridView();
            this.EstateTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.EstateTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstateType)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvEstateType);
            this.groupBox1.Location = new System.Drawing.Point(13, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 335);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estate Types";
            // 
            // dgvEstateType
            // 
            this.dgvEstateType.AllowUserToAddRows = false;
            this.dgvEstateType.AllowUserToDeleteRows = false;
            this.dgvEstateType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstateType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EstateTypeId,
            this.Image,
            this.EstateTypeName});
            this.dgvEstateType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEstateType.Location = new System.Drawing.Point(3, 18);
            this.dgvEstateType.Name = "dgvEstateType";
            this.dgvEstateType.ReadOnly = true;
            this.dgvEstateType.RowHeadersWidth = 51;
            this.dgvEstateType.RowTemplate.Height = 24;
            this.dgvEstateType.Size = new System.Drawing.Size(769, 314);
            this.dgvEstateType.TabIndex = 0;
            this.dgvEstateType.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvEstateType_MouseDoubleClick);
            // 
            // EstateTypeId
            // 
            this.EstateTypeId.DataPropertyName = "EstateTypeId";
            this.EstateTypeId.HeaderText = "EstateTypeId";
            this.EstateTypeId.MinimumWidth = 6;
            this.EstateTypeId.Name = "EstateTypeId";
            this.EstateTypeId.ReadOnly = true;
            this.EstateTypeId.Visible = false;
            this.EstateTypeId.Width = 125;
            // 
            // Image
            // 
            this.Image.DataPropertyName = "Image";
            this.Image.HeaderText = "Image";
            this.Image.MinimumWidth = 6;
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            this.Image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Image.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Image.Width = 125;
            // 
            // EstateTypeName
            // 
            this.EstateTypeName.DataPropertyName = "EstateTypeName";
            this.EstateTypeName.HeaderText = "Estate Type Name";
            this.EstateTypeName.MinimumWidth = 6;
            this.EstateTypeName.Name = "EstateTypeName";
            this.EstateTypeName.ReadOnly = true;
            this.EstateTypeName.Width = 125;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(13, 40);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(772, 22);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(666, 68);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(119, 47);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search Estate Type By Name:";
            // 
            // frmEstateTypeGet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEstateTypeGet";
            this.Text = "EstateTypeGet";
            this.Load += new System.EventHandler(this.frmEstateTypeGet_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstateType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvEstateType;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstateTypeId;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstateTypeName;
    }
}