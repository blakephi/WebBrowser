using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class CustomControls : UserControl
    {
        public CustomControls()
        {
            InitializeComponent();
        }

        private void AddressBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Navigate(AddressBox.Text);
            }
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            Navigate(AddressBox.Text);
        }

        private void Navigate(String address)
        {
            if (String.IsNullOrEmpty(address)) return;
            if (address.Equals("about:blank")) return;
            if (!address.StartsWith("http://") && !address.StartsWith("https://"))
            {
                address = "http://" + address;
            }

            try
            {
                WebBrowserControl.Navigate(new Uri(address));
            }
            catch (System.UriFormatException)
            {
                return;
            }
        }

        private void WebBrowserControl_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            AddressBox.Text = WebBrowserControl.Url.ToString();
        }
    }


}
