
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
            this.EstateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsOccupied = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstateDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FloorSpace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfRooms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PetsAllowed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.StreetId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstateTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstateType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbPetsAllowed = new System.Windows.Forms.CheckBox();
            this.cbOccupied = new System.Windows.Forms.CheckBox();
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
            this.groupBox1.Location = new System.Drawing.Point(18, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 301);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estates";
            // 
            // dgvEstates
            // 
            this.dgvEstates.AllowUserToAddRows = false;
            this.dgvEstates.AllowUserToDeleteRows = false;
            this.dgvEstates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EstateId,
            this.IsOccupied,
            this.Price,
            this.EstateName,
            this.EstateDescription,
            this.FloorSpace,
            this.NumberOfRooms,
            this.PetsAllowed,
            this.Image,
            this.StreetId,
            this.Street,
            this.EstateTypeId,
            this.EstateType,
            this.UserId,
            this.User});
            this.dgvEstates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEstates.Location = new System.Drawing.Point(3, 18);
            this.dgvEstates.Name = "dgvEstates";
            this.dgvEstates.ReadOnly = true;
            this.dgvEstates.RowHeadersWidth = 51;
            this.dgvEstates.RowTemplate.Height = 24;
            this.dgvEstates.Size = new System.Drawing.Size(766, 280);
            this.dgvEstates.TabIndex = 0;
            this.dgvEstates.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvEstates_MouseDoubleClick);
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
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 125;
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
            // EstateDescription
            // 
            this.EstateDescription.DataPropertyName = "EstateDescription";
            this.EstateDescription.HeaderText = "Estate Description";
            this.EstateDescription.MinimumWidth = 6;
            this.EstateDescription.Name = "EstateDescription";
            this.EstateDescription.ReadOnly = true;
            this.EstateDescription.Width = 125;
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
            // Image
            // 
            this.Image.DataPropertyName = "Image";
            this.Image.HeaderText = "Image";
            this.Image.MinimumWidth = 6;
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            this.Image.Width = 125;
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
            // cbPetsAllowed
            // 
            this.cbPetsAllowed.AutoSize = true;
            this.cbPetsAllowed.Location = new System.Drawing.Point(342, 34);
            this.cbPetsAllowed.Name = "cbPetsAllowed";
            this.cbPetsAllowed.Size = new System.Drawing.Size(117, 21);
            this.cbPetsAllowed.TabIndex = 7;
            this.cbPetsAllowed.Text = "Pets allowed?";
            this.cbPetsAllowed.UseVisualStyleBackColor = true;
            this.cbPetsAllowed.CheckedChanged += new System.EventHandler(this.cbPetsAllowed_CheckedChanged);
            // 
            // cbOccupied
            // 
            this.cbOccupied.AutoSize = true;
            this.cbOccupied.Location = new System.Drawing.Point(342, 89);
            this.cbOccupied.Name = "cbOccupied";
            this.cbOccupied.Size = new System.Drawing.Size(98, 21);
            this.cbOccupied.TabIndex = 8;
            this.cbOccupied.Text = "Occupied?";
            this.cbOccupied.UseVisualStyleBackColor = true;
            this.cbOccupied.CheckedChanged += new System.EventHandler(this.cbPetsAllowed_CheckedChanged);
            // 
            // frmEstateGet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 493);
            this.Controls.Add(this.cbOccupied);
            this.Controls.Add(this.cbPetsAllowed);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn EstateId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsOccupied;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstateDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn FloorSpace;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfRooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn PetsAllowed;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn StreetId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Street;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstateTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstateType;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.CheckBox cbPetsAllowed;
        private System.Windows.Forms.CheckBox cbOccupied;
    }
}