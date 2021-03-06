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
using WebBrowser.Data.WebBrowserDataSetTableAdapters;

namespace WebBrowser
{
    public partial class BookmarkManagerForm : Form
    {
        public BookmarkManagerForm()
        {
            InitializeComponent();
        }

        private void BookmarkManagerForm_Load(object sender, EventArgs e)
        {
            var items = BookmarkManager.BookmarkData();
            //bookmarkBox.Items.Clear();

            foreach (var item in items)
            {
                string bookmark = String.Format("{0} ({1})", item.Title, item.URL);
                bookmarkBox.Items.Add(bookmark);
            }
        }

        private void bookmarkSearch_Click(object sender, EventArgs e)
        {
            var items = BookmarkManager.GetItems();
            bookmarkBox.Items.Clear();

            foreach (var item in items)
            {
                if (item.URL.Contains(bookmarkSearch.Text) || item.Title.Contains(bookmarkSearch.Text))
                {
                    string search = String.Format("{0} ({1})", item.Title, item.URL);
                    bookmarkBox.Items.Add(search);
                }
            }
        }

        private void bookmarkDelete_Click(object sender, EventArgs e)
        {
            string selected = bookmarkBox.GetItemText(bookmarkBox.SelectedItem);
            BookmarkManager.DeleteBookmark(selected);
            bookmarkBox.Items.RemoveAt(bookmarkBox.SelectedIndex);
        }
    }
}
