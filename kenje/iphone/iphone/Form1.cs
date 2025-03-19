namespace iPhone
#nullable disable
{ 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (listBox1.SelectedItem == null || comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Choose an iPhone model and a loan term.");
                    return;
                }

                string selectedModel = listBox1.SelectedItem.ToString();
                double principalAmount = GetIphonePrice(selectedModel);

                string selectedLoanTerm = comboBox1.SelectedItem.ToString();
                int loanTerm = int.Parse(new string(selectedLoanTerm.Where(char.IsDigit).ToArray()));

                double interestRate = GetInterestRate(loanTerm);
                double downPayment = principalAmount * 0.10;

                double addOnsCost = 0;
                foreach (object item in checkedListBox1.CheckedItems)
                {
                    addOnsCost += GetAccessoryPrice(item.ToString());
                }

                double totalPrincipal = principalAmount + addOnsCost;
                double interestAmount = totalPrincipal * interestRate;
                double totalAmount = totalPrincipal + interestAmount;
                double monthlyAmortization = totalAmount / loanTerm;

                textBox1.Text = $"Model: {selectedModel}\r\n" +
                $"Principal Amount: Php {principalAmount:N2}\r\n" +
                $"Down Payment: Php {downPayment:N2}\r\n" +
                $"Loan Term: {loanTerm} Months\r\n" +
                $"Interest Rate: {interestRate * 100}%\r\n" +
                $"Interest Amount: Php {interestAmount:N2}\r\n" +
                $"Total Monthly Amortization: Php {monthlyAmortization:N2}\r\n" +
                $"Total Loan Amount: Php {totalAmount:N2}";
            }
        }


        private double GetIphonePrice(string model)
        {
            if (model == "iPhone 16 Pro Max (256GB)") return 69990;
            if (model == "iPhone 16 Pro (128GB)") return 84990;
            if (model == "iPhone 16 Plus (128GB)") return 54990;
            if (model == "iPhone 16 (128GB)") return 62990;
            if (model == "iPhone 16e (128GB)") return 39990;
            return 0;
        }

        private double GetAccessoryPrice(string accessory)
        {
            if (accessory == "Apple Care Plus") return 2590;
            if (accessory == "USB-C Charging Adapter") return 1990;
            if (accessory == "MagSafe Charger (1M)") return 2490;
            return 0;
        }

        private double GetInterestRate(int term)
        {
            if (term == 12) return 0.05;
            if (term == 24) return 0.10;
            if (term == 30) return 0.125;
            if (term == 36) return 0.15;
            return 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("iPhone 16 Pro Max (256GB)");
            listBox1.Items.Add("iPhone 16 Pro (128GB)");
            listBox1.Items.Add("iPhone 16 Plus (128GB)");
            listBox1.Items.Add("iPhone 16 (128GB)");
            listBox1.Items.Add("iPhone 16e (128GB)");

            checkedListBox1.Items.Clear();
            checkedListBox1.Items.Add("Apple Care Plus");
            checkedListBox1.Items.Add("USB-C Charging Adapter");
            checkedListBox1.Items.Add("MagSafe Charger (1M)");

            comboBox1.Items.Clear();
            comboBox1.Items.Add("12 Months");
            comboBox1.Items.Add("24 Months");
            comboBox1.Items.Add("30 Months");
            comboBox1.Items.Add("36 Months");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

