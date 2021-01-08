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

            if (shopn.Text == "" || pname.Text == "" || price.Text == "" || quantity.Text == "" || sname.Text == "" || contact.Text == "" || address.Text == "")
            {
                MessageBox.Show("Enter All the Details ");
            }

            else
              if (contact.Text != address.Text)
            {
                I = 0;

                QUERY = "select * from materials where shopn='" + shopn.Text + "' ";
                CON1.Open();
                CMD = new OracleCommand(QUERY, CON1);

                RDR = CMD.ExecuteReader();

                while (RDR.Read())
                {
                    if (RDR["shopn"] == shopn.Text)
                        I = 1;
                    else
                        I = I;
                }
                RDR.Close();
                CON1.Close();

                if (I == 1)
                {
                    MessageBox.Show(" Shop Name exists");
                    sname.Text = " ";
                    sname.Focus();
                }
                else
                {
                    CON1.Open();
                    QUERY = "Insert INTO materials(shopn, pname, pprice, pquantity, sellername, contact, address) Values('"+ shopn.Text + "','" + pname.Text + "','" + price.Text + "','" + quantity.Text + "','" + sname.Text + "','" + contact.Text + "','" + address.Text + "')";
                    CMD = new OracleCommand(QUERY, CON1);
                    CMD.CommandType = CommandType.Text;
                    TEMP = CMD.ExecuteNonQuery();
                    if (TEMP > 0)

                        MessageBox.Show(" REGISTRATION SUCCESSFULL");
                    else
                        MessageBox.Show("REGISTRATION FAILED");

                    clear();
                    next();
                }

            }
            else
            {
                MessageBox.Show("Set different contact and address");
                contact.Text = "";
                address.Text = "";
                contact.Focus();
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