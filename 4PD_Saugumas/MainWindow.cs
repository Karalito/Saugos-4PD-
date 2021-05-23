using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _4PD_Saugumas.Forms;

namespace _4PD_Saugumas
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.ShowDialog();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            RegisterForm rf = new RegisterForm();
            rf.ShowDialog();
        }
    }
}
