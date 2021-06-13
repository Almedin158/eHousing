
namespace eHousing.WinUI.Forms.Estate
{
    partial class frmEstateAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.cbStreet = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEstateType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBrowsePicture = new System.Windows.Forms.Button();
            this.txtEstateName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEstateDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFloorSpace = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumberOfRooms = new System.Windows.Forms.TextBox();
            this.cbPetsAllowed = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose City:";
            // 
            // cbCity
            // 
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(13, 34);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(223, 24);
            this.cbCity.TabIndex = 1;
            this.cbCity.SelectedIndexChanged += new System.EventHandler(this.cbCity_SelectedIndexChanged);
            this.cbCity.Validating += new System.ComponentModel.CancelEventHandler(this.cbCity_Validating);
            // 
            // cbStreet
            // 
            this.cbStreet.FormattingEnabled = true;
            this.cbStreet.Location = new System.Drawing.Point(12, 81);
            this.cbStreet.Name = "cbStreet";
            this.cbStreet.Size = new System.Drawing.Size(224, 24);
            this.cbStreet.TabIndex = 3;
            this.cbStreet.Validating += new System.ComponentModel.CancelEventHandler(this.cbStreet_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose Street:";
            // 
            // cbEstateType
            // 
            this.cbEstateType.FormattingEnabled = true;
            this.cbEstateType.Location = new System.Drawing.Point(12, 139);
            this.cbEstateType.Name = "cbEstateType";
            this.cbEstateType.Size = new System.Drawing.Size(223, 24);
            this.cbEstateType.TabIndex = 5;
            this.cbEstateType.Validating += new System.ComponentModel.CancelEventHandler(this.cbEstateType_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Choose Estate Type:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(416, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 286);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnBrowsePicture
            // 
            this.btnBrowsePicture.Location = new System.Drawing.Point(626, 306);
            this.btnBrowsePicture.Name = "btnBrowsePicture";
            this.btnBrowsePicture.Size = new System.Drawing.Size(164, 23);
            this.btnBrowsePicture.TabIndex = 7;
            this.btnBrowsePicture.Text = "Browse Picture";
            this.btnBrowsePicture.UseVisualStyleBackColor = true;
            this.btnBrowsePicture.Click += new System.EventHandler(this.btnBrowsePicture_Click);
            // 
            // txtEstateName
            // 
            this.txtEstateName.Location = new System.Drawing.Point(12, 191);
            this.txtEstateName.Name = "txtEstateName";
            this.txtEstateName.Size = new System.Drawing.Size(224, 22);
            this.txtEstateName.TabIndex = 8;
            this.txtEstateName.Validating += new System.ComponentModel.CancelEventHandler(this.txtEstateName_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Insert Estate name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Insert Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(12, 243);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(224, 22);
            this.txtPrice.TabIndex = 10;
            this.txtPrice.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrice_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Insert Estate Description:";
            // 
            // txtEstateDescription
            // 
            this.txtEstateDescription.Location = new System.Drawing.Point(12, 419);
            this.txtEstateDescription.Multiline = true;
            this.txtEstateDescription.Name = "txtEstateDescription";
            this.txtEstateDescription.Size = new System.Drawing.Size(778, 62);
            this.txtEstateDescription.TabIndex = 12;
            this.txtEstateDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txtEstateDescription_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Insert Floor Space:";
            // 
            // txtFloorSpace
            // 
            this.txtFloorSpace.Location = new System.Drawing.Point(12, 298);
            this.txtFloorSpace.Name = "txtFloorSpace";
            this.txtFloorSpace.Size = new System.Drawing.Size(224, 22);
            this.txtFloorSpace.TabIndex = 14;
            this.txtFloorSpace.Validating += new System.ComponentModel.CancelEventHandler(this.txtFloorSpace_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Insert Number Of Rooms:";
            // 
            // txtNumberOfRooms
            // 
            this.txtNumberOfRooms.Location = new System.Drawing.Point(12, 347);
            this.txtNumberOfRooms.Name = "txtNumberOfRooms";
            this.txtNumberOfRooms.Size = new System.Drawing.Size(224, 22);
            this.txtNumberOfRooms.TabIndex = 16;
            this.txtNumberOfRooms.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumberOfRooms_Validating);
            // 
            // cbPetsAllowed
            // 
            this.cbPetsAllowed.AutoSize = true;
            this.cbPetsAllowed.Location = new System.Drawing.Point(12, 375);
            this.cbPetsAllowed.Name = "cbPetsAllowed";
            this.cbPetsAllowed.Size = new System.Drawing.Size(117, 21);
            this.cbPetsAllowed.TabIndex = 18;
            this.cbPetsAllowed.Text = "Pets allowed?";
            this.cbPetsAllowed.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(623, 388);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(167, 28);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmEstateAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 493);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbPetsAllowed);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNumberOfRooms);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFloorSpace);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEstateDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEstateName);
            this.Controls.Add(this.btnBrowsePicture);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbEstateType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbStreet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCity);
            this.Controls.Add(this.label1);
            this.Name = "frmEstateAdd";
            this.Text = "frmEstateAdd";
            this.Load += new System.EventHandler(this.frmEstateAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBrowsePicture;
        private System.Windows.Forms.TextBox txtEstateName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEstateDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFloorSpace;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumberOfRooms;
        private System.Windows.Forms.CheckBox cbPetsAllowed;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}