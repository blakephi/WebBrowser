
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
            this.historySearchBox = new System.Windows.Forms.TextBox();
            this.historySearchButton = new System.Windows.Forms.Button();
            this.clearHistoryButton = new System.Windows.Forms.Button();
            this.deleteHistoryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // historyBox
            // 
            this.historyBox.FormattingEnabled = true;
            this.historyBox.ItemHeight = 20;
            this.historyBox.Location = new System.Drawing.Point(0, 60);
            this.historyBox.Name = "historyBox";
            this.historyBox.Size = new System.Drawing.Size(800, 384);
            this.historyBox.TabIndex = 0;
            // 
            // historySearchBox
            // 
            this.historySearchBox.Location = new System.Drawing.Point(12, 12);
            this.historySearchBox.Name = "historySearchBox";
            this.historySearchBox.Size = new System.Drawing.Size(223, 26);
            this.historySearchBox.TabIndex = 1;
            // 
            // historySearchButton
            // 
            this.historySearchButton.Location = new System.Drawing.Point(241, 12);
            this.historySearchButton.Name = "historySearchButton";
            this.historySearchButton.Size = new System.Drawing.Size(75, 26);
            this.historySearchButton.TabIndex = 2;
            this.historySearchButton.Text = "Search";
            this.historySearchButton.UseVisualStyleBackColor = true;
            this.historySearchButton.Click += new System.EventHandler(this.historySearchButton_Click);
            // 
            // clearHistoryButton
            // 
            this.clearHistoryButton.Location = new System.Drawing.Point(713, 12);
            this.clearHistoryButton.Name = "clearHistoryButton";
            this.clearHistoryButton.Size = new System.Drawing.Size(75, 26);
            this.clearHistoryButton.TabIndex = 3;
            this.clearHistoryButton.Text = "Clear";
            this.clearHistoryButton.UseVisualStyleBackColor = true;
            this.clearHistoryButton.Click += new System.EventHandler(this.clearHistoryButton_Click);
            // 
            // deleteHistoryButton
            // 
            this.deleteHistoryButton.Location = new System.Drawing.Point(632, 12);
            this.deleteHistoryButton.Name = "deleteHistoryButton";
            this.deleteHistoryButton.Size = new System.Drawing.Size(75, 26);
            this.deleteHistoryButton.TabIndex = 4;
            this.deleteHistoryButton.Text = "Delete";
            this.deleteHistoryButton.UseVisualStyleBackColor = true;
            this.deleteHistoryButton.Click += new System.EventHandler(this.deleteHistoryButton_Click);
            // 
            // HistoryManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteHistoryButton);
            this.Controls.Add(this.clearHistoryButton);
            this.Controls.Add(this.historySearchButton);
            this.Controls.Add(this.historySearchBox);
            this.Controls.Add(this.historyBox);
            this.Name = "HistoryManagerForm";
            this.Text = "History Manager";
            this.Load += new System.EventHandler(this.HistoryManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox historyBox;
        private System.Windows.Forms.TextBox historySearchBox;
        private System.Windows.Forms.Button historySearchButton;
        private System.Windows.Forms.Button clearHistoryButton;
        private System.Windows.Forms.Button deleteHistoryButton;
    }
}