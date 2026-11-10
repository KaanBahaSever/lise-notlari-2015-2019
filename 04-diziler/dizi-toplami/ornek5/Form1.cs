using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ornek5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);

            string[] c = new string[a];
            int[] x = new int[a];
            int tp=0;
            for (int i = 0; i < a; i++)
            {
                c[i] = Microsoft.VisualBasic.Interaction.InputBox(i+1+".Değeri Giriniz","Sayı Girişi", "", 23, 32);
                listBox1.Items.Add(c[i]);
                x[i] = int.Parse(c[i]);
                tp += x[i];
            }
            textBox2.Text = "" + tp;
        }
    }
}
