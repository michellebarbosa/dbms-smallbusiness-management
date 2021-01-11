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
    public partial class RMaterials : Form
    {
        public RMaterials()
        {
            InitializeComponent();
        }

        private void RMaterials_Load(object sender, EventArgs e)
        {
            
            textBox1.Text = globals.sname;
            string oradb = "Data Source=DESKTOP-5IH3S49 ;User Id=michelle ;Password=Ilovescience08;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            //OracleDataAdapter sda = new OracleDataAdapter("select * from sreg where sname = @sname ", conn);
            //sda.SelectCommand.Parameters.Add("@sname", sname.Text);

            string query = "SELECT * FROM materials WHERE shopn='" + textBox1.Text + "'";
            OracleDataAdapter sda = new OracleDataAdapter(query, conn);


            DataTable dt = new DataTable("materials");

           

            sda.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();




        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddRM f4 = new AddRM();
            f4.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            




        }


        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {




        }

        private void button3_Click(object sender, EventArgs e)
        {
            string oradb = "Data Source= DESKTOP-5IH3S49;User Id=michelle;Password=Ilovescience08;";
            
                using (OracleConnection con = new OracleConnection(oradb))
                {
                    con.Open();
                    OracleCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from materials where pname ='" + textBox3.Text + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deletion successfull");
                    dataGridView1.Update();
                    dataGridView1.Refresh();
                }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            string oradb = "Data Source= DESKTOP-5IH3S49;User Id=michelle;Password=Ilovescience08;";
            if (radioButton1.Checked)
            {
                using (OracleConnection con = new OracleConnection(oradb))
                {
                    con.Open();
                    OracleCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update materials set pname  ='" + textBox2.Text + "'where pname ='" + textBox3.Text + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update successfull");
                    dataGridView1.Update();
                    dataGridView1.Refresh();
                }


            }
            else if (radioButton2.Checked)
            {
                using (OracleConnection con = new OracleConnection(oradb))
                {
                    con.Open();
                    OracleCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update materials set pprice  ='" + textBox2.Text + "'where pname ='" + textBox3.Text + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update successfull");
                    dataGridView1.Update();
                    dataGridView1.Refresh();
                }


            }
            else if (radioButton3.Checked)
            {
                using (OracleConnection con = new OracleConnection(oradb))
                {
                    con.Open();
                    OracleCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update materials set pquantity  ='" + textBox2.Text + "'where pname ='" + textBox3.Text + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update successfull");
                    dataGridView1.Update();
                    dataGridView1.Refresh();
                }


            }
            else if (radioButton4.Checked)
            {
                using (OracleConnection con = new OracleConnection(oradb))
                {
                    con.Open();
                    OracleCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update materials set sellername  ='" + textBox2.Text + "'where pname ='" + textBox3.Text + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update successfull");
                    dataGridView1.Update();
                    dataGridView1.Refresh();
                }


            }
            else if (radioButton5.Checked)
            {
                using (OracleConnection con = new OracleConnection(oradb))
                {
                    con.Open();
                    OracleCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update materials set contact  ='" + textBox2.Text + "'where pname ='" + textBox3.Text + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update successfull");
                    dataGridView1.Update();
                    dataGridView1.Refresh();
                }


            }
            else if (radioButton6.Checked)
            {
                using (OracleConnection con = new OracleConnection(oradb))
                {
                    con.Open();
                    OracleCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update materials set address  ='" + textBox2.Text + "'where pname ='" + textBox3.Text + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update successfull");
                    dataGridView1.Update();
                    dataGridView1.Refresh();
                }


            }
            else 
            {
                MessageBox.Show("Please select a checkbox. ");


            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SLogin f4 = new SLogin();
            f4.ShowDialog();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
