
namespace eHousing.WinUI.Forms.Street
{
    partial class frmStreetDetails
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtStreetName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvEstates = new System.Windows.Forms.DataGridView();
            this.EstateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FloorSpace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfRooms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PetsAllowed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstateDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(664, 32);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 29);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtStreetName
            // 
            this.txtStreetName.Location = new System.Drawing.Point(16, 32);
            this.txtStreetName.Multiline = true;
            this.txtStreetName.Name = "txtStreetName";
            this.txtStreetName.Size = new System.Drawing.Size(614, 29);
            this.txtStreetName.TabIndex = 1;
            this.txtStreetName.Validating += new System.ComponentModel.CancelEventHandler(this.txtStreetName_Validating);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvEstates);
            this.groupBox1.Location = new System.Drawing.Point(16, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(774, 414);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estates";
            // 
            // dgvEstates
            // 
            this.dgvEstates.AllowUserToAddRows = false;
            this.dgvEstates.AllowUserToDeleteRows = false;
            this.dgvEstates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EstateName,
            this.EstateId,
            this.Price,
            this.FloorSpace,
            this.NumberOfRooms,
            this.PetsAllowed,
            this.EstateDescription});
            this.dgvEstates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEstates.Location = new System.Drawing.Point(3, 18);
            this.dgvEstates.Name = "dgvEstates";
            this.dgvEstates.ReadOnly = true;
            this.dgvEstates.RowHeadersWidth = 51;
            this.dgvEstates.RowTemplate.Height = 24;
            this.dgvEstates.Size = new System.Drawing.Size(768, 393);
            this.dgvEstates.TabIndex = 0;
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
            // EstateId
            // 
            this.EstateId.HeaderText = "EstateId";
            this.EstateId.MinimumWidth = 6;
            this.EstateId.Name = "EstateId";
            this.EstateId.ReadOnly = true;
            this.EstateId.Visible = false;
            this.EstateId.Width = 125;
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
            // EstateDescription
            // 
            this.EstateDescription.DataPropertyName = "EstateDescription";
            this.EstateDescription.HeaderText = "Estate Description";
            this.EstateDescription.MinimumWidth = 6;
            this.EstateDescription.Name = "EstateDescription";
            this.EstateDescription.ReadOnly = true;
            this.EstateDescription.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Street Name:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmStreetDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 493);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtStreetName);
            this.Controls.Add(this.btnSave);
            this.Name = "frmStreetDetails";
            this.Text = "frmStreetDetails";
            this.Load += new System.EventHandler(this.frmStreetDetails_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtStreetName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvEstates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstateId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn FloorSpace;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfRooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn PetsAllowed;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstateDescription;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}