using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SR1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {             
                int s;
                Random a = new Random();

                for (int i = 0; true; i++)
                {
                    s = a.Next(1, 100);
                    if (s % 2 == 0)
                    {
                        listBox1.Items.Add(s);
                        break;
                    }
                }

            }
            if (comboBox1.SelectedIndex==1)
            {
                for (int i = 0; i <= 20; i++)
                {
                    if (i%5==0)
                    {
                        listBox1.Items.Add(i);
                    }
                }
            }
            if (comboBox1.SelectedIndex==2)
            {
                listBox1.ForeColor = Color.White;
                listBox1.BackColor = Color.Black;
            }
            if (comboBox1.SelectedIndex==3)
            {
                listBox1.Items.Clear();
                listBox1.BackColor = Color.White;
                listBox1.ForeColor = Color.Black;
            }
        }
    }
}
