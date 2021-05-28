
namespace eHousing.WinUI.Forms.Estate
{
    partial class frmEstateGallery
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
            this.dgvGallery = new System.Windows.Forms.DataGridView();
            this.PictureId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Picture = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGallery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvGallery);
            this.groupBox1.Location = new System.Drawing.Point(11, 273);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(779, 208);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gallery";
            // 
            // dgvGallery
            // 
            this.dgvGallery.AllowUserToAddRows = false;
            this.dgvGallery.AllowUserToDeleteRows = false;
            this.dgvGallery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGallery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PictureId,
            this.Estate,
            this.EstateId,
            this.Picture});
            this.dgvGallery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGallery.Location = new System.Drawing.Point(3, 18);
            this.dgvGallery.Name = "dgvGallery";
            this.dgvGallery.ReadOnly = true;
            this.dgvGallery.RowHeadersWidth = 51;
            this.dgvGallery.RowTemplate.Height = 24;
            this.dgvGallery.Size = new System.Drawing.Size(773, 187);
            this.dgvGallery.TabIndex = 0;
            // 
            // PictureId
            // 
            this.PictureId.DataPropertyName = "PictureId";
            this.PictureId.HeaderText = "PictureId";
            this.PictureId.MinimumWidth = 6;
            this.PictureId.Name = "PictureId";
            this.PictureId.ReadOnly = true;
            this.PictureId.Visible = false;
            this.PictureId.Width = 125;
            // 
            // Estate
            // 
            this.Estate.DataPropertyName = "Estate";
            this.Estate.HeaderText = "Estate";
            this.Estate.MinimumWidth = 6;
            this.Estate.Name = "Estate";
            this.Estate.ReadOnly = true;
            this.Estate.Visible = false;
            this.Estate.Width = 125;
            // 
            // EstateId
            // 
            this.EstateId.DataPropertyName = "EstateId";
            this.EstateId.HeaderText = "EstateId";
            this.EstateId.MinimumWidth = 6;
            this.EstateId.Name = "EstateId";
            this.EstateId.ReadOnly = true;
            this.EstateId.Visible = false;
            this.EstateId.Width = 125;
            // 
            // Picture
            // 
            this.Picture.DataPropertyName = "Image";
            this.Picture.HeaderText = "Image";
            this.Picture.MinimumWidth = 6;
            this.Picture.Name = "Picture";
            this.Picture.ReadOnly = true;
            this.Picture.Width = 125;
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.Location = new System.Drawing.Point(14, 175);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(118, 91);
            this.btnBrowseImage.TabIndex = 1;
            this.btnBrowseImage.Text = "Browse Image";
            this.btnBrowseImage.UseVisualStyleBackColor = true;
            this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(457, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 254);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Location = new System.Drawing.Point(333, 176);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(118, 91);
            this.btnSaveImage.TabIndex = 3;
            this.btnSaveImage.Text = "Save Selected Image";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // frmEstateGallery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 493);
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBrowseImage);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEstateGallery";
            this.Text = "frmEstateGallery";
            this.Load += new System.EventHandler(this.frmEstateGallery_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGallery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvGallery;
        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn PictureId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstateId;
        private System.Windows.Forms.DataGridViewImageColumn Picture;
    }
}