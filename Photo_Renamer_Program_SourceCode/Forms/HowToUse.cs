using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renaming_Prog.Forms
{
    public partial class HowToUse : Form
    {
        public HowToUse()
        {
            InitializeComponent();
        }

        private void WebSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Aredarn/Photo_Renamer_Program");
        }

        private void WebSite_MouseHover(object sender, EventArgs e)
        {
            WebSite.LinkColor = Color.Black;
        }

        private void WebSite_MouseLeave(object sender, EventArgs e)
        {
            WebSite.LinkColor = Color.DarkGray;
        }
    }
}
