using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _4PD_Saugumas.Functions;
using _4PD_Saugumas.Models;
using _4PD_Saugumas.Repositories;

namespace _4PD_Saugumas.Forms
{
    public partial class RegisterForm : Form
    {
        private UserRepository userRepos;
        public RegisterForm()
        {
            InitializeComponent();
            userRepos = new UserRepository();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (usernameTxt.Text != string.Empty)
                if (passwordTxt.Text != string.Empty)
                    if (passwordTxt.Text == confirmPassTxt.Text)
                    {
                        // Funkcija naudotojo užregistravimui
                        User user = new User();

                        user.UserName = usernameTxt.Text;
                        user.UserPassword = passwordTxt.Text;
                        user.FirstLogin = "Yes";

                        User registeredUser = userRepos.RegisterUser(user);

                        if (registeredUser != null)
                            MessageBox.Show("Vartotojas sėkmingai sukurtas, dabar galite prisijungti !");
                        else
                            MessageBox.Show("Vartotojas nesukurtas, mėginkite dar kartą !");
                    }
                    else
                        MessageBox.Show("Įvesti slaptažodžiai nesutampa !");
                else
                    MessageBox.Show("Slaptažodžio laukas negali būti tuščias !");
            else
                MessageBox.Show("Vartotojo vardo laukas negali būti tuščias !");
        }
    }
}
