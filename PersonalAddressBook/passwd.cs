using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalAddressBook
{
    public partial class passwd : Form
    {
        public passwd()
        {
            InitializeComponent();
        }

        //initialize global variables
        public string input;

        private void btnOk_Click(object sender, EventArgs e)
        {
            //set inputted to true
            DialogResult = DialogResult.OK;

            //set input
            input = txtInput.Text;

            //close form
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //set inputted to false
            DialogResult = DialogResult.Cancel;

            //close form
            Close();
        }

        public string labelText
        {
            get { return lblPrompt.Text; }
            set { lblPrompt.Text = value; }
        }
    }
}
