using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Visible = false;
            label2.Visible = false;

            textBox3.Visible = false;
            label3.Visible = false;

            textBox4.Visible = false;
            label4.Visible = false;

            textBox5.Visible = false;
            label5.Visible = false;

            textBox6.Visible = false;
            label6.Visible = false;
        }
        public int a;
        private void button1_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            if (a <= 5 && a >= 1)
            {
                if (a == 1)
                {
                    textBox2.Visible = true;
                    label2.Visible = true;

                    textBox3.Visible = false;
                    label3.Visible = false;

                    textBox4.Visible = false;
                    label4.Visible = false;

                    textBox5.Visible = false;
                    label5.Visible = false;

                    textBox6.Visible = false;
                    label6.Visible = false;

                }
                else if (a == 2)
                {
                    textBox2.Visible = true;
                    label2.Visible = true;

                    textBox3.Visible = true;
                    label3.Visible = true;

                    textBox4.Visible = false;
                    label4.Visible = false;

                    textBox5.Visible = false;
                    label5.Visible = false;

                    textBox6.Visible = false;
                    label6.Visible = false;
                }
                else if (a == 3)
                {
                    textBox2.Visible = true;
                    label2.Visible = true;

                    textBox3.Visible = true;
                    label3.Visible = true;

                    textBox4.Visible = true;
                    label4.Visible = true;

                    textBox5.Visible = false;
                    label5.Visible = false;

                    textBox6.Visible = false;
                    label6.Visible = false;
                }
                else if (a == 4)
                {
                    textBox2.Visible = true;
                    label2.Visible = true;

                    textBox3.Visible = true;
                    label3.Visible = true;

                    textBox4.Visible = true;
                    label4.Visible = true;

                    textBox5.Visible = true;
                    label5.Visible = true;

                    textBox6.Visible = false;
                    label6.Visible = false;
                }
                else if (a == 5)
                {
                    textBox2.Visible = true;
                    label2.Visible = true;

                    textBox3.Visible = true;
                    label3.Visible = true;

                    textBox4.Visible = true;
                    label4.Visible = true;

                    textBox5.Visible = true;
                    label5.Visible = true;

                    textBox6.Visible = true;
                    label6.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Hata");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] s = new string[a];
            if (a == 1)
            {
                s[0] = textBox2.Text;
                listBox1.Items.Add(a + ".Eleman = " + s[0]);
            }
            else if (a == 2)
            {
                s[0] = textBox2.Text;
                s[1] = textBox3.Text;
                listBox1.Items.Add(a - 1 + ".Eleman = " + s[0]);
                listBox1.Items.Add(a + ".Eleman = " + s[1]);
            }
            else if (a == 3)
            {
                s[0] = textBox2.Text;
                s[1] = textBox3.Text;
                s[2] = textBox4.Text;
                listBox1.Items.Add(a - 2 + ".Eleman = " + s[0]);
                listBox1.Items.Add(a - 1 + ".Eleman = " + s[1]);
                listBox1.Items.Add(a + ".Eleman = " + s[2]);
            }
            else if (a == 4)
            {
                s[0] = textBox2.Text;
                s[1] = textBox3.Text;
                s[2] = textBox4.Text;
                s[3] = textBox5.Text;
                listBox1.Items.Add(a - 3 + ".Eleman = " + s[0]);
                listBox1.Items.Add(a - 2 + ".Eleman = " + s[1]);
                listBox1.Items.Add(a - 1 + ".Eleman = " + s[2]);
                listBox1.Items.Add(a + ".Eleman = " + s[3]);
            }
            else if (a == 5)
            {
                s[0] = textBox2.Text;
                s[1] = textBox3.Text;
                s[2] = textBox4.Text;
                s[3] = textBox5.Text;
                s[4] = textBox6.Text;
                listBox1.Items.Add(a - 4 + ".Eleman = " + s[0]);
                listBox1.Items.Add(a - 3 + ".Eleman = " + s[1]);
                listBox1.Items.Add(a - 2 + ".Eleman = " + s[2]);
                listBox1.Items.Add(a - 1 + ".Eleman = " + s[3]);
                listBox1.Items.Add(a + ".Eleman = " + s[4]);
            }
        }
    }
}
