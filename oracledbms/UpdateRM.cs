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
    public partial class UpdateRM : Form
    {
       
        public UpdateRM()
        {
            InitializeComponent();
        }

        private void UpdateRM_Load(object sender, EventArgs e)
        {
            //productn.setVisible(false);
            //price.setEditable(false);

        }

        private void button1_Click(object sender, EventArgs e)
        {


            string oradb = "Data Source=DESKTOP-5IH3S49;User Id=michelle ;Password=Ilovescience08;";

            OracleConnection conn = new OracleConnection(oradb);

            conn.Open();

            OracleCommand cmd = new OracleCommand();

            cmd.Connection = conn;

            cmd.CommandText = "update materials SET pname = '" + textBox2.Text + "', pprice = '" + textBox3.Text + "', quantity= '" + textBox4.Text + "' , sname =" + textBox5.Text + ", contact =  " + textBox6.Text + ",  address =" + textBox7.Text + "WHERE shopn = "+ shopn.Text;

            int rowsUpdated = cmd.ExecuteNonQuery();

            if (rowsUpdated == 0)

                MessageBox.Show("Record not inserted");


            else

                MessageBox.Show("Success!");
            this.Hide();
            SLogin f4 = new SLogin();
            f4.ShowDialog();

            conn.Dispose();

        }




        public class TransparentPanel : Panel
        {
            protected override CreateParams CreateParams
            {
                get
                {
                    CreateParams cp = base.CreateParams;
                    cp.ExStyle |= 0x00000020; // WS_EX_TRANSPARENT
                    return cp;
                }
            }
            protected override void OnPaintBackground(PaintEventArgs e)
            {
                //base.OnPaintBackground(e);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
