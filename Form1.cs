using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CJK2Unicode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            int outStr = 0;
            List<int> outlist = new List<int>();
            bool exist = false;
            int t = 0;
            if (!string.IsNullOrEmpty(str))
            {
                for (int i = 0; i < str.Length; i++)
                {
                    //将中文字符转为10进制整数
                    outStr = (int)str[i];
                    exist = false;
                    foreach (int s in outlist)
                    {
                        if (s == outStr)
                        {
                            exist = true;
                            break;
                        }
                    }
                    if (!exist)
                    {
                        outlist.Add(outStr);
                    }
                }
            }
            textBox2.Text = "";
            foreach (int s in outlist)
            {
                t = s + 1;
                textBox2.Text += "ImportRange " + s.ToString() + " " + t.ToString();
                textBox2.Text += Environment.NewLine;
            }
            textBox2.Focus();
            textBox2.SelectAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Focus();
            textBox2.SelectAll();
        }
    }
}
