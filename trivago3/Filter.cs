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
    public partial class Filter : Form
    {
        string ordb = "Data Source=orcl; User Id=scott;password=tiger;";
        OracleConnection conn;
        public Filter()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            
            if (radioButton_price.Checked)
            {
                dataGridView1.ColumnCount = 4;
                cmd.CommandText = "FILTER_HOTELS_PRICE";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("Lower", Int32.Parse(txt_lower.Text));
                cmd.Parameters.Add("Upper", Int32.Parse(txt_upper.Text));
                cmd.Parameters.Add("Data", OracleDbType.RefCursor, ParameterDirection.Output);
                dataGridView1.Columns[0].Name = "Name";
                dataGridView1.Columns[1].Name = "Location";
                dataGridView1.Columns[2].Name = "Price";
                dataGridView1.Columns[3].Name = "Rating";
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    this.dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3]);
                }
            }
            else if (radioButton_Rating.Checked)
            {
                dataGridView1.ColumnCount = 4;
                cmd.CommandText = "FILTER_HOTELS_RATING";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("Lower", Int32.Parse(txt_lower.Text));
                cmd.Parameters.Add("Upper", Int32.Parse(txt_upper.Text));
                cmd.Parameters.Add("Data", OracleDbType.RefCursor, ParameterDirection.Output);
                dataGridView1.Columns[0].Name = "Name";
                dataGridView1.Columns[1].Name = "Location";
                dataGridView1.Columns[2].Name = "Price";
                dataGridView1.Columns[3].Name = "Rating";
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    this.dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3]);
                }
            }
            else if (radioButton_offer.Checked)
            {
                conn.Close();
                string constr = "User Id=scott;password=tiger;Data Source=orcl";
                string cmdstr= @"select HNAME,HLOCATION, PRICE, RATING,OFFER 
                                 from ADMIN1
                                 Where OFFER BETWEEN :lower and :upper";
                OracleDataAdapter adapter = new OracleDataAdapter(cmdstr, constr);
                adapter.SelectCommand.Parameters.Add("lower", Int32.Parse(txt_lower.Text));
                adapter.SelectCommand.Parameters.Add("upper", Int32.Parse(txt_upper.Text));
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].HeaderText = "Name";
                dataGridView1.Columns[1].HeaderText = "Location";
                dataGridView1.Columns[2].HeaderText = "Price";
                dataGridView1.Columns[3].HeaderText = "Rating";
                dataGridView1.Columns[4].HeaderText = "Offer";
            }
            }
            
        }
    }

