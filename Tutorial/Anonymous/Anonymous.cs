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
    public partial class fmAnonymous : Form
    {
        public fmAnonymous()
        {
            InitializeComponent();
        }


        /*
            If your Declare in Anonymous "Read Only"
        */
        private void btnCode_Click(object sender, EventArgs e)
        {
            var FullName = new { FirstName = "Mr.GO", SurName = "Stepz" };
            MessageBox.Show(String.Format("First Name = {0}\nSurName = {1}\nType = {2}", FullName.FirstName, FullName.SurName,FullName.GetType().ToString()));
        }

        private void btnCode2_Click(object sender, EventArgs e)
        {
            var Myfriend = new[]
            {
                new {FullName = "B1", Salary = 1000},
                new {FullName = "B2", Salary = 2000},
                new {FullName = "B3", Salary = 3000}
            };

            foreach (var m in Myfriend)
            {
                MessageBox.Show(String.Format("FullName = {0}\nSalary = {1}\n", m.FullName, m.Salary));
            }
        }
    }
}
