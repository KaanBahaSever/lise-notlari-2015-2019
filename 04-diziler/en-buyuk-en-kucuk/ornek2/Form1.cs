using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(numericUpDown1.Value);
            int b = Convert.ToInt16(numericUpDown2.Value);
            int c = Convert.ToInt16(numericUpDown3.Value);

            Random r = new Random();

            int[] f = new int[a];

            for (int i = 0; i < a; i++)
            {
                f[i] = r.Next(b, c);
                listBox1.Items.Add(f[i]);
            }
            Array.Sort(f);
            textBox1.Text = "" + f[listBox1.Items.Count-1];
            textBox2.Text = "" + f[0];
        }
    }
}
