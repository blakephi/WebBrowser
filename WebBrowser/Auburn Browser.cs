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
    public partial class WebBrowser : Form
    {
        public WebBrowser()
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
            MessageBox.Show($"<div>Icons made by <a href=https://www.freepik.com title=Freepik>Freepik</a> from <a href=https://www.flaticon.com/ title=Flaticon>www.flaticon.com</a></div>");
        }
    }
}
