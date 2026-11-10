using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace F1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        public void GridDoldur()
        {
            con = new SqlConnection("Server=.;Initial Catalog=CBaglanti;Integrated Security=SSPI");
            da = new SqlDataAdapter("Select *from ogrenci", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "ogrenci");
            dataGridView1.DataSource = ds.Tables["ogrenci"];
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {          
            //string MusteriNo = textBox1.Text, Ad = textBox2.Text,Soyad=textBox3.Text,Tel=textBox4.Text ;
            //DateTime DTarih = dateTimePicker1.Value;
            //cmd.CommandText = "insert into Musteri(MusteriNo,Ad,Soyad,Tel,DTarih) values (" + MusteriNo + ",'" + Ad + "','" + Soyad + "','" + Tel + "','" + DTarih + "')";
            string sorgu = "Insert Into Musteri(MusteriNo,Ad,Soyad,Tel,DTarih) Values(@MusteriNo,@Ad,@Soyad,@Tel,@DTarih)";
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@MusteriNo", textBox1.Text);
            cmd.Parameters.AddWithValue("@Ad", textBox2.Text);
            cmd.Parameters.AddWithValue("@Soyad", textBox3.Text);
            cmd.Parameters.AddWithValue("@Tel", textBox4.Text);
            cmd.Parameters.AddWithValue("@DTarih", dateTimePicker1.Value);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GridDoldur();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GridDoldur();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "delete from Musteri where MusteriNo=" + textBox1.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            GridDoldur();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //cmd = new SqlCommand();
            //con.Open();
            //cmd.Connection = con;

            string sorgu = "Update Musteri set()"; //BURASI DÜZELTİLECEK 18.03.2019
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@MusteriNo", textBox1.Text);
            cmd.Parameters.AddWithValue("@Ad", textBox2.Text);
            cmd.Parameters.AddWithValue("@Soyad", textBox3.Text);
            cmd.Parameters.AddWithValue("@Tel", textBox4.Text);
            cmd.Parameters.AddWithValue("@DTarih", dateTimePicker1.Value);

            cmd.CommandText = "update Musteri set Ad='" + textBox4.Text + "',Soyad='" + textBox2.Text + "',Tel='" + textBox3.Text + "',DTarih='" + dateTimePicker1.Value + "' where MusteriNo=" + textBox1.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            GridDoldur();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("Select *from Musteri where Sehir='" + textBox3.Text + "'", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Musteri");
            dataGridView1.DataSource = ds.Tables["Musteri"];
            con.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        public int index = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            index = 0;
            //ilk kayıt
            Veri(0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //son kayıt
            Veri(dataGridView1.Rows.Count - 2);
            index = dataGridView1.Rows.Count - 2;
        }

        private void button7_Click(object sender, EventArgs e)
        {//>> tuşu
            index++;
            Veri(index);
        }

        private void button8_Click(object sender, EventArgs e)
        {//<< tuşu
            index--;
            Veri(index);

        }
        public void Veri(int index)
        {
            if (index == -1) { index = dataGridView1.Rows.Count - 2; this.index = dataGridView1.Rows.Count - 2; }
            if (index > dataGridView1.Rows.Count - 2) { index = 0; this.index = 0; }
  
            textBox1.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            dateTimePicker1.Value =Convert.ToDateTime( dataGridView1.Rows[index].Cells[4].Value);
        }
    }
}
