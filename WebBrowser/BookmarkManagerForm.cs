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
    public partial class BookmarkManagerForm : Form
    {
        public BookmarkManagerForm()
        {
            InitializeComponent();
        }

        private void BookmarkManagerForm_Load(object sender, EventArgs e)
        {
            var items = BookmarkManager.GetItems();
            bookmarkBox.Items.Clear();

            foreach (var item in items)
            {
                bookmarkBox.Items.Add(string.Format("{1} ({2})", item.Title, item.URL));
            }
        }

        private void bookmarkSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
