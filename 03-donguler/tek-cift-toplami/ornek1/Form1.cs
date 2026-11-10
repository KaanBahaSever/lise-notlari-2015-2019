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

        private void Form1_Load(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Devam Etmek İstiyor Musunuz ? ", "ÇIKIŞ", MessageBoxButtons.YesNo);
            
            if (DialogResult.Yes==a)
            {
                int s = 0, tp1 = 0,tp2=0;
                for (int i = 0; true; i++)
                {
                    s = Convert.ToInt16(Microsoft.VisualBasic.Interaction.InputBox("", "", "", 23, 23));
                    if (s == 0) break;
                    if (s % 2 == 0)
                    {
                        listBox1.Items.Add(s);
                        tp1 += s;
                    }
                    else
                    {
                        listBox2.Items.Add(s);
                        tp2 += s;
                    }
                    
                }
                listBox1.Items.Add("Çift Toplam = " + tp1);
                listBox2.Items.Add("Tek Toplam = " + tp2);
            }
            else
            {
                this.Close();
            }
            
        }
    }
}
