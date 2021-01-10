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
    public partial class Inventory : Form

    {
        OracleConnection CON1;
        OracleCommand CMD;
        string QUERY;
        int TEMP, I;
        OracleDataReader RDR;

    
        public Inventory()
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

        private void Inventory_Load(object sender, EventArgs e)
        {
            textBox9.Text = globals.sname;
            string oradb = "Data Source=DESKTOP-5IH3S49 ;User Id=michelle ;Password=Ilovescience08;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            //OracleDataAdapter sda = new OracleDataAdapter("select * from sreg where sname = @sname ", conn);
            //sda.SelectCommand.Parameters.Add("@sname", sname.Text);

            string query = "SELECT * FROM inventory WHERE shopn='" + textBox9.Text + "'";
            OracleDataAdapter sda = new OracleDataAdapter(query, conn);


            DataTable dt = new DataTable("inventory");



            sda.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Inventory_Load_1(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox11.Text == "")
            {
                MessageBox.Show("Enter All the Details ");
            }

            else
             if (textBox8.Text != textBox11.Text)
            {
                I = 0;

                QUERY = "select * from materials where shopn='" + name.Text + "' ";
                CON1.Open();
                CMD = new OracleCommand(QUERY, CON1);

                RDR = CMD.ExecuteReader();

                while (RDR.Read())
                {
                    if (RDR["shopn"] == textBox6.Text)
                        I = 1;
                    else
                        I = I;
                }
                RDR.Close();
                CON1.Close();

                if (I == 1)
                {
                    MessageBox.Show(" Enter the correct shop name");
                    textBox5.Text = " ";
                    textBox5.Focus();
                }
                else
                {
                    CON1.Open();
                    QUERY = "Insert INTO inventory(sname, prname, prprice, prquantity) Values('" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox11.Text + "')";
                    CMD = new OracleCommand(QUERY, CON1);
                    CMD.CommandType = CommandType.Text;
                    TEMP = CMD.ExecuteNonQuery();


                    //OracleDataAdapter adapter = new OracleDataAdapter("Insert INTO materials ( pname,pprice,pquantity,sellername,contact,address) Values('" +
                    //shopn.Text + "','" + pname.Text + "','" + price.Text + "','" + quantity.Text + "','" + sname.Text + "','" + contact.Text + "','" + address.Text + "')", con);


                    // adapter.ExecuteNonQuery();
                    
                    CMD.CommandType = CommandType.Text;
                    TEMP = CMD.ExecuteNonQuery();
                    if (TEMP > 0)

                        MessageBox.Show(" Inventory Updated");
                    else
                        MessageBox.Show("Updation Failed");
                    CON1.Close();

                    clear();
                    next();
                }

            }
            else
            {
                MessageBox.Show("Set different contact and address");
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Focus();
                textBox11.Focus();
            }

            void clear()
            {
                textBox6.Text = textBox7.Text = textBox8.Text = textBox11.Text = " ";

            }
            void next()
            {
                SHome ss = new SHome();
                ss.Show();
                this.Hide();
            }

        }
    }
}

       
        


