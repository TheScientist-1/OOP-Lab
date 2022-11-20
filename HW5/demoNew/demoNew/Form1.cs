using System.Diagnostics.Metrics;
using System.Security.Policy;

namespace demoNew
{
    
    public partial class Form1 : Form
    {
        public List<Item> Items = new List<Item>();
        public Form1()
        {
           InitializeComponent();
        }
        public void AddBook(string name, string price,  string country, string date, string descr,string number,string publ, string auth)
        {
            Items.Add(new Book() { Name = name, Price = price, CountryOfOrigin = country, PackageDate = date, Description = descr, NumberOfPages = number, Publisher = publ, Authors = auth});
        }
        public void AddProduct(string name, string price, string country, string date, string descr, string exdate, string numb, string unit)
        {
            Items.Add(new Product() { Name = name, Price = price, CountryOfOrigin = country, PackageDate = date, Description = descr, ExpirationDate = exdate, Number = numb, Unit = unit});
        }

        public void DeleteEl()
        {
            if (Items.Count > 0) 
            {
                Items.RemoveAt(0); 
            }
        }

        public void DeleteAll()
        {
            if (Items.Count > 0)
            {
                Items.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProduct(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox9.Text, textBox10.Text, textBox11.Text);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Items;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            AddBook(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Items;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteEl();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Items;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteAll();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Items;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
    
}