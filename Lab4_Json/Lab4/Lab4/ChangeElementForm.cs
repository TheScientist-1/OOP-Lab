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
    public partial class ChangeElementForm : Form
    {
        private Form1 form1;
        public ChangeElementForm(Form1 form)
        {
            InitializeComponent();
            form1 = form;

        }

        private void ChangeElementForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Helper.ChangeBookById(Helper.CheckInput(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            form1.RefreshValues(Helper.Data);
            this.Close();
        }
    }
}
