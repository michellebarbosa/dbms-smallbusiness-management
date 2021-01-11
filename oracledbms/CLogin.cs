using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.ManagedDataAccess.Types;



namespace oracledbms
{
    public partial class CLogin : Form
    {
        

        public CLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
                    OracleDataAdapter adapter = new OracleDataAdapter("Select username, password from creg where username='" + username.Text.Trim() + "' and Password='" + password.Text.Trim() + "'", con);
                    DataTable data = new DataTable();
                    adapter.Fill(data);


                    if (data.Rows.Count == 1)
                    {

                    globals.username = data.Rows[0]["username"].ToString();

                        this.Hide();
                        test f4 = new test();
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CReg ss = new CReg();
            ss.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Welcome ss = new Welcome();
            ss.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SLogin ss = new SLogin();
            ss.Show();
            this.Hide();
        }
    }

    }

