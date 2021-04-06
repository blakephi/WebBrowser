﻿using System;
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
                AddToHistory();
            }
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            Navigate(AddressBox.Text);
            AddToHistory();
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
            if (backList.Count > 0 && currentURL != backList.Peek())
            {
                forwardList.Push(currentURL);
                currentURL = backList.Peek();
                Navigate(backList.Pop());
            }
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            if (forwardList.Count > 0 && currentURL != forwardList.Peek())
            {
                backList.Push(AddressBox.Text);
                Navigate(forwardList.Pop());
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

        private void AddToHistory()
        {
            if (!WebBrowserControl.IsBusy)
            {
                var historyItem = new HistoryItem();
                var text = new TabPage();
                historyItem.URL = AddressBox.Text;
                historyItem.Title = text.Text;
                historyItem.Date = DateTime.Now;
                HistoryManager.AddItem(historyItem);
            }
        }
    }
}
