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
    public partial class PswManagerForm : Form
    {
        User user;
        UserRepository userRepos;
        public PswManagerForm(User user)
        {
            userRepos = new UserRepository();
            InitializeComponent();
            this.user = user;
            CheckFirstLogin();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            string dirPath = System.IO.Directory.GetCurrentDirectory();
            string path = dirPath + "\\PasswordData\\" + user.UserName + ".txt";
            if (File.Exists(path))
            {
                AES.FileEncrypt(path, user.UserPassword);

                File.Delete(path);
            }
            else
                MessageBox.Show("There's no file to encrypt to AES !");
        }

        private void CheckFirstLogin()
        {
            string dirPath = System.IO.Directory.GetCurrentDirectory();
            string path = dirPath + "\\PasswordData\\" + user.UserName + ".txt";
            string AESpath = dirPath + "\\PasswordData\\" + user.UserName + ".txt.aes";
            if (File.Exists(AESpath))
            {
                Console.WriteLine("A");
                AES.FileDecrypt(AESpath, path, user.UserPassword);
            }
            Console.WriteLine(user.UserName + " " + user.UserPassword + " " + user.FirstLogin);
            if (user.FirstLogin == "Yes")
            {

                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Vartotojo Vardas      Slaptažodis     URL/Aplikacija      Daugiau informacijos");
                }
                userRepos.UpdateFirstTimeLogin(user.UserName);
                MessageBox.Show("Jūs prisijungėte pirmą kartą, todėl jums buvo sukurtas naujas failiukas jūsų vardu !");

            }
        }
        private void NewPswBtn_Click(object sender, EventArgs e)
        {
            newPswGroupBox.Visible = true;
        }

        private void UpdatePswBtn_Click(object sender, EventArgs e)
        {
            newPswGroupBox.Visible = false;
        }

        private void FindPswBtn_Click(object sender, EventArgs e)
        {
            newPswGroupBox.Visible = false;
        }

        private void DeletePswBtn_Click(object sender, EventArgs e)
        {
            newPswGroupBox.Visible = false;
        }

        private void SaveNewPswBtn_Click(object sender, EventArgs e)
        {
            if (userNameTxt.Text != string.Empty)
                if (pswTxt.Text != string.Empty)
                    if (urlAppTxt.Text != string.Empty)
                    {
                        // Funkcija slaptažodžio išsaugojimui
                        string dirPath = System.IO.Directory.GetCurrentDirectory();
                        string path = dirPath + "\\PasswordData\\" + user.UserName + ".txt";
                        if (File.Exists(path))
                        {

                            string newText = ("\n" + userNameTxt.Text + "     " + pswTxt.Text + "     " + urlAppTxt.Text + "     " + additionalInfoTxt.Text);
                            File.AppendAllText(path, newText + Environment.NewLine);

                            MessageBox.Show("Slaptažodis sėkmingai išsaugotas !");
                        }
                        else
                            MessageBox.Show("Nėra kur išsaugoti duomenų !");
                    }
                    else
                        MessageBox.Show("Neįvedėte Svetainės ar Programos kuriai bus išsaugotas slaptažodis pavadinimo !");
                else
                    MessageBox.Show("Neįvedėtė slaptažodžio !");
            else
                MessageBox.Show("Neįvedėte vartotojo vardo !");

        }
    }
}
