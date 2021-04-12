using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.Logic;

namespace WebBrowser
{
    public partial class HistoryManagerForm : Form
    {
        public HistoryManagerForm()
        {
            InitializeComponent();
        }

        private void HistoryManagerForm_Load(object sender, EventArgs e)
        {
            var items = HistoryManager.GetItems();
            historyBox.Items.Clear();

            foreach (var item in items)
            {
                historyBox.Items.Add(string.Format("[{0}] {1} ({2})", item.Date, item.Title, item.URL));
            }
        }

        private void historySearchButton_Click(object sender, EventArgs e)
        {
            var items = HistoryManager.GetItems();
            historyBox.Items.Clear();

            foreach (var item in items)
            {
                if (item.Title.Contains(historySearchBox.Text))
                {
                    historyBox.Items.Add(string.Format("[{0}] {1} ({2})", item.Date, item.Title, item.URL));
                }
            }
        }

        private void deleteHistoryButton_Click(object sender, EventArgs e)
        {
            string selected = historyBox.GetItemText(historyBox.SelectedItem);
            HistoryManager.DeleteSelected(selected);
            historyBox.Items.RemoveAt(historyBox.SelectedIndex);
        }

        private void clearHistoryButton_Click(object sender, EventArgs e)
        {
            HistoryManager.ClearHistory();
            historyBox.Items.Clear();
        }
    }
}
