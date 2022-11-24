using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab4
{
    public partial class DeleteByCodeForm : Form
    {
        private Form1 form1;
        public string? ValueForText1 = "";
        public DeleteByCodeForm(Form1 form)
        {
            InitializeComponent();
            form1 = form;
            ValueForText1 = textBox1.Text;
        }


        private void DeleteByCodeForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            ValueForText1 = textBox1.Text;
            int a= Int32.Parse(ValueForText1);
            Helper.DeleteByCode(a);
            form1.RefreshValues(Helper.Data);
            this.Close();
        }
    }
}
