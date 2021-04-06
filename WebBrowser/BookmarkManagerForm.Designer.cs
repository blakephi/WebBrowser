
namespace WebBrowser
{
    partial class BookmarkManagerForm
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
            this.bookmarkBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bookmarkBox
            // 
            this.bookmarkBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookmarkBox.FormattingEnabled = true;
            this.bookmarkBox.ItemHeight = 20;
            this.bookmarkBox.Location = new System.Drawing.Point(0, 0);
            this.bookmarkBox.Name = "bookmarkBox";
            this.bookmarkBox.Size = new System.Drawing.Size(800, 450);
            this.bookmarkBox.TabIndex = 0;
            // 
            // BookmarkManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bookmarkBox);
            this.Name = "BookmarkManagerForm";
            this.Text = "BookmarkManagerForm";
            this.Load += new System.EventHandler(this.BookmarkManagerForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox bookmarkBox;
    }
}