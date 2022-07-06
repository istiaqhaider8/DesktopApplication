using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {

        String sName = String.Empty;
        String sAddress = String.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sName = nameTextBox.Text;
            sAddress = addressTextBox.Text;

            nameTextBox.Text = "";
            addressTextBox.Text = "";
            MessageBox.Show("Data has been Save");
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name: " + sName + "\nAddress: " + sAddress);
        }

    }
}
