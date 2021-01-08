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
        public Shops()
        {
            InitializeComponent();
        }

        private void Shops_Load(object sender, EventArgs e)
        {
            label2.Text = globals.username;
            string oradb = "Data Source=DESKTOP-5IH3S49 ;User Id=michelle ;Password=Ilovescience08;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            //OracleDataAdapter sda = new OracleDataAdapter("select  where sname = @sname ", conn);
            //sda.SelectCommand.Parameters.Add("@sname", sname.Text);

            string query = "SELECT * FROM materials WHERE shopn='" + textBox1.Text + "'";
            OracleDataAdapter sda = new OracleDataAdapter(query, conn);


            DataTable dt = new DataTable("materials");



            sda.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
        }
    }
}
