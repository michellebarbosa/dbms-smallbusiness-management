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
    public partial class SHome : Form
    {

        OracleConnection CON1;
        OracleCommand CMD;
        string QUERY;
        int TEMP, I;
        OracleDataReader RDR;

        public SHome()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SHome_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome logged username : " + globals.sname);
            name.Text = ":" + globals.sname;

        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SLogin f4 = new SLogin();
            f4.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            RMaterials f4 = new RMaterials();
            f4.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            Inventory f4 = new Inventory();
            f4.ShowDialog();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            //this.Hide();
            //CDetails f4 = new CDetails();
            //f4.ShowDialog();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //string message = "Are you sure you want to delete your account?";
            //string title = "Close Window";
            //MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            //DialogResult result = MessageBox.Show(message, title, buttons);
            //if (result == DialogResult.Yes)
            //{
            //    string oracleconnection = "DATA SOURCE =  DESKTOP-5IH3S49; USER ID = michelle; PASSWORD =Ilovescience08";
            //    OracleConnection con = new OracleConnection(oracleconnection);
            //    con.Open();
            //    OracleCommand cmd = new OracleCommand();
            //    cmd.CommandText = "DELETE sname.sreg where sname = " + name.Text;

            //    int r = cmd.ExecuteNonQuery();
            //    if (r == 0)
            //        MessageBox.Show("Insertion failed");
            //    else
            //        MessageBox.Show("Success!");


            //    con.Close();

            //}
            //else
            //{


            //    this.Hide();
            //    SHome f4 = new SHome();
            //    f4.ShowDialog();

            MessageBox.Show("Success!");
        }







        }
    }

