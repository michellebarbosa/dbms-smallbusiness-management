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
    public partial class SReg : Form


    {


        OracleConnection CON1;
        OracleCommand CMD;
        string QUERY;
        int TEMP, I;
        OracleDataReader RDR;
        public SReg()
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

        private void SReg_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            CReg f1 = new CReg();
            f1.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SLogin f1 = new SLogin();
            f1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (sname.Text == " " || email.Text == " " || t_shop.Text == " " || password.Text == " ")
            {
                MessageBox.Show("Enter All the Details ");
            }

            else
               if (password.Text == re_password.Text)
            {
                I = 0;

                QUERY = "select * from sreg where sname='" + sname.Text + "' ";
                CON1.Open();
                CMD = new OracleCommand(QUERY, CON1);

                RDR = CMD.ExecuteReader();

                while (RDR.Read())
                {
                    if (RDR["sname"] == sname.Text)
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
                    QUERY = "Insert into sreg(sname,email,type_shop,password) values('" + sname.Text + "','" + email.Text + "','" + t_shop.Text + "','" + password.Text + "')";
                    CMD = new OracleCommand(QUERY, CON1);
                    CMD.CommandType = CommandType.Text;
                    TEMP = CMD.ExecuteNonQuery();
                    if (TEMP > 0)

                        MessageBox.Show(" REGISTRATION SUCCESSFULL");
                    else
                        MessageBox.Show("REGISTRATION FAILED");
                    CON1.Close();
                    clear();
                    next();
                }

            }
            else
            {
                MessageBox.Show("PASSWORDS DO NOT MATCH");
                password.Text = "";
                re_password.Text = "";
                password.Focus();
            }

            void clear()
            {
                sname.Text = email.Text = t_shop.Text = password.Text = " ";
            }
            void next()
            {
                CLogin ss = new CLogin();
                ss.Show();
                this.Hide();
            }

        }
    }
}
