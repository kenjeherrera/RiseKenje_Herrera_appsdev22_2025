using System;
using System.Windows.Forms;

namespace SimpleFormsAppWithMessageBoxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string middleName = txtMiddleName.Text;
            string lastName = txtLastName.Text;
            string suffix = txtSuffix.Text;

            DialogResult result = MessageBox.Show("Are you sure you want to submit?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string message = $"Hello There! {firstName} {middleName} {lastName} {suffix}!";
                MessageBox.Show(message, "Greetings!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
