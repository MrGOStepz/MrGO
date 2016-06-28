using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Tutorial
{
    public partial class ValueVariable : Form
    {
        public ValueVariable()
        {
            InitializeComponent();
        }

        //EnvironmentVariableTarget _Machine = EnvironmentVariableTarget.Machine;
        EnvironmentVariableTarget _Process = EnvironmentVariableTarget.Process;
        //EnvironmentVariableTarget _User = EnvironmentVariableTarget.User;

        private void Chapter2_Load(object sender, EventArgs e)
        {
            //Interaction Don't forget to add References using Microsoft.VisualBasic;
            MessageBox.Show("UserName : " + Interaction.Environ("USERNAME") + Environment.NewLine +
                "ComputerName : " + Interaction.Environ("COMPUTERNAME"), "ค่าที่อ่านได้");
            for (int i = 1; i < 255; i++)
            {
                if (Interaction.Environ(i).Length == 0)
                {
                    break;
                }

                ListViewItem lvItem = new ListViewItem(Interaction.Environ(i).Split('=')[0]);
                lvItem.SubItems.Add(Interaction.Environ(i).Split('=')[1]);
                lvGetAll.Items.Add(lvItem);
            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            Console.Write("Hello");
            txtNameVar.Text = Environment.GetEnvironmentVariable(txtValueVar.Text, _Process);
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            //Environment.SetEnvironmentVariable(txtNameVar.Text, txtValueVar.Text, _Process);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

        }

    }
}
