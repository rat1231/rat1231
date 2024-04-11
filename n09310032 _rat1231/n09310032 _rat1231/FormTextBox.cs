using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace n09310032__rat1231
{
    public partial class FormTextBox : Form
    {
        public FormTextBox()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("text box被改變了");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text=textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(textBox3.Text);
            int b = Int32.Parse(textBox4.Text);
            label4.Text = (a + b).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(textBox5.Text);
            int b = Int32.Parse(textBox6.Text);
            label7.Text = (a * b).ToString();
                
        }
    }
}
