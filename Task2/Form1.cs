namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            stock = new Stock();
        }
        Stock stock;
        private void button1_Click(object sender, EventArgs e)
        {
            if (uint.TryParse(textBox_price.Text, out uint p) & textBox_name.Text != "" & textBox_nameStore.Text != "")
            {
             
                stock.Add(new Product() { name = textBox_name.Text, price = p, storeName = textBox_nameStore.Text });
                sync(stock.GetProducts());
                 textBox_name.Text = ""; textBox_nameStore.Text = ""; textBox_price.Text = "";
            }
        }

        private void sync(List<Product> list)
        {
            dataGridView1.Rows.Clear();
            foreach (Product product in list)
            {
                dataGridView1.Rows.Add(product.name, product.price.ToString(), product.storeName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (stock.GetProducts().Count > 0)
            {
                if (radioButton_name.Checked)
                    sync(stock.SearchByName(textBox_search.Text));
                else if (radioButton_nameStore.Checked)
                    sync(stock.SearchByStoreName(textBox_search.Text));
                else if (radioButton_price.Checked & uint.TryParse(textBox_search.Text, out uint p))
                    sync(stock.SearchByPrice(p));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sync(stock.GetProducts());
        }
    }
}
