using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class InfoForm : Form
    {
        private Form1 form1;
        public InfoForm(Form1 form)
        {
            InitializeComponent();
            form1 = form;
        }
        private void InfoForm_Load(object sender, EventArgs e)
        { 
            label1.Text =
                  "Project created to optimize working with Bookstore data."
                + "\nData addition and modification is done throw additional form."
                + "\nEnter data in appropriate format to add or change item in list."
                + "\nItems could be changed and deleted by id."
                + "\nData migth be sorted by several criteria."
                + "\nWithin File Menu file saving and opening is accecible.";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
