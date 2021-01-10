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

        OracleConnection CON1;
        OracleCommand CMD;
        string QUERY;
        int TEMP, I;
        OracleDataReader RDR;
        public AddRM()


        {
            InitializeComponent();
            CON1 = new OracleConnection("Data Source=(DESCRIPTION =" +
      "(ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-5IH3S49)(PORT = 1521))" +
      "(CONNECT_DATA =" +
        "(SERVER = DEDICATED)" +
        "(SERVICE_NAME = XE)" +
      ")" +
    "); User Id=michelle; Password=Ilovescience08");

        }

        private void AddRM_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oradb = "Data Source= DESKTOP-5IH3S49;User Id=michelle;Password=Ilovescience08;";

            if (shopn.Text == "" || pname.Text == "" || price.Text == "" || quantity.Text == "" || sname.Text == "" || contact.Text == "" || address.Text == "")
            {
                MessageBox.Show("Enter All the Details ");
            }

            else
             
                    using (OracleConnection con = new OracleConnection(oradb))
                    {
                        con.Open();
                        OracleCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "Insert INTO materials(pname, pprice, pquantity, sellername, contact, address, shopn) Values('" + pname.Text + "', '" + price.Text + "', '" + quantity.Text + "', '" + sname.Text + "', '" + contact.Text + "', '" + address.Text + "', '" + shopn.Text + "')";
                        cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated.");
                    SLogin ss = new SLogin();
                    ss.Show();
                    this.Hide();

                }
                  
         

            void clear()
            {
                sname.Text = pname.Text = price.Text = quantity.Text = contact.Text = address.Text = " ";
           
            }
            void next()
            {
                RMaterials ss = new RMaterials();
                ss.Show();
                this.Hide();
            }

           
        }

        private void shopn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}