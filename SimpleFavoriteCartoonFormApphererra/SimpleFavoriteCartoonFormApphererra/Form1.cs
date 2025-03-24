namespace SimpleFavoriteCartoonFormApphererra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            charcombobox.Items.Add("Spongebob");
            charcombobox.Items.Add("Patrick");
            charcombobox.Items.Add("Mr. Krabs");
            charcombobox.Items.Add("Sandy");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedCharacter = charcombobox.SelectedItem?.ToString() ?? "";
            string imagePath = Path.Combine(Application.StartupPath, "Resources", "Images", "");

            if (selectedCharacter == "Spongebob")
                imagePath = Path.Combine(Application.StartupPath, "Resources", "Images", "spongebob.jpg");
            else if (selectedCharacter == "Patrick")
                imagePath = Path.Combine(Application.StartupPath, "Resources", "Images", "patrick.jpg");
            else if (selectedCharacter == "Mr. Krabs")
                imagePath = Path.Combine(Application.StartupPath, "Resources", "Images", "mrkrabs.png");
            else if (selectedCharacter == "Sandy")
                imagePath = Path.Combine(Application.StartupPath, "Resources", "Images", "sandy.jpg");

            if (System.IO.File.Exists(imagePath))
            {
                imgpicbox.Image = Image.FromFile(imagePath);
            }
            else
            {
                MessageBox.Show("Image not found: " + imagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
