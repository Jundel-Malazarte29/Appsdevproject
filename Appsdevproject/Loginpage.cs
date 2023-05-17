using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appsdevproject
{
    public partial class Loginpage : Form
    {
        public Loginpage()
        {
            InitializeComponent();
        }

        private void Loginpage_Load(object sender, EventArgs e)
        {

        }
        private void signinBTN_Click(object sender, EventArgs e)
        {
            var Dashboard = new Dashboard();
            Dashboard.Show();
            this.Hide();
        }
    }
}
