namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            list=new OtList();
        }
        OtList list;
        private void button1_Click(object sender, EventArgs e)
        {
            if (uint.TryParse(textBox1.Text, out uint result))
            {
                listBox1.Items.Clear();
                list = new OtList(result, -100, 100);

                Synchron(listBox1, list);
            }

        }
        private void Synchron(ListBox box, OtList list)
        {
            box.Items.Clear();
            foreach (var item in list.list)
            {
                box.Items.Add(item.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (list.list.Count > 1)
            {
            list.Add10();
            Synchron(listBox1, list);
            }
            
        }
    }
}
