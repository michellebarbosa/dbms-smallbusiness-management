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
    public partial class Shops : Form
    {
        OracleConnection CON1;
        OracleCommand CMD;
        string QUERY;
        int TEMP, I;
        OracleDataReader RDR;
        public Shops()
        { 
            InitializeComponent();
        CON1 = new OracleConnection("Data Source=(DESCRIPTION =" +
      "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-5IH3S49)(PORT = 1521))" +
      "(CONNECT_DATA =" +
        "(SERVER = DEDICATED)" +
        "(SERVICE_NAME = XE)" +
      ")" +
    "); User Id=michelle; Password=Ilovescience08");

        
            InitializeComponent();
        }

        private void Shops_Load(object sender, EventArgs e)
        {
            

            textBox1.Text = globals.username;
            string oradb = "Data Source=DESKTOP-5IH3S49 ;User Id=michelle ;Password=Ilovescience08;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            //OracleDataAdapter sda = new OracleDataAdapter("select * from sreg where sname = @sname ", conn);
            //sda.SelectCommand.Parameters.Add("@sname", sname.Text);

            string query = "SELECT * FROM inventory";
            OracleDataAdapter sda = new OracleDataAdapter(query, conn);


            DataTable dt = new DataTable("inventory");



            sda.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            CLogin f4 = new CLogin();
            f4.ShowDialog();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
