namespace SimpleFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string middleName = txtMiddleName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string suffix = txtSuffix.Text.Trim();

           
            string fullName = $"{firstName} {middleName} {lastName}";
            if (!string.IsNullOrEmpty(suffix))
            {
                fullName += $", {suffix}";
            }

            MessageBox.Show($"Hello there {fullName}!", "Greeting", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    

