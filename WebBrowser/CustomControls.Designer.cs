
namespace WebBrowser
{
    partial class CustomControls
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomControls));
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.BackButton = new System.Windows.Forms.ToolStripButton();
            this.ForwardButton = new System.Windows.Forms.ToolStripButton();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.HomeButton = new System.Windows.Forms.ToolStripButton();
            this.AddressBox = new System.Windows.Forms.ToolStripTextBox();
            this.GoButton = new System.Windows.Forms.ToolStripButton();
            this.BookmarkButton = new System.Windows.Forms.ToolStripButton();
            this.WebBrowserControl = new System.Windows.Forms.WebBrowser();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.loadingBar = new System.Windows.Forms.ToolStripProgressBar();
            this.loadingText = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStrip
            // 
            this.ToolStrip.CanOverflow = false;
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackButton,
            this.ForwardButton,
            this.RefreshButton,
            this.HomeButton,
            this.AddressBox,
            this.GoButton,
            this.BookmarkButton});
            this.ToolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(901, 33);
            this.ToolStrip.TabIndex = 3;
            this.ToolStrip.Text = "toolStrip1";
            // 
            // BackButton
            // 
            this.BackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(34, 28);
            this.BackButton.Text = "toolStripButton1";
            this.BackButton.ToolTipText = "Back";
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ForwardButton
            // 
            this.ForwardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ForwardButton.Image = ((System.Drawing.Image)(resources.GetObject("ForwardButton.Image")));
            this.ForwardButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(34, 28);
            this.ForwardButton.Text = "toolStripButton2";
            this.ForwardButton.ToolTipText = "Forward";
            this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButton.Image")));
            this.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(34, 28);
            this.RefreshButton.Text = "toolStripButton3";
            this.RefreshButton.ToolTipText = "Refresh";
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(34, 28);
            this.HomeButton.Text = "toolStripButton4";
            this.HomeButton.ToolTipText = "Home";
            // 
            // AddressBox
            // 
            this.AddressBox.AcceptsReturn = true;
            this.AddressBox.AcceptsTab = true;
            this.AddressBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddressBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(520, 31);
            this.AddressBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddressBox_KeyDown);
            // 
            // GoButton
            // 
            this.GoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GoButton.Image = ((System.Drawing.Image)(resources.GetObject("GoButton.Image")));
            this.GoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(34, 28);
            this.GoButton.Text = "toolStripButton5";
            this.GoButton.ToolTipText = "Go";
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // BookmarkButton
            // 
            this.BookmarkButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BookmarkButton.Image = ((System.Drawing.Image)(resources.GetObject("BookmarkButton.Image")));
            this.BookmarkButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BookmarkButton.Name = "BookmarkButton";
            this.BookmarkButton.Size = new System.Drawing.Size(34, 28);
            this.BookmarkButton.Text = "toolStripButton6";
            this.BookmarkButton.ToolTipText = "Bookmark";
            this.BookmarkButton.Click += new System.EventHandler(this.BookmarkButton_Click);
            // 
            // WebBrowserControl
            // 
            this.WebBrowserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebBrowserControl.Location = new System.Drawing.Point(0, 33);
            this.WebBrowserControl.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBrowserControl.Name = "WebBrowserControl";
            this.WebBrowserControl.Size = new System.Drawing.Size(901, 763);
            this.WebBrowserControl.TabIndex = 4;
            this.WebBrowserControl.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WebBrowserControl_DocumentCompleted);
            this.WebBrowserControl.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.WebBrowserControl_Navigating);
            this.WebBrowserControl.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.WebBrowserControl_ProgressChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadingBar,
            this.loadingText});
            this.statusStrip1.Location = new System.Drawing.Point(0, 764);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(901, 32);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "StatusStrip";
            // 
            // loadingBar
            // 
            this.loadingBar.Name = "loadingBar";
            this.loadingBar.Size = new System.Drawing.Size(175, 24);
            // 
            // loadingText
            // 
            this.loadingText.Name = "loadingText";
            this.loadingText.Size = new System.Drawing.Size(55, 25);
            this.loadingText.Text = "Done";
            // 
            // CustomControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.WebBrowserControl);
            this.Controls.Add(this.ToolStrip);
            this.Name = "CustomControls";
            this.Size = new System.Drawing.Size(901, 796);
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripButton BackButton;
        private System.Windows.Forms.ToolStripButton ForwardButton;
        private System.Windows.Forms.ToolStripButton RefreshButton;
        private System.Windows.Forms.ToolStripButton HomeButton;
        private System.Windows.Forms.ToolStripTextBox AddressBox;
        private System.Windows.Forms.ToolStripButton GoButton;
        private System.Windows.Forms.ToolStripButton BookmarkButton;
        private System.Windows.Forms.WebBrowser WebBrowserControl;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar loadingBar;
        private System.Windows.Forms.ToolStripStatusLabel loadingText;
    }
}
