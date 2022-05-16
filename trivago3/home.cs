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
    public partial class home : Form
    {
        string ordb = "Data Source=orcl; User Id=scott;password=tiger;";
        OracleConnection conn;
        public home()
        {
            InitializeComponent();
        }

        private void Srch_btn_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "BOOK";
            cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("Dest_location", textBox1.Text);
                cmd.Parameters.Add("hotel_name", textBox4.Text);
                cmd.Parameters.Add("duration_stay", Int32.Parse(textBox2.Text));
                cmd.Parameters.Add("total_price", OracleDbType.Int32, ParameterDirection.Output);
                cmd.ExecuteNonQuery();
                int res;
            try
            {
                res=Convert.ToInt32(cmd.Parameters["total_price"].Value.ToString());
                MessageBox.Show(res.ToString());
            }
            catch(Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void home_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void button_Explore(object sender, EventArgs e)
        {
            this.Hide();
            Explore exp = new Explore();
            exp.ShowDialog();
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            this.Hide();
            Filter Fil = new Filter();
            Fil.ShowDialog();
        }
    }
}
