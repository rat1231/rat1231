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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Formbutton_Click(object sender, EventArgs e)
        {
            
            Form form = new Form_button();
            form.Show();

           


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form form = new FormTextBox();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new Form5();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form form = new Formtrycatch();
            form.Show(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form = new Formtimer();
            form.Show(); 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form form = new Formgamecode();
            form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form form = new Formcheckbox();
            form.Show();
        }
    }
}
