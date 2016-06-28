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
    public partial class propfull : Form
    {
        public propfull()
        {
            InitializeComponent();
        }

        /*
            prop + 2 tab 

            prop :
            public int MyProperty { get; set; }

            propfull :
            private int myVar;

            public int MyProperty
            {
                get { return myVar; }
                set { myVar = value; }
            }

            Read Only = get
            Write Only = set
        */


        private Bank _BankTest;

        private void Chapter3_Load(object sender, EventArgs e)
        {
            _BankTest = new Bank();
            _BankTest.AccountNumber = "316497";
            _BankTest.FullName = "Hundsome";
            _BankTest.Balance = 1000.00;
        }

        private void btnCode_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Account Number : " + _BankTest.AccountNumber + "\n" +
                    "Full Name : " + _BankTest.FullName + "\n" +
                    "Balance : " + _BankTest.Balance, "Test");
        }
    }

    public class Bank
    {
        private string _AccountNumber = "";
        private string _FullName = "";
        private double _Balance = 0.0;

        public string AccountNumber
        {
            get
            {
                return _AccountNumber;
            }

            set
            {
                _AccountNumber = value;
            }
        }

        public string FullName
        {
            get
            {
                return _FullName;
            }

            set
            {
                _FullName = value;
            }
        }

        public double Balance
        {
            get
            {
                return _Balance;
            }

            set
            {
                _Balance = value;
            }
        }

    }
}
