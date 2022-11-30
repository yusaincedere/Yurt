using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yurt
{
    public partial class custom_dialog : Form
    {
        public custom_dialog()
        {
            InitializeComponent();
        }

        private void custom_dialog_Load(object sender, EventArgs e)
        {
            bunifuTransition1.Show(this);
        }

        private void icon_Click(object sender, EventArgs e)
        {

        }
    }
}
