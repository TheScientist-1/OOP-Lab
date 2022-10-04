namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txtName.Text, txtPrice.Text, txtCountry.Text,txtDate.Text, txtDescription.Text, txtExpDate.Text, txtNumber.Text, txtUnit.Text, "-", "-", "-");
        }


        private void IDelete()
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows) 
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            IDelete();
        }

        private void AddBook_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txtName.Text, txtPrice.Text, txtCountry.Text, txtDate.Text, "-", "-", "-", txtUnit.Text, txtNumPages.Text, txtPublisher.Text, txtAuthors.Text);
        }
    }

    internal class Item
    {
        public double Price;
        public string CountryOfOrigin;
        public string ProductName;
        public string PackageDate;
        public string Description;
    }

    class Product : Item
    {
        public string ExpirationDate;
        public int Number;
        public string Unit;

    }

    class Book : Item
    {
        public int NumberOfPages;
        public string Publisher;
        public string Authors;

    }
}