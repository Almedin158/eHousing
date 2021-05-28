
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
            this.EstateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsOccupied = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.FloorSpace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfRooms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PetsAllowed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstateDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstateTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstateType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StreetId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyEstates)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvMyEstates);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 468);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "My Estates";
            // 
            // dgvMyEstates
            // 
            this.dgvMyEstates.AllowUserToAddRows = false;
            this.dgvMyEstates.AllowUserToDeleteRows = false;
            this.dgvMyEstates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyEstates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EstateId,
            this.IsOccupied,
            this.CreationDate,
            this.Image,
            this.FloorSpace,
            this.NumberOfRooms,
            this.PetsAllowed,
            this.EstateName,
            this.Price,
            this.EstateDescription,
            this.UserId,
            this.User,
            this.EstateTypeId,
            this.EstateType,
            this.StreetId,
            this.Street});
            this.dgvMyEstates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMyEstates.Location = new System.Drawing.Point(3, 18);
            this.dgvMyEstates.Name = "dgvMyEstates";
            this.dgvMyEstates.ReadOnly = true;
            this.dgvMyEstates.RowHeadersWidth = 51;
            this.dgvMyEstates.Size = new System.Drawing.Size(771, 447);
            this.dgvMyEstates.TabIndex = 0;
            this.dgvMyEstates.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvMyEstates_MouseDoubleClick);
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
            // IsOccupied
            // 
            this.IsOccupied.DataPropertyName = "IsOccupied";
            this.IsOccupied.HeaderText = "Occupied";
            this.IsOccupied.MinimumWidth = 6;
            this.IsOccupied.Name = "IsOccupied";
            this.IsOccupied.ReadOnly = true;
            this.IsOccupied.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsOccupied.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsOccupied.Width = 125;
            // 
            // CreationDate
            // 
            this.CreationDate.DataPropertyName = "CreationDate";
            this.CreationDate.HeaderText = "Creation Date";
            this.CreationDate.MinimumWidth = 6;
            this.CreationDate.Name = "CreationDate";
            this.CreationDate.ReadOnly = true;
            this.CreationDate.Width = 125;
            // 
            // Image
            // 
            this.Image.DataPropertyName = "Image";
            this.Image.HeaderText = "Image";
            this.Image.MinimumWidth = 6;
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            this.Image.Width = 125;
            // 
            // FloorSpace
            // 
            this.FloorSpace.DataPropertyName = "FloorSpace";
            this.FloorSpace.HeaderText = "Floor Space";
            this.FloorSpace.MinimumWidth = 6;
            this.FloorSpace.Name = "FloorSpace";
            this.FloorSpace.ReadOnly = true;
            this.FloorSpace.Width = 125;
            // 
            // NumberOfRooms
            // 
            this.NumberOfRooms.DataPropertyName = "NumberOfRooms";
            this.NumberOfRooms.HeaderText = "Number Of Rooms";
            this.NumberOfRooms.MinimumWidth = 6;
            this.NumberOfRooms.Name = "NumberOfRooms";
            this.NumberOfRooms.ReadOnly = true;
            this.NumberOfRooms.Width = 125;
            // 
            // PetsAllowed
            // 
            this.PetsAllowed.DataPropertyName = "PetsAllowed";
            this.PetsAllowed.HeaderText = "Pets Allowed";
            this.PetsAllowed.MinimumWidth = 6;
            this.PetsAllowed.Name = "PetsAllowed";
            this.PetsAllowed.ReadOnly = true;
            this.PetsAllowed.Width = 125;
            // 
            // EstateName
            // 
            this.EstateName.DataPropertyName = "EstateName";
            this.EstateName.HeaderText = "Estate Name";
            this.EstateName.MinimumWidth = 6;
            this.EstateName.Name = "EstateName";
            this.EstateName.ReadOnly = true;
            this.EstateName.Width = 125;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 125;
            // 
            // EstateDescription
            // 
            this.EstateDescription.DataPropertyName = "EstateDescription";
            this.EstateDescription.HeaderText = "Estate Description";
            this.EstateDescription.MinimumWidth = 6;
            this.EstateDescription.Name = "EstateDescription";
            this.EstateDescription.ReadOnly = true;
            this.EstateDescription.Width = 125;
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "UserId";
            this.UserId.HeaderText = "UserId";
            this.UserId.MinimumWidth = 6;
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            this.UserId.Visible = false;
            this.UserId.Width = 125;
            // 
            // User
            // 
            this.User.DataPropertyName = "User";
            this.User.HeaderText = "User";
            this.User.MinimumWidth = 6;
            this.User.Name = "User";
            this.User.ReadOnly = true;
            this.User.Visible = false;
            this.User.Width = 125;
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
            // EstateType
            // 
            this.EstateType.DataPropertyName = "EstateType";
            this.EstateType.HeaderText = "EstateType";
            this.EstateType.MinimumWidth = 6;
            this.EstateType.Name = "EstateType";
            this.EstateType.ReadOnly = true;
            this.EstateType.Visible = false;
            this.EstateType.Width = 125;
            // 
            // StreetId
            // 
            this.StreetId.DataPropertyName = "StreetId";
            this.StreetId.HeaderText = "StreetId";
            this.StreetId.MinimumWidth = 6;
            this.StreetId.Name = "StreetId";
            this.StreetId.ReadOnly = true;
            this.StreetId.Visible = false;
            this.StreetId.Width = 125;
            // 
            // Street
            // 
            this.Street.DataPropertyName = "Street";
            this.Street.HeaderText = "Street";
            this.Street.MinimumWidth = 6;
            this.Street.Name = "Street";
            this.Street.ReadOnly = true;
            this.Street.Visible = false;
            this.Street.Width = 125;
            // 
            // frmMyEstates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 493);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn EstateId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsOccupied;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreationDate;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn FloorSpace;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfRooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn PetsAllowed;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstateDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstateTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstateType;
        private System.Windows.Forms.DataGridViewTextBoxColumn StreetId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Street;
    }
}