using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oracledbms
{
    public partial class CHome : Form
    {
        public CHome()
        {
            InitializeComponent();
        }

        private void CHome_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome logged username : " + globals.username);
            name.Text = ":" + globals.username;
        }
    }
}
