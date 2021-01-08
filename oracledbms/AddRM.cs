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
    public partial class AddRM : Form
    {
        public AddRM()


        {
            InitializeComponent();

        }

        private void AddRM_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
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

            try
            {
                if (shopn.Text != "" || pname.Text != "" || price.Text != "" || quantity.Text != "" || sname.Text != "" || contact.Text != "" || address.Text != "") //if not null areas is empty, there will be no action 
                {
                 
                    OracleDataAdapter adapter = new OracleDataAdapter("Insert INTO book_table ( pname,pprice,pquantity,sellername,contact,address) Values('" +
                        shopn.Text + "','" + pname.Text + "','" + price.Text + "','" + quantity.Text + "','" + sname.Text + "','" + contact.Text + "','" + address.Text + "')", con);

                   // adapter.ExecuteNonQuery();
                    con.Close();
                    cmd.CommandType = CommandType.Text;
                    TEMP = cmd.ExecuteNonQuery();
                    if (TEMP > 0)

                        MessageBox.Show(" REGISTRATION SUCCESSFULL");
                    else
                        MessageBox.Show("REGISTRATION FAILED");


                }
            }
            catch (Exception ex) //If there are irrelevant entrance, executeNonQuery will throw exception. So texboxes will to set empty and error message will occur on screen.
            {
                shopn.Text = "";
                pname.Text = "";
                price.Text = "";
                quantity.Text = "";
                sname.Text = "";
                contact.Text = "";
                address.Text = "";
               
            }
        }

        private void shopn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}