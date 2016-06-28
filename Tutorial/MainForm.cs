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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnChapter1_Click(object sender, EventArgs e)
        {
            fmStringBulider fmCahpter = new fmStringBulider();
            fmCahpter.Show();
        }

        private void btnChapter2_Click(object sender, EventArgs e)
        {
            ValueVariable fmChapter = new ValueVariable();
            fmChapter.Show();
        }

        private void btnChapter3_Click(object sender, EventArgs e)
        {
            fmChapter3 fmChapter = new fmChapter3();
            fmChapter.Show();
        }

        private void btnChapter4_Click(object sender, EventArgs e)
        {

        }
    }
}
