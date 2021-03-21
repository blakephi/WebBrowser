namespace WebBrowser
{
    partial class WebBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebBrowser));
            this.WebBrowserControl = new System.Windows.Forms.WebBrowser();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeCurrentTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageBookmarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackButton = new System.Windows.Forms.ToolStripButton();
            this.ForwardButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.HomeButton = new System.Windows.Forms.ToolStripButton();
            this.AddressBox = new System.Windows.Forms.ToolStripTextBox();
            this.GoButton = new System.Windows.Forms.ToolStripButton();
            this.BookmarkButton = new System.Windows.Forms.ToolStripButton();
            this.iconAttributionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TabControl.SuspendLayout();
            this.ToolStrip.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // WebBrowserControl
            // 
            this.WebBrowserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebBrowserControl.Location = new System.Drawing.Point(0, 0);
            this.WebBrowserControl.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBrowserControl.Name = "WebBrowserControl";
            this.WebBrowserControl.Size = new System.Drawing.Size(800, 450);
            this.WebBrowserControl.TabIndex = 0;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(800, 450);
            this.TabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ToolStrip
            // 
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackButton,
            this.ForwardButton,
            this.RefreshButton,
            this.HomeButton,
            this.AddressBox,
            this.GoButton,
            this.BookmarkButton});
            this.ToolStrip.Location = new System.Drawing.Point(0, 36);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(800, 38);
            this.ToolStrip.TabIndex = 2;
            this.ToolStrip.Text = "toolStrip1";
            // 
            // MenuStrip
            // 
            this.MenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(800, 36);
            this.MenuStrip.TabIndex = 3;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTabToolStripMenuItem,
            this.closeCurrentTabToolStripMenuItem,
            this.printPageToolStripMenuItem,
            this.exitBrowserToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 32);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageHistoryToolStripMenuItem,
            this.manageBookmarksToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(69, 32);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 32);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // newTabToolStripMenuItem
            // 
            this.newTabToolStripMenuItem.Name = "newTabToolStripMenuItem";
            this.newTabToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.newTabToolStripMenuItem.Text = "New Tab";
            // 
            // closeCurrentTabToolStripMenuItem
            // 
            this.closeCurrentTabToolStripMenuItem.Name = "closeCurrentTabToolStripMenuItem";
            this.closeCurrentTabToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.closeCurrentTabToolStripMenuItem.Text = "Close Current Tab";
            // 
            // printPageToolStripMenuItem
            // 
            this.printPageToolStripMenuItem.Name = "printPageToolStripMenuItem";
            this.printPageToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.printPageToolStripMenuItem.Text = "Print Page";
            // 
            // exitBrowserToolStripMenuItem
            // 
            this.exitBrowserToolStripMenuItem.Name = "exitBrowserToolStripMenuItem";
            this.exitBrowserToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.exitBrowserToolStripMenuItem.Text = "Exit Browser";
            this.exitBrowserToolStripMenuItem.Click += new System.EventHandler(this.exitBrowserToolStripMenuItem_Click);
            // 
            // manageHistoryToolStripMenuItem
            // 
            this.manageHistoryToolStripMenuItem.Name = "manageHistoryToolStripMenuItem";
            this.manageHistoryToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            this.manageHistoryToolStripMenuItem.Text = "Manage History";
            // 
            // manageBookmarksToolStripMenuItem
            // 
            this.manageBookmarksToolStripMenuItem.Name = "manageBookmarksToolStripMenuItem";
            this.manageBookmarksToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            this.manageBookmarksToolStripMenuItem.Text = "Manage Bookmarks";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconAttributionToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // BackButton
            // 
            this.BackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(34, 33);
            this.BackButton.Text = "toolStripButton1";
            // 
            // ForwardButton
            // 
            this.ForwardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ForwardButton.Image = ((System.Drawing.Image)(resources.GetObject("ForwardButton.Image")));
            this.ForwardButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(34, 33);
            this.ForwardButton.Text = "toolStripButton2";
            // 
            // RefreshButton
            // 
            this.RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButton.Image")));
            this.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(34, 33);
            this.RefreshButton.Text = "toolStripButton3";
            // 
            // HomeButton
            // 
            this.HomeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(34, 33);
            this.HomeButton.Text = "toolStripButton4";
            // 
            // AddressBox
            // 
            this.AddressBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(520, 38);
            // 
            // GoButton
            // 
            this.GoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GoButton.Image = ((System.Drawing.Image)(resources.GetObject("GoButton.Image")));
            this.GoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(34, 33);
            this.GoButton.Text = "toolStripButton5";
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // BookmarkButton
            // 
            this.BookmarkButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BookmarkButton.Image = ((System.Drawing.Image)(resources.GetObject("BookmarkButton.Image")));
            this.BookmarkButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BookmarkButton.Name = "BookmarkButton";
            this.BookmarkButton.Size = new System.Drawing.Size(34, 33);
            this.BookmarkButton.Text = "toolStripButton6";
            // 
            // iconAttributionToolStripMenuItem
            // 
            this.iconAttributionToolStripMenuItem.Name = "iconAttributionToolStripMenuItem";
            this.iconAttributionToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.iconAttributionToolStripMenuItem.Text = "Icon Attribution";
            this.iconAttributionToolStripMenuItem.Click += new System.EventHandler(this.iconAttributionToolStripMenuItem_Click);
            // 
            // WebBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.WebBrowserControl);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "WebBrowser";
            this.Text = "Auburn Browser";
            this.TabControl.ResumeLayout(false);
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser WebBrowserControl;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeCurrentTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitBrowserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageBookmarksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton BackButton;
        private System.Windows.Forms.ToolStripButton ForwardButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton HomeButton;
        private System.Windows.Forms.ToolStripTextBox AddressBox;
        private System.Windows.Forms.ToolStripButton GoButton;
        private System.Windows.Forms.ToolStripButton BookmarkButton;
        private System.Windows.Forms.ToolStripMenuItem iconAttributionToolStripMenuItem;
    }
}

