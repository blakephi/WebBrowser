
namespace WebBrowser
{
    partial class HistoryManagerForm
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
            this.historyBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // historyBox
            // 
            this.historyBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyBox.FormattingEnabled = true;
            this.historyBox.ItemHeight = 20;
            this.historyBox.Location = new System.Drawing.Point(0, 0);
            this.historyBox.Name = "historyBox";
            this.historyBox.Size = new System.Drawing.Size(800, 450);
            this.historyBox.TabIndex = 0;
            // 
            // HistoryManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.historyBox);
            this.Name = "HistoryManagerForm";
            this.Text = "History Manager";
            this.Load += new System.EventHandler(this.HistoryManagerForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox historyBox;
    }
}