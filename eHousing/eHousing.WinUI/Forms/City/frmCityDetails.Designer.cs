
namespace eHousing.WinUI.Forms.City
{
    partial class frmCityDetails
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtCityName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvStreets = new System.Windows.Forms.DataGridView();
            this.StreetId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StreetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddStreet = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStreets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(16, 377);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 54);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtCityName
            // 
            this.txtCityName.Location = new System.Drawing.Point(16, 33);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Size = new System.Drawing.Size(538, 22);
            this.txtCityName.TabIndex = 1;
            this.txtCityName.Validating += new System.ComponentModel.CancelEventHandler(this.txtCityName_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "City Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvStreets);
            this.groupBox1.Location = new System.Drawing.Point(12, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 299);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Streets";
            // 
            // dgvStreets
            // 
            this.dgvStreets.AllowUserToAddRows = false;
            this.dgvStreets.AllowUserToDeleteRows = false;
            this.dgvStreets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStreets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StreetId,
            this.StreetName,
            this.CityId,
            this.City});
            this.dgvStreets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStreets.Location = new System.Drawing.Point(3, 18);
            this.dgvStreets.Name = "dgvStreets";
            this.dgvStreets.ReadOnly = true;
            this.dgvStreets.RowHeadersWidth = 51;
            this.dgvStreets.RowTemplate.Height = 24;
            this.dgvStreets.Size = new System.Drawing.Size(540, 278);
            this.dgvStreets.TabIndex = 0;
            this.dgvStreets.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvStreets_MouseDoubleClick);
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
            // StreetName
            // 
            this.StreetName.DataPropertyName = "StreetName";
            this.StreetName.HeaderText = "Street Name";
            this.StreetName.MinimumWidth = 6;
            this.StreetName.Name = "StreetName";
            this.StreetName.ReadOnly = true;
            this.StreetName.Width = 125;
            // 
            // CityId
            // 
            this.CityId.DataPropertyName = "CityId";
            this.CityId.HeaderText = "CityId";
            this.CityId.MinimumWidth = 6;
            this.CityId.Name = "CityId";
            this.CityId.ReadOnly = true;
            this.CityId.Visible = false;
            this.CityId.Width = 125;
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "City";
            this.City.MinimumWidth = 6;
            this.City.Name = "City";
            this.City.ReadOnly = true;
            this.City.Visible = false;
            this.City.Width = 125;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(431, 377);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 54);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Update";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddStreet
            // 
            this.btnAddStreet.Location = new System.Drawing.Point(295, 377);
            this.btnAddStreet.Name = "btnAddStreet";
            this.btnAddStreet.Size = new System.Drawing.Size(127, 54);
            this.btnAddStreet.TabIndex = 5;
            this.btnAddStreet.Text = "Add Street";
            this.btnAddStreet.UseVisualStyleBackColor = true;
            this.btnAddStreet.Click += new System.EventHandler(this.btnAddStreet_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmCityDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 439);
            this.Controls.Add(this.btnAddStreet);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCityName);
            this.Controls.Add(this.btnDelete);
            this.Name = "frmCityDetails";
            this.Text = "frmCityDetails";
            this.Load += new System.EventHandler(this.frmCityDetails_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStreets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtCityName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvStreets;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddStreet;
        private System.Windows.Forms.DataGridViewTextBoxColumn StreetId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StreetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityId;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}