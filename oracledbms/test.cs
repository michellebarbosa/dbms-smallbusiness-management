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
using Oracle.ManagedDataAccess.Types;

namespace oracledbms
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void test_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome logged username : " + globals.username);
            textBox1.Text = globals.username;


            string oradb = "Data Source=DESKTOP-5IH3S49 ;User Id=michelle ;Password=Ilovescience08;";
            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            //OracleDataAdapter sda = new OracleDataAdapter("select * from sreg where sname = @sname ", conn);
            //sda.SelectCommand.Parameters.Add("@sname", sname.Text);

            string query = "SELECT* FROM inventory;";
            OracleDataAdapter sda = new OracleDataAdapter(query, conn);


            DataTable dt = new DataTable("inventory");



            sda.Fill(dt);

            dataGridView1.DataSource = dt.DefaultView;
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          // if ( dt.rows[rowindex][columnindex] =

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            CLogin  f4 = new CLogin();
            f4.ShowDialog();
        }
    }
}
