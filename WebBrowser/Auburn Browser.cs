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
    public partial class BrowserUI : Form
    {
        public BrowserUI()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Auburn browser is developed by Blake Phillips, ID: 904169703 \n" +
                            "This is Blake's first browser based project.");
        }

        private void exitBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconAttributionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All icons gathered from www.flaticon.com \n" +
                            "Go button: https://www.flaticon.com/free-icon/right-arrow-button_1225?term=go%20button&page=1&position=1&page=1&position=1&related_id=1225&origin=search \n" +
                            "All other buttons: https://www.flaticon.com/packs/lineal-interface?k=1616355040627");
        }

        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TabControl.TabPages.Add(new TabPage("New Tab"));
        }

        private void closeCurrentTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TabControl.TabPages.RemoveAt(this.TabControl.SelectedIndex);
        }
    }
}
