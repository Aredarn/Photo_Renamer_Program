using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renaming_Prog
{
    public partial class Info_Form : Form
    {
        public Info_Form()
        {
            InitializeComponent();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
