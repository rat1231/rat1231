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
    public partial class Form_button : Form
    {
        public Form_button()
        {
            InitializeComponent();
        }

        private void BTNCLICK_Click(object sender, EventArgs e)
        {
            if (BTNCLICK.Text == "按我啊幹等啥阿")
                BTNCLICK.Text = "surprise mother fucker";
            else if (BTNCLICK.Text == "surprise mother fucker")
                BTNCLICK.Text = "按我啊幹等啥阿";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string count = label1.Text;
            int sum = Int32.Parse(count)-1;
            label1.Text=sum.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string count = label1.Text;
            int sum = Int32.Parse(count)+1;
            label1.Text=sum.ToString();
        }
    }
}
