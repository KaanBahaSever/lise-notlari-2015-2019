using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace F1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DateTime dt;
        OleDbConnection con;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        OleDbDataReader DR;
        public string sorgu;

        public void doldur()
        {
            ds.Clear();
            da.Fill(ds, "personel");
            dataGridView1.DataSource = ds.Tables["personel"];
        }

        public void griddoldur()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=dosya.accdb");
            da = new OleDbDataAdapter("SElect *from personel", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "personel");
            dataGridView1.DataSource = ds.Tables["personel"];
            con.Close();
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            griddoldur();
        }

        public void temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into personel (Sıra,Ogr_Ad,Ogr_Soyad,Adres,Sehir,D_Tarihi,Maas,Resim) values ('" + textBox1.Text + "','" + textBox7.Text + "','" + textBox6.Text + "','" + textBox5.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Value.ToString() + "','" + textBox4.Text + "','" + textBox3.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
            temizle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "delete from personel where Sıra=" + textBox1.Text +"";
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
            temizle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                textBox3.Text = openFileDialog1.FileName;
                pictureBox1.ImageLocation = textBox3.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            //cmd.CommandText = "update personel set Ogr_Ad='" + textBox7.Text + "',Ogr_Soyad='" + textBox6.Text + "',Adres='" + textBox5.Text + "',Sehir='" + textBox2.Text + "',D_Tarihi='" + dateTimePicker1.Value.ToString() + "',Maas='" + textBox4.Text + "',Resim='" + textBox3.Text + "' where Sıra=" + textBox1.Text + "";
            cmd.CommandText = "update personel set Ogr_Ad='" + textBox7.Text +"' where Sıra=" + textBox1.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
            temizle();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            pictureBox1.ImageLocation = textBox3.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBox8.Text = folderBrowserDialog1.SelectedPath;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            StreamWriter yazdir = new StreamWriter(textBox8.Text + "//" + textBox10.Text + ".txt");
            cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "select *from personel";
            con.Open();
            DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                yazdir.WriteLine(DR["Sıra"]);
                yazdir.WriteLine(DR["Ogr_Ad"]);
                yazdir.WriteLine(DR["Ogr_Soyad"]);
                yazdir.WriteLine(DR["Adres"]);
                yazdir.WriteLine(DR["Sehir"]);
                yazdir.WriteLine(DR["D_Tarihi"]);
                yazdir.WriteLine(DR["Maas"]);
                yazdir.WriteLine(DR["Resim"]);
                yazdir.WriteLine("---------------");
            }
            yazdir.Close();
            DR.Close();
            con.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "select *from personel";
            con.Open();
            DR = cmd.ExecuteReader();
            while (DR.Read())
            {
                frm2.listBox1.Items.Add((DR["Sıra"]));
                frm2.listBox2.Items.Add(DR["Ogr_Ad"]);
                frm2.listBox3.Items.Add((DR["Ogr_Soyad"]));
                frm2.listBox4.Items.Add(DR["Adres"]);
                frm2.listBox5.Items.Add((DR["Sehir"]));
                frm2.listBox6.Items.Add(DR["D_Tarihi"]);
                frm2.listBox7.Items.Add(DR["Maas"]);
                frm2.listBox8.Items.Add(DR["Resim"]);
            }
            DR.Close();
            con.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sorgu = "select *from personel where Sıra BETWEEN 0 AND 3";
            da = new OleDbDataAdapter(sorgu, con);
            doldur();
        }

        private void button9_Click(object sender, EventArgs e)
        {         
                sorgu = "select *from personel where Sıra>5 AND Sıra<10";
                da = new OleDbDataAdapter(sorgu, con);
                doldur();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            griddoldur();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            sorgu = "select *from personel Order by Ogr_Ad ASC";
            da = new OleDbDataAdapter(sorgu, con);
            doldur();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            sorgu = "select LCASE(Ogr_Ad) AS Küçük , UCASE(Ogr_Soyad) As Büyük from personel";
            da = new OleDbDataAdapter(sorgu, con);
            doldur();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            sorgu = "select Ogr_Ad,Ogr_Soyad from personel where Sehir='"+textBox1.Text+"'";
            da = new OleDbDataAdapter(sorgu, con);
            doldur();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            sorgu = "select Ogr_Ad from personel where Ogr_Ad Like '" + textBox1.Text + "%'";
            da = new OleDbDataAdapter(sorgu, con);
            doldur();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //sorgu = "Select Ogr_Ad,DATEPART('yyyy',D_Tarihi) as Yıl from personel";
            sorgu = "Select * ,DateDiff('yyyy',D_Tarihi,Date()) AS Yas";
            da = new OleDbDataAdapter(sorgu, con);
            doldur();
        }
    }
}
