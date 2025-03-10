namespace SimpleFormsAppWithListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtbox.Text))
            {
               lstbox.Items.Add(txtbox.Text);
                
            }
            else
            {
                MessageBox.Show("Please enter a programming language name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lstbox.SelectedItem != null)
            {
                lstbox.Items.Remove(lstbox.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select a programming language to remove.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                lstbox.Items.Clear();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
