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
    public partial class Formtrycatch : Form
    {
        public Formtrycatch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double input = Double.Parse(textBox1.Text);
                label1.Text = (100 + input).ToString();
                throw new IndexOutOfRangeException();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("輸入格式有錯");
            }
            catch (Exception)
            {
                MessageBox.Show("發生問題了,什麼問題不知道");
            }
            finally
            {
                MessageBox.Show("執行到最後");
            }
        }
    }
}
