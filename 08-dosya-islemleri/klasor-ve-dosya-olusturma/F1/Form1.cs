using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace F1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBox1.Text = folderBrowserDialog1.SelectedPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox2.Text = openFileDialog1.FileName;
        }
        string n;
        private void button3_Click(object sender, EventArgs e)
        {
            string t = textBox3.Text;
            string a = textBox1.Text;
            n = a +"//"+ t;
            Directory.CreateDirectory(n);

        }
        string z;
        private void button4_Click(object sender, EventArgs e)
        {

            string y = textBox1.Text;
            string l = textBox4.Text+".txt";
            z = y +"//"+ l;
            FileStream fs = File.Create(z);
            fs.Close();
            FileStream fs1 = new FileStream(folderBrowserDialog1.SelectedPath + @"/" + textBox4.Text + ".txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs1);
            sw.WriteLine("MARABA");
            sw.WriteLine("Kero");
            sw.Flush();
            fs1.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Directory.Delete(n,true);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            File.Delete(z);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox5.Text =n;
            Directory.Move(n, textBox6.Text + "/" + textBox3.Text);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox7.Text = z;
            File.Move(z, textBox8.Text + "/" + textBox4.Text);
        }
    }
}
