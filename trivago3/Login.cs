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
    public partial class Login : Form
    {
        string ordb = "Data Source=orcl; User Id=scott;password=tiger;";
        OracleConnection conn;
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Registercs registercs = new Registercs();
            registercs.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select Email_,Pssword_ from Usr where Email_=:username AND Pssword_=:passord ";
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("username", username.Text);
            cmd.Parameters.Add("passord", password.Text);
           
            OracleDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Successful login");
                this.Hide();

                home home1 = new home();
                home1.ShowDialog();
            }
            else MessageBox.Show("username or password is invalid");
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
