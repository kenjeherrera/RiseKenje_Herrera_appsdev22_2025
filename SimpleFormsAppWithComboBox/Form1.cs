namespace SimpleFormsAppWithComboBox
{
    public partial class Form1 : Form
    {
        private Dictionary<string, List<string>> cuisineFoods = new Dictionary<string, List<string>>()
        {
            { "Filipino", new List<string> { "Adobo", "Sinigang", "Lechon", "Pancit", "Halo-Halo" } },
            { "Italian", new List<string> { "Pizza", "Pasta", "Lasagna", "Tiramisu", "Risotto" } },
            { "Japanese", new List<string> { "Sushi", "Ramen", "Tempura", "Takoyaki", "Katsudon" } }
        };
        public Form1()
        {
            InitializeComponent();
            InitializeCuisineComboBox();
        }
        private void InitializeCuisineComboBox()
        {
            cmbCuisine.Items.AddRange(cuisineFoods.Keys.ToArray());
            cmbCuisine.SelectedIndex = 0; // Default selection
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            clbFoodItems.Items.Clear();
            string selectedCuisine = cmbCuisine.SelectedItem.ToString();

            if (cuisineFoods.ContainsKey(selectedCuisine))
            {
                clbFoodItems.Items.AddRange(cuisineFoods[selectedCuisine].ToArray());
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            foreach (var item in clbFoodItems.CheckedItems)
            {
                if (!lstSelectedFoods.Items.Contains(item))
                {
                    lstSelectedFoods.Items.Add(item);
                }
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            while (lstSelectedFoods.SelectedItems.Count > 0)
            {
                lstSelectedFoods.Items.Remove(lstSelectedFoods.SelectedItem);
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            lstSelectedFoods.Items.Clear();
        }
    }
}
