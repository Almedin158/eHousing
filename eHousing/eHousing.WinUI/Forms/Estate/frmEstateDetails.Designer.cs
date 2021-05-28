
namespace eHousing.WinUI.Forms.Estate
{
    partial class frmEstateDetails
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
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEstateType = new System.Windows.Forms.TextBox();
            this.cbPetsAllowed = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumberOfRooms = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFloorSpace = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEstateName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEstateDescription = new System.Windows.Forms.TextBox();
            this.btnBrowsePicture = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPhotoGallery = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbOccupied = new System.Windows.Forms.CheckBox();
            this.btnEstateReport = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(12, 33);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(224, 22);
            this.txtCity.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "City:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Street:";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(12, 79);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.ReadOnly = true;
            this.txtStreet.Size = new System.Drawing.Size(224, 22);
            this.txtStreet.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Estate Type:";
            // 
            // txtEstateType
            // 
            this.txtEstateType.Location = new System.Drawing.Point(12, 124);
            this.txtEstateType.Name = "txtEstateType";
            this.txtEstateType.ReadOnly = true;
            this.txtEstateType.Size = new System.Drawing.Size(224, 22);
            this.txtEstateType.TabIndex = 4;
            // 
            // cbPetsAllowed
            // 
            this.cbPetsAllowed.AutoSize = true;
            this.cbPetsAllowed.Location = new System.Drawing.Point(299, 33);
            this.cbPetsAllowed.Name = "cbPetsAllowed";
            this.cbPetsAllowed.Size = new System.Drawing.Size(117, 21);
            this.cbPetsAllowed.TabIndex = 27;
            this.cbPetsAllowed.Text = "Pets allowed?";
            this.cbPetsAllowed.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Number Of Rooms:";
            // 
            // txtNumberOfRooms
            // 
            this.txtNumberOfRooms.Location = new System.Drawing.Point(12, 305);
            this.txtNumberOfRooms.Name = "txtNumberOfRooms";
            this.txtNumberOfRooms.Size = new System.Drawing.Size(224, 22);
            this.txtNumberOfRooms.TabIndex = 25;
            this.txtNumberOfRooms.Validating += new System.ComponentModel.CancelEventHandler(this.txtNumberOfRooms_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Floor Space:";
            // 
            // txtFloorSpace
            // 
            this.txtFloorSpace.Location = new System.Drawing.Point(12, 260);
            this.txtFloorSpace.Name = "txtFloorSpace";
            this.txtFloorSpace.Size = new System.Drawing.Size(224, 22);
            this.txtFloorSpace.TabIndex = 23;
            this.txtFloorSpace.Validating += new System.ComponentModel.CancelEventHandler(this.txtFloorSpace_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(12, 215);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(224, 22);
            this.txtPrice.TabIndex = 21;
            this.txtPrice.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrice_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Estate Name:";
            // 
            // txtEstateName
            // 
            this.txtEstateName.Location = new System.Drawing.Point(12, 169);
            this.txtEstateName.Name = "txtEstateName";
            this.txtEstateName.Size = new System.Drawing.Size(224, 22);
            this.txtEstateName.TabIndex = 19;
            this.txtEstateName.Validating += new System.ComponentModel.CancelEventHandler(this.txtEstateName_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Estate Description:";
            // 
            // txtEstateDescription
            // 
            this.txtEstateDescription.Location = new System.Drawing.Point(16, 389);
            this.txtEstateDescription.Multiline = true;
            this.txtEstateDescription.Name = "txtEstateDescription";
            this.txtEstateDescription.Size = new System.Drawing.Size(784, 69);
            this.txtEstateDescription.TabIndex = 28;
            this.txtEstateDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txtEstateDescription_Validating);
            // 
            // btnBrowsePicture
            // 
            this.btnBrowsePicture.Location = new System.Drawing.Point(422, 325);
            this.btnBrowsePicture.Name = "btnBrowsePicture";
            this.btnBrowsePicture.Size = new System.Drawing.Size(165, 26);
            this.btnBrowsePicture.TabIndex = 31;
            this.btnBrowsePicture.Text = "Browse Picture";
            this.btnBrowsePicture.UseVisualStyleBackColor = true;
            this.btnBrowsePicture.Click += new System.EventHandler(this.btnBrowsePicture_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(422, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 286);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(633, 464);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(163, 26);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Update";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPhotoGallery
            // 
            this.btnPhotoGallery.Location = new System.Drawing.Point(633, 325);
            this.btnPhotoGallery.Name = "btnPhotoGallery";
            this.btnPhotoGallery.Size = new System.Drawing.Size(163, 26);
            this.btnPhotoGallery.TabIndex = 33;
            this.btnPhotoGallery.Text = "Photo Gallery";
            this.btnPhotoGallery.UseVisualStyleBackColor = true;
            this.btnPhotoGallery.Click += new System.EventHandler(this.btnPhotoGallery_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(16, 464);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(163, 26);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbOccupied
            // 
            this.cbOccupied.AutoSize = true;
            this.cbOccupied.Location = new System.Drawing.Point(299, 64);
            this.cbOccupied.Name = "cbOccupied";
            this.cbOccupied.Size = new System.Drawing.Size(98, 21);
            this.cbOccupied.TabIndex = 35;
            this.cbOccupied.Text = "Occupied?";
            this.cbOccupied.UseVisualStyleBackColor = true;
            // 
            // btnEstateReport
            // 
            this.btnEstateReport.Location = new System.Drawing.Point(633, 357);
            this.btnEstateReport.Name = "btnEstateReport";
            this.btnEstateReport.Size = new System.Drawing.Size(163, 26);
            this.btnEstateReport.TabIndex = 36;
            this.btnEstateReport.Text = "Estate Report";
            this.btnEstateReport.UseVisualStyleBackColor = true;
            this.btnEstateReport.Click += new System.EventHandler(this.btnEstateReport_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmEstateDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 493);
            this.Controls.Add(this.btnEstateReport);
            this.Controls.Add(this.cbOccupied);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnPhotoGallery);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBrowsePicture);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEstateDescription);
            this.Controls.Add(this.cbPetsAllowed);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNumberOfRooms);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFloorSpace);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEstateName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEstateType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCity);
            this.Name = "frmEstateDetails";
            this.Text = "frmEstateDetails";
            this.Load += new System.EventHandler(this.frmEstateDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEstateType;
        private System.Windows.Forms.CheckBox cbPetsAllowed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumberOfRooms;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFloorSpace;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEstateName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEstateDescription;
        private System.Windows.Forms.Button btnBrowsePicture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPhotoGallery;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox cbOccupied;
        private System.Windows.Forms.Button btnEstateReport;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}