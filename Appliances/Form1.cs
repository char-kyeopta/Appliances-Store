using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appliances
{
    public partial class PasswordEntryForm : Form
    {
        public PasswordEntryForm()
        {
            InitializeComponent();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == "GWAPO")
            {
                FileForm x = new FileForm();
                x.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Password", "Password Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
