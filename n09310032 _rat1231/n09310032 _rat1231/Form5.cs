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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String tmp = textBox7_input.Text;
            Int c = Int32.Parse(tmp);

            //華氏=(攝氏) * (9 / 5) + 32

            double result = c * 1.8 + 32;
            Console.WriteLine(result);
            Console.ReadLine();
            label_result.Text = result.ToString();

        }
    }
}
