using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SR2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int max=0,min=0;
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random a = new Random();
            int[] s = new int[5];
            for (int i = 0; i < 5; i++)
            {
                s[i] = a.Next(1, 10);
            }
            max = s.Max();
            min = s.Min();

            met2(met1(max,min));

            label1.Text = "ORTALAMA = " + (met3(met1(max, min)));

            
        }
        public int[,] met1(int t, int b)
        {
            Random y = new Random();
            int[,] dz2 = new int[t, b];
            for (int i = 0; i < t; i++)
            {
                for (int k = 0; k < b; k++)
                {
                    dz2[i, k] = y.Next(1, 1000);
                }
            }
            return dz2;
        }
        public void met2(int[,] dz2)
        {
            for (int i = 0; i < max; i++)
            {
                for (int k = 0; k < min; k++)
                {
                    listBox1.Items.Add("dizi[" + i + "," + k + "]"+" = " + dz2[i, k]);
                }
            }
        }
        public int met3(int[,] dz3)
        {
            int tp = 0;
            for (int i = 0; i < max; i++)
            { 
                for (int k = 0; k < min; k++)
                {
                    tp += dz3[i, k];                
                }
            }
            int ort = tp / (max * min);
            return ort;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label1.Text = "";
        }
    }
}
