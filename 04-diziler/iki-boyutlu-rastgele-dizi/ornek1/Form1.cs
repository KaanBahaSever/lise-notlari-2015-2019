using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random a = new Random();
            int b = int.Parse(textBox1.Text);
            int c = int.Parse(textBox2.Text);

            int[,] ds = new int[b, c];

            for (int i = 0; i < b; i++)
            {
                for (int k = 0; k < c; k++)
                {
                    ds[i, k] = a.Next(0,100);
                    listBox1.Items.Add(ds[i, k]);
                }
            }
        }
    }
}
