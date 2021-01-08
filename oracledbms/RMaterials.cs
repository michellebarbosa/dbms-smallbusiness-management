using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;


namespace oracledbms
{
    public partial class RMaterials : Form
    {
        public RMaterials()
        {
            InitializeComponent();
        }

        private void RMaterials_Load(object sender, EventArgs e)
        {
            string oradb = "Data Source=DESKTOP-5IH3S49 ;User Id=michelle ;Password=Ilovescience08;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            string query = "Select * From materials ";
            OracleDataAdapter sda = new OracleDataAdapter(query, conn);
            DataTable dt = new DataTable("materials");
            sda.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;

        }


        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddRM f4 = new AddRM();
            f4.ShowDialog();
        }
    }
}

