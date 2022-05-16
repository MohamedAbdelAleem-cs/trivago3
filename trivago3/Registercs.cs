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
    public partial class Registercs : Form
    {
        string ordb = "Data Source=orcl; User Id=scott;password=tiger;";
        OracleConnection conn;
        public Registercs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Usr values (:username,:name,:password)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("name", name.Text);
            cmd.Parameters.Add("username", username.Text);
            cmd.Parameters.Add("password", password.Text);

            try
            {
                int dr = cmd.ExecuteNonQuery();
                if (dr != -1)
                {

                    //comboBox1.Items.Add(comboBox1.Text);
                    MessageBox.Show("new user is added");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("username already exist");
            }
                
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Login frm = new Login();
            frm.Show();
        }

        private void Registercs_Load(object sender, EventArgs e)
        {

        }
    }
}
