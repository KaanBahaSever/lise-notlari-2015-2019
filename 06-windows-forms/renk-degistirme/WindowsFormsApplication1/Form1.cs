using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                if (checkBox2.Checked == true)
                {
                    if (comboBox2.SelectedIndex == 0)
                    {
                        checkBox1.ForeColor = Color.Purple;
                    }
                    else if (comboBox2.SelectedIndex == 1)
                    {
                        radioButton1.ForeColor = Color.Purple;
                    }
                    else if (comboBox2.SelectedIndex == 2)
                    {
                        textBox1.ForeColor = Color.Purple;
                    }
                    else if (comboBox2.SelectedIndex == 3)
                    {
                        listBox1.ForeColor = Color.Purple;
                    }
                    else if (comboBox2.SelectedIndex == 4)
                    {
                        button1.ForeColor = Color.Purple;
                    }
                    
                }
                if (checkBox3.Checked == true)
                {
                    if (comboBox2.SelectedIndex == 0)
                    {
                        checkBox1.BackColor = Color.Purple;
                    }
                    else if (comboBox2.SelectedIndex == 1)
                    {
                        radioButton1.BackColor = Color.Purple;
                    }
                    else if (comboBox2.SelectedIndex == 2)
                    {
                        textBox1.BackColor = Color.Purple;
                    }
                    else if (comboBox2.SelectedIndex == 3)
                    {
                        listBox1.BackColor = Color.Purple;
                    }
                    else if (comboBox2.SelectedIndex == 4)
                    {
                        button1.BackColor = Color.Purple;
                    }
                }

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                if (checkBox2.Checked == true)
                {
                    if (comboBox2.SelectedIndex == 0)
                    {
                        checkBox1.ForeColor = Color.Red;
                    }
                    else if (comboBox2.SelectedIndex == 1)
                    {
                        radioButton1.ForeColor = Color.Red;
                    }
                    else if (comboBox2.SelectedIndex == 2)
                    {
                        textBox1.ForeColor = Color.Red;
                    }
                    else if (comboBox2.SelectedIndex == 3)
                    {
                        listBox1.ForeColor = Color.Red;
                    }
                    else if (comboBox2.SelectedIndex == 4)
                    {
                        button1.ForeColor = Color.Red;
                    }
                }
                if (checkBox3.Checked == true)
                {
                    if (comboBox2.SelectedIndex == 0)
                    {
                        checkBox1.BackColor = Color.Red;
                    }
                    else if (comboBox2.SelectedIndex == 1)
                    {
                        radioButton1.BackColor = Color.Red;
                    }
                    else if (comboBox2.SelectedIndex == 2)
                    {
                        textBox1.BackColor = Color.Red;
                    }
                    else if (comboBox2.SelectedIndex == 3)
                    {
                        listBox1.BackColor = Color.Red;
                    }
                    else if (comboBox2.SelectedIndex == 4)
                    {
                        button1.BackColor = Color.Red;
                    }
                }

            }
            else if (comboBox1.SelectedIndex == 2)
            {
                if (checkBox2.Checked==true)
                {
                    if (comboBox2.SelectedIndex == 0)
                    {
                        checkBox1.ForeColor = Color.Green;
                    }
                    else if (comboBox2.SelectedIndex == 1)
                    {
                        radioButton1.ForeColor = Color.Green;
                    }
                    else if (comboBox2.SelectedIndex == 2)
                    {
                        textBox1.ForeColor = Color.Green;
                    }
                    else if (comboBox2.SelectedIndex == 3)
                    {
                        listBox1.ForeColor = Color.Green;
                    }
                    else if (comboBox2.SelectedIndex == 4)
                    {
                        button1.ForeColor = Color.Green;
                    }
                }
                if (checkBox3.Checked==true)
                {
                    if (comboBox2.SelectedIndex == 0)
                    {
                        checkBox1.BackColor = Color.Green;
                    }
                    else if (comboBox2.SelectedIndex == 1)
                    {
                        radioButton1.BackColor = Color.Green;
                    }
                    else if (comboBox2.SelectedIndex == 2)
                    {
                        textBox1.BackColor = Color.Green;
                    }
                    else if (comboBox2.SelectedIndex == 3)
                    {
                        listBox1.BackColor = Color.Green;
                    }
                    else if (comboBox2.SelectedIndex == 4)
                    {
                        button1.BackColor = Color.Green;
                    }
                }
                
            }
        }
    }
}