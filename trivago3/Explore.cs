using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Trivago
{
    public partial class Explore : Form
    {
        string ordb = "Data Source=orcl; User Id=scott;password=tiger;";
        OracleConnection conn;
        public Explore()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            dataGridView1.ColumnCount = 1;
            if (radioButton1.Checked)
            {
                cmd.CommandText = "Select HLOCATION,HNAME,PRICE from ADMIN1 where HLOCATION=:hloc";
                cmd.Parameters.Add("hloc", textBox1.Text);
                dataGridView1.Columns[0].Name = "Location";
                dataGridView1.Columns.Add("Hotel", "Hotel");
                dataGridView1.Columns.Add("Price", "Price");

            }
            else if (radioButton2.Checked)
            {
                cmd.CommandText = "Select HLOCATION,HNAME,PRICE from ADMIN1 where HNAME=:hname";
                cmd.Parameters.Add("hname", textBox1.Text);
                dataGridView1.Columns[0].Name = "Location";
                dataGridView1.Columns.Add("Hotel","Hotel");
                dataGridView1.Columns.Add("Price", "Price");
            }
            OracleDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                 this.dataGridView1.Rows.Add(dr[0],dr[1],dr[2]);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_booking_Click(object sender, EventArgs e)
        {
            this.Hide();
            home h1 = new home();
            h1.ShowDialog();
        }
    }
}
