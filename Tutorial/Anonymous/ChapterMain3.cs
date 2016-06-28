using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial
{
    public partial class fmChapter3 : Form
    {
        public fmChapter3()
        {
            InitializeComponent();
        }

        private void btnChapter3_Click(object sender, EventArgs e)
        {
            propfull fmChapter = new propfull();
            fmChapter.Show();
        }

        private void btnChapter3_1_Click(object sender, EventArgs e)
        {
            fmAnonymous fmChapter = new fmAnonymous();
            fmChapter.Show();
        }
    }
}
