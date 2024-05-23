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
    public partial class Formcheckbox : Form
    {
        public Formcheckbox()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("方塊已按下");

            }
            else
            {
                MessageBox.Show("方塊已被取消");
            }

        }
    }
}
