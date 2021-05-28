
namespace eHousing.WinUI
{
    partial class frmIndex
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.getToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.estateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estateTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEstateTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getEstateTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.estateAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getEstateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myEstatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topThreeEstatesWithMostRentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastFiveEstateRentersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estateDetailsReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 532);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(843, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(49, 20);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.cityToolStripMenuItem,
            this.estateToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.editProfileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(843, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getToolStripMenuItem,
            this.addToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // getToolStripMenuItem
            // 
            this.getToolStripMenuItem.Name = "getToolStripMenuItem";
            this.getToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.getToolStripMenuItem.Text = "Get";
            this.getToolStripMenuItem.Click += new System.EventHandler(this.getToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // cityToolStripMenuItem
            // 
            this.cityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.getToolStripMenuItem1});
            this.cityToolStripMenuItem.Name = "cityToolStripMenuItem";
            this.cityToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.cityToolStripMenuItem.Text = "City";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(120, 26);
            this.addToolStripMenuItem1.Text = "Add";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // getToolStripMenuItem1
            // 
            this.getToolStripMenuItem1.Name = "getToolStripMenuItem1";
            this.getToolStripMenuItem1.Size = new System.Drawing.Size(120, 26);
            this.getToolStripMenuItem1.Text = "Get";
            this.getToolStripMenuItem1.Click += new System.EventHandler(this.getToolStripMenuItem1_Click);
            // 
            // estateToolStripMenuItem
            // 
            this.estateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estateTypeToolStripMenuItem,
            this.estateToolStripMenuItem1});
            this.estateToolStripMenuItem.Name = "estateToolStripMenuItem";
            this.estateToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.estateToolStripMenuItem.Text = "Estate";
            // 
            // estateTypeToolStripMenuItem
            // 
            this.estateTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEstateTypeToolStripMenuItem,
            this.getEstateTypeToolStripMenuItem});
            this.estateTypeToolStripMenuItem.Name = "estateTypeToolStripMenuItem";
            this.estateTypeToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.estateTypeToolStripMenuItem.Text = "Estate Type";
            // 
            // addEstateTypeToolStripMenuItem
            // 
            this.addEstateTypeToolStripMenuItem.Name = "addEstateTypeToolStripMenuItem";
            this.addEstateTypeToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.addEstateTypeToolStripMenuItem.Text = "Add Estate Type";
            this.addEstateTypeToolStripMenuItem.Click += new System.EventHandler(this.addEstateTypeToolStripMenuItem_Click);
            // 
            // getEstateTypeToolStripMenuItem
            // 
            this.getEstateTypeToolStripMenuItem.Name = "getEstateTypeToolStripMenuItem";
            this.getEstateTypeToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.getEstateTypeToolStripMenuItem.Text = "Get Estate Type";
            this.getEstateTypeToolStripMenuItem.Click += new System.EventHandler(this.getEstateTypeToolStripMenuItem_Click);
            // 
            // estateToolStripMenuItem1
            // 
            this.estateToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estateAddToolStripMenuItem,
            this.getEstateToolStripMenuItem,
            this.myEstatesToolStripMenuItem});
            this.estateToolStripMenuItem1.Name = "estateToolStripMenuItem1";
            this.estateToolStripMenuItem1.Size = new System.Drawing.Size(167, 26);
            this.estateToolStripMenuItem1.Text = "Estate";
            // 
            // estateAddToolStripMenuItem
            // 
            this.estateAddToolStripMenuItem.Name = "estateAddToolStripMenuItem";
            this.estateAddToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.estateAddToolStripMenuItem.Text = "Add Estate";
            this.estateAddToolStripMenuItem.Click += new System.EventHandler(this.estateAddToolStripMenuItem_Click);
            // 
            // getEstateToolStripMenuItem
            // 
            this.getEstateToolStripMenuItem.Name = "getEstateToolStripMenuItem";
            this.getEstateToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.getEstateToolStripMenuItem.Text = "Get Estate";
            this.getEstateToolStripMenuItem.Click += new System.EventHandler(this.getEstateToolStripMenuItem_Click);
            // 
            // myEstatesToolStripMenuItem
            // 
            this.myEstatesToolStripMenuItem.Name = "myEstatesToolStripMenuItem";
            this.myEstatesToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.myEstatesToolStripMenuItem.Text = "My Estates";
            this.myEstatesToolStripMenuItem.Click += new System.EventHandler(this.myEstatesToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topThreeEstatesWithMostRentsToolStripMenuItem,
            this.lastFiveEstateRentersToolStripMenuItem,
            this.estateDetailsReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // topThreeEstatesWithMostRentsToolStripMenuItem
            // 
            this.topThreeEstatesWithMostRentsToolStripMenuItem.Name = "topThreeEstatesWithMostRentsToolStripMenuItem";
            this.topThreeEstatesWithMostRentsToolStripMenuItem.Size = new System.Drawing.Size(310, 26);
            this.topThreeEstatesWithMostRentsToolStripMenuItem.Text = "Top three estates with most rents";
            this.topThreeEstatesWithMostRentsToolStripMenuItem.Click += new System.EventHandler(this.topThreeEstatesWithMostRentsToolStripMenuItem_Click);
            // 
            // lastFiveEstateRentersToolStripMenuItem
            // 
            this.lastFiveEstateRentersToolStripMenuItem.Name = "lastFiveEstateRentersToolStripMenuItem";
            this.lastFiveEstateRentersToolStripMenuItem.Size = new System.Drawing.Size(310, 26);
            this.lastFiveEstateRentersToolStripMenuItem.Text = "Last five estate renters";
            this.lastFiveEstateRentersToolStripMenuItem.Click += new System.EventHandler(this.lastFiveEstateRentersToolStripMenuItem_Click);
            // 
            // estateDetailsReportToolStripMenuItem
            // 
            this.estateDetailsReportToolStripMenuItem.Name = "estateDetailsReportToolStripMenuItem";
            this.estateDetailsReportToolStripMenuItem.Size = new System.Drawing.Size(310, 26);
            this.estateDetailsReportToolStripMenuItem.Text = "Estate details";
            this.estateDetailsReportToolStripMenuItem.Click += new System.EventHandler(this.estateDetailsReportToolStripMenuItem_Click);
            // 
            // editProfileToolStripMenuItem
            // 
            this.editProfileToolStripMenuItem.Name = "editProfileToolStripMenuItem";
            this.editProfileToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.editProfileToolStripMenuItem.Text = "Edit profile";
            this.editProfileToolStripMenuItem.Click += new System.EventHandler(this.editProfileToolStripMenuItem_Click);
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 558);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmIndex";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmIndex_FormClosing);
            this.Load += new System.EventHandler(this.frmIndex_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem getToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem estateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estateTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addEstateTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getEstateTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estateAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getEstateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myEstatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topThreeEstatesWithMostRentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lastFiveEstateRentersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estateDetailsReportToolStripMenuItem;
    }
}



