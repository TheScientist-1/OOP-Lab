using System.Drawing;
using System.Text.Json.Serialization;
using static System.Reflection.Metadata.BlobBuilder;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        public void RefreshValues(List<Book> books)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = books;
        }
        
        bool saved=false;

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            AddElementForm f2 = new AddElementForm(this);
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           ChangeElementForm f3 = new ChangeElementForm(this);
           f3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteByCodeForm f4 = new DeleteByCodeForm(this);
            f4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Helper.books.Count > 0)
            {
                Helper.books.Clear();
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Helper.books;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Helper.LinqSortedBooks = Helper.Data.ToList();
            if (checkedListBox1.GetItemChecked(0)) Helper.LinqSortedBooks = SearcherLINQ.SearchByAuthor(textBox1.Text, Helper.LinqSortedBooks).ToList();
            if (checkedListBox1.GetItemChecked(1))
            {   int year;
                if (!int.TryParse(textBox2.Text, out year))
                { MessageBox.Show("Input data must be int type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  return;}
                Helper.LinqSortedBooks = SearcherLINQ.SearchByYear(year, Helper.LinqSortedBooks).ToList();
            }
            if (checkedListBox1.GetItemChecked(2)) Helper.LinqSortedBooks = SearcherLINQ.SearchByEdition(textBox3.Text, Helper.LinqSortedBooks).ToList();
            RefreshValues(Helper.LinqSortedBooks);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            InfoForm f5 = new InfoForm(this);
            f5.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileManager.OpenFile();
            try { RefreshValues(Helper.Data); }
            catch (Exception ex){MessageBox.Show("Problem occured because of wrong file structure", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);}
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }


        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saved = FileManager.SaveFile();
            RefreshValues(Helper.Data);
            JsonMaster.SerializeToJson(Helper.Path, Helper.Data);
            MessageBox.Show("File was successfully saved at " + Helper.Path, "Json Converter");
            saved = false;
        }

        private void createJsonAndSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saved = FileManager.CreateFile();
            RefreshValues(Helper.Data);
            saved = false;
        }

        private void labInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show( "Working with Json Data.\nMuska Natalia K-25.","Lab 4");
        }

        


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (saved) return;
                try
                {
                    String msg = "File is not saved. Save file?";
                    String caption = "Save";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
                    DialogResult result;
                    result = MessageBox.Show(this, msg, caption, buttons);
                    if (result == DialogResult.Yes)
                    {
                        JsonMaster.SerializeToJson(Helper.Path, Helper.Data);
                        MessageBox.Show("Saved", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        saved = true;
                        Application.Exit();
                    }
                    else if (result == DialogResult.Cancel)
                    {e.Cancel = true;}
                    else
                    {
                        saved = true;
                        Application.Exit();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message.ToString(), "Save",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

    }
  
    
}