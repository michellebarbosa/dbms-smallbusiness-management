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
    public partial class CReg : Form
    {
        OracleConnection CON1;
        OracleCommand CMD;
        string QUERY;
        int TEMP, I;
        OracleDataReader RDR;

        public CReg()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CReg_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            CLogin f1 = new CLogin();
            f1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username.Text== " "|| email.Text==null || location.Text==null || password.Text== null)
            {
                MessageBox.Show("Enter All the Details ");
            }
           
            else
               if (password.Text == confirm_password.Text)
            {
                I = 0;

                QUERY = "select * from creg where username='" + username.Text + "' ";
                CON1.Open();
                CMD = new OracleCommand(QUERY, CON1);

                RDR = CMD.ExecuteReader();

                while (RDR.Read())
                {
                    if (RDR["username"] == username.Text)
                        I = 1;
                    else
                        I = I;
                }
                RDR.Close();
                CON1.Close();

                if (I == 1)
                {
                    MessageBox.Show(" username exists");
                    username.Text = " ";
                    username.Focus();
                }
                else
                {
                    CON1.Open();
                    QUERY = "Insert into creg(username,email,location,password) values('" + username.Text + "','" + email.Text + "','" + location.Text + "','" + password.Text + "')";
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
                MessageBox.Show("PASSWORDS DO NOT MATCH");
                password.Text = "";
                confirm_password.Text = "";
                password.Focus();
            }


          
              

                void clear()
                {
                    username.Text = email.Text = location.Text = password.Text = " ";
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

