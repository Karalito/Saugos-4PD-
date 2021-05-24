using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _4PD_Saugumas.Functions;
using _4PD_Saugumas.Models;
using _4PD_Saugumas.Repositories;

namespace _4PD_Saugumas.Forms
{
    public partial class LoginForm : Form
    {
        private UserRepository userRepos;
        public LoginForm()
        {
            InitializeComponent();
            userRepos = new UserRepository();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (usernameTxt.Text != string.Empty)
                if (passwordTxt.Text != string.Empty)
                {
                    // Funkcija prisijungimui
                    User user = userRepos.Login(usernameTxt.Text, passwordTxt.Text);
                    if (user != null)
                    {
                        MessageBox.Show("Prisijungimas Sėkmingas !");
                        
                        PswManagerForm pmf = new PswManagerForm(user);
                        this.Hide();
                        pmf.ShowDialog();
                        this.Close();
                    }
                    else
                        MessageBox.Show("Blogai įvesti prisijungimo duomenys !");
                }
                else
                    MessageBox.Show("Slaptažodžio laukas negali būti tuščias !");
            else
                MessageBox.Show("Vartotojo vardo laukas negali būti tuščias !");
        }
    }
}
