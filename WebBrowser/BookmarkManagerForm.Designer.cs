
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bookmarkSearch = new System.Windows.Forms.Button();
            this.bookmarkClear = new System.Windows.Forms.Button();
            this.bookmarkDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bookmarkBox
            // 
            this.bookmarkBox.FormattingEnabled = true;
            this.bookmarkBox.ItemHeight = 20;
            this.bookmarkBox.Location = new System.Drawing.Point(0, 60);
            this.bookmarkBox.Name = "bookmarkBox";
            this.bookmarkBox.Size = new System.Drawing.Size(800, 384);
            this.bookmarkBox.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 26);
            this.textBox1.TabIndex = 1;
            // 
            // bookmarkSearch
            // 
            this.bookmarkSearch.Location = new System.Drawing.Point(201, 12);
            this.bookmarkSearch.Name = "bookmarkSearch";
            this.bookmarkSearch.Size = new System.Drawing.Size(75, 28);
            this.bookmarkSearch.TabIndex = 2;
            this.bookmarkSearch.Text = "Search";
            this.bookmarkSearch.UseVisualStyleBackColor = true;
            this.bookmarkSearch.Click += new System.EventHandler(this.bookmarkSearch_Click);
            // 
            // bookmarkClear
            // 
            this.bookmarkClear.Location = new System.Drawing.Point(713, 12);
            this.bookmarkClear.Name = "bookmarkClear";
            this.bookmarkClear.Size = new System.Drawing.Size(75, 28);
            this.bookmarkClear.TabIndex = 3;
            this.bookmarkClear.Text = "Clear";
            this.bookmarkClear.UseVisualStyleBackColor = true;
            // 
            // bookmarkDelete
            // 
            this.bookmarkDelete.Location = new System.Drawing.Point(632, 12);
            this.bookmarkDelete.Name = "bookmarkDelete";
            this.bookmarkDelete.Size = new System.Drawing.Size(75, 28);
            this.bookmarkDelete.TabIndex = 4;
            this.bookmarkDelete.Text = "Delete";
            this.bookmarkDelete.UseVisualStyleBackColor = true;
            // 
            // BookmarkManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bookmarkDelete);
            this.Controls.Add(this.bookmarkClear);
            this.Controls.Add(this.bookmarkSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bookmarkBox);
            this.Name = "BookmarkManagerForm";
            this.Text = "BookmarkManagerForm";
            this.Load += new System.EventHandler(this.BookmarkManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox bookmarkBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bookmarkSearch;
        private System.Windows.Forms.Button bookmarkClear;
        private System.Windows.Forms.Button bookmarkDelete;
    }
}