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
    public partial class SLogin : Form
    {
        public SLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connstr = "Data Source=(DESCRIPTION =" +
   "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-5IH3S49)(PORT = 1521))" +
   "(CONNECT_DATA =" +
     "(SERVER = DEDICATED)" +
     "(SERVICE_NAME = XE)" +
   ")" +
 "); User Id=michelle; Password=Ilovescience08";


                OracleConnection con = new OracleConnection(connstr);
                con.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                OracleDataAdapter adapter = new OracleDataAdapter("Select sname, password from sreg where sname='" + sname.Text.Trim() + "' and password='" + password.Text.Trim() + "'", con);
                DataTable data = new DataTable();
                adapter.Fill(data);


                if (data.Rows.Count == 1)
                {

                    globals.sname = data.Rows[0]["sname"].ToString();
                    

                    this.Hide();
                    SHome f4 = new SHome(); 
                    f4.ShowDialog();
                }


                else
                {
                    MessageBox.Show("please check your username & password");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
