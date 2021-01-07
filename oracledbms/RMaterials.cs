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
            // TODO: This line of code loads data into the 'dataSet.CREG' table. You can move, or remove it, as needed.
            // this.cREGTableAdapter.Fill(this.dataSet.CREG);
            try
            {
                string connstr = "Data Source=(DESCRIPTION =" +
   "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-5IH3S49)(PORT = 1521))" +
   "(CONNECT_DATA =" +
     "(SERVER = DEDICATED)" +
     "(SERVICE_NAME = XE)" +
   ")" +
 "); User Id=michelle; Password=Ilovescience08";

                using (OracleConnection conn = new OracleConnection("connstr"))
                using (OracleCommand cmd = new OracleCommand("select * from resources", conn))
                {
                    conn.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }


    private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
    
    }

