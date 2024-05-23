﻿using System;
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
    public partial class Formgamecode : Form
    {
        int min = 0, max = 100;
        int answer;
        public Formgamecode()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            this.answer = r.Next(100);
            MessageBox.Show(answer.ToString());
            label1.Text = "已隨機產生0~100的數字,請在下方作答";
            label2.Text = string.Format("請輸入{0}~{1}之間的數值", min, max);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int input = Int32.Parse(textBox1.Text);
                if (input == this.answer)
                {
                    MessageBox.Show("恭喜答對");
                }
                else if (input <= this.min)
                {
                    MessageBox.Show("請輸入大於" + this.min);
                }
                else if (input >= this.max)
                {
                    MessageBox.Show("請輸入小於" + this.max);
                }
                else if (input < this.answer)
                {
                    this.min = input;
                }
                else if (input > this.answer)
                {
                    this.max = input;
                }
                label2.Text = string.Format("請輸入{0}~{1}之間的數值", min, max);
            }
            catch (Exception e1)
            {
                MessageBox.Show("輸入錯誤,請輸入數字");

            }
        }
    }
}
