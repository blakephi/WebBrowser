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
    public partial class CustomControls : UserControl
    {
        public CustomControls()
        {
            InitializeComponent();
        }

        Stack<string> backList = new Stack<string>();
        Stack<string> forwardList = new Stack<string>();
        String currentURL;

        private void AddressBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Navigate(AddressBox.Text);
                AddToHistory(AddressBox.Text);
                loadingBar.Value = 0;
            }
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            Navigate(AddressBox.Text);
            AddToHistory(AddressBox.Text);
            loadingBar.Value = 0;
        }

        private void Navigate(String address)
        {
            if (String.IsNullOrEmpty(address)) return;
            if (address.Equals("about:blank")) return;
            if (!address.StartsWith("http://") && !address.StartsWith("https://"))
            {
                address = "http://" + address;
            }

            NewURL(address);

            try
            {
                WebBrowserControl.Navigate(new Uri(address));
            }
            catch (System.UriFormatException)
            {
                return;
            }
        }

        private void NewURL(String url)
        {
            if (currentURL != "")
            {
                backList.Push(currentURL);
            }

            currentURL = url;
        }

        private void WebBrowserControl_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            AddressBox.Text = WebBrowserControl.Url.ToString();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (WebBrowserControl.CanGoBack == true)
            {
                WebBrowserControl.GoBack();
            }
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            if (WebBrowserControl.CanGoForward == true)
            {
                WebBrowserControl.GoForward();
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            WebBrowserControl.Refresh();
        }

        private void BookmarkButton_Click(object sender, EventArgs e)
        {
            var bookmarkItem = new BookmarkItem();
            var text = new TabPage();
            bookmarkItem.URL = AddressBox.Text;
            bookmarkItem.Title = text.Text;
            BookmarkManager.AddItem(bookmarkItem);
        }

        private void AddToHistory(string address)
        {
            if (/*!WebBrowserControl.IsBusy && */AddressBox.Text != null)
            {
                var historyItem = new HistoryItem();
                var text = new TabPage();
                historyItem.URL = address;
                historyItem.Title = text.Text;
                historyItem.Date = DateTime.Now;
                HistoryManager.AddItem(historyItem);
            }
        }

        private void WebBrowserControl_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            double current = (double)e.CurrentProgress;
            double max = (double)e.CurrentProgress;
            double progress = (current / max) * 100;
            loadingBar.Value = (int)progress;
        }

        private void WebBrowserControl_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            loadingBar.Value = 0;
            loadingBar.Visible = false;
            loadingText.Text = "Done";
        }

        private void WebBrowserControl_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            loadingBar.Visible = true;
            loadingText.Text = "Loading page...";
        }
    }
}
