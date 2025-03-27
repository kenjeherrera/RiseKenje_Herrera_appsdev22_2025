using System.Windows.Forms;

namespace SimpleFormsAppWithCheckedListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] movies = { "Simpsons", "Popeyes", "Mr.Bean", "Batman", };
            CheckListBox.Items.AddRange(movies);
            CheckListBox.CheckOnClick = true;
        }

        private void CheckListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddClick_Click(object sender, EventArgs e)
        {
            foreach (var item in CheckListBox.Items)
            {
                bool isSelected = CheckListBox.GetItemChecked(CheckListBox.Items.IndexOf(item));
                if (isSelected && !listBox1.Items.Contains(item))
                {
                    listBox1.Items.Add(item);
                }
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("The list is already empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                listBox1.Items.Clear();
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count >= 0)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }
    }
}

