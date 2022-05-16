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
    public partial class Admin : Form
    {
        string ordb = "Data Source=orcl; User Id=scott;password=tiger;";
        OracleConnection conn;
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select H_ID from admin1";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                hotelid.Items.Add(dr[0]);
            }
            dr.Close();
        }
      
        
        private void hotelid_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select Hname,Hlocation,Offer,Price from admin1 where H_ID=:id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", hotelid.SelectedItem.ToString());
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                name.Text = dr[0].ToString();
                location.Text = dr[1].ToString();
                offer.Text = dr[2].ToString();
                price.Text = dr[3].ToString();
                
            }
            dr.Close();
        }
        


        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void insert_btn1_Click_1(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into admin1 values (:id,:name,:offer,:price,:location)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", hotelid.Text);
            cmd.Parameters.Add("name", name.Text);
            cmd.Parameters.Add("location", location.Text);
            cmd.Parameters.Add("offer", offer.Text);
            cmd.Parameters.Add("price", price.Text);
            int dr = cmd.ExecuteNonQuery();
            if (dr != -1)
            {

                hotelid.Items.Add(hotelid.Text);
                MessageBox.Show("new Hotel was added");
            }
            else
                MessageBox.Show("Hotel iD  is already exist");
        }

        private void update_btn1_Click_1(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update  admin1 set Hname=:name,Offer=:offer,Price=:price,Hlocation=:location2 where H_ID=:id";
            //cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("id", hotelid.SelectedItem.ToString());
            cmd.Parameters.Add("name", name.Text);
            cmd.Parameters.Add("location2", location.Text);
            cmd.Parameters.Add("offer", offer.Text);
            cmd.Parameters.Add("price", price.Text);
            int dr = cmd.ExecuteNonQuery();
            if (dr != -1)
            {
                MessageBox.Show("Hotel Data was modified");
            }
            else
                MessageBox.Show("this Hotel ID not exist");
        }

        private void delete_btn1_Click_1(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Delete from admin1 where H_ID=:id";
            cmd.Parameters.Add("id", hotelid.Text);
            int dr = cmd.ExecuteNonQuery();
            if (dr != -1)
            {
                MessageBox.Show("this Hotel was deleted");
                hotelid.Items.RemoveAt(hotelid.SelectedIndex);
                name.Text = "";
                location.Text = "";
                price.Text = "";
                offer.Text = "";
            }
            else
                MessageBox.Show("this Hotel ID not exist to delete");
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
