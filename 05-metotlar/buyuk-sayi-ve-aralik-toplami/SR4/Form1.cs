using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SR4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int t1 = int.Parse(textBox1.Text);
            int t2 = int.Parse(textBox2.Text);
            listBox1.Items.Add("BÜYÜK SAYI = " + met1(t1, t2));
        }
        public int met1(int a, int b)
        {
            if (a>b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        public void met2(int c, int d)
        {
            int tp = 0;
            for (int i = c; i <= d; i++)
            {
                listBox1.Items.Add(i);
                tp += i;
            }
            listBox1.Items.Add("TOPLAM = " + tp);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int t1 = int.Parse(textBox1.Text);
            int t2 = int.Parse(textBox2.Text);
            met2(t1, t2);
        }
    }
}
