using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SR3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Emin Misin", "ÇIKIŞ", MessageBoxButtons.YesNo);
            
            if (dialog==DialogResult.Yes)
            {
                int inp;
                int deg = int.Parse(comboBox1.Text);
                int[] dz = new int[deg];
                for (int i = 0; i < dz.Length; i++)
                {
                    inp = Convert.ToInt16(Microsoft.VisualBasic.Interaction.InputBox("", "", "", 2, 2));
                    dz[i] = inp;
                    if (dz[i]%5==0)
                    {
                        listBox1.Items.Add(dz[i]);
                    }
                    else
                    {
                        listBox2.Items.Add(dz[i]);
                    }
                }
            }
            else
            {
                this.Close();
            }
        }
    }
}
