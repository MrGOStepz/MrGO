using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial
{
    public partial class fmStringBulider : Form
    {
        // Class Stopwatch have to use Libraly using System.Diagnostics;
        public Stopwatch _stopwatch;

        public fmStringBulider()
        {
            InitializeComponent();          
        }

        //Count Time String Bulder;
        private void btnStb_Click(object sender, EventArgs e)
        {
            StringBuilder strb = new StringBuilder();   
            _stopwatch = new Stopwatch();
            _stopwatch.Start();     
            for (int i = 0; i < 10000; i++)
            {
                strb.Append("1");
            }
            _stopwatch.Stop();
            txtTime.Text = _stopwatch.Elapsed.TotalMilliseconds.ToString();

            //Write {0:hh\\:mm\\:ss} format
            //txtTime.Text = String.Format("Time elapsed: {0:hh\\:mm\\:ss}", _stopwatch.Elapsed);
        }

        //Count Time String +
        private void btnPlus_Click(object sender, EventArgs e)
        {
            string strTest = "1";
            _stopwatch = new Stopwatch();
            _stopwatch.Start();
            for (int i = 0; i < 10000; i++)
            {
                strTest += "1";
            }
            _stopwatch.Stop();
            txtTime.Text = _stopwatch.Elapsed.TotalMilliseconds.ToString();
        }
    }
}
