using _4PD_Saugumas.Functions;
using _4PD_Saugumas.Models;
using _4PD_Saugumas.Repositories;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace _4PD_Saugumas.Forms
{
    public partial class PswManagerForm : Form
    {
        private User user;
        private UserRepository userRepos;

        public PswManagerForm(User user)
        {
            userRepos = new UserRepository();
            InitializeComponent();
            this.user = user;
            CheckFirstLogin();
            dataGridView1.Columns[1].Visible = false;
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
                    sw.WriteLine("Vartotojo Vardas\tSlaptažodis\tURL/Aplikacija\tDaugiau informacijos");
                }
                userRepos.UpdateFirstTimeLogin(user.UserName);
                MessageBox.Show("Jūs prisijungėte pirmą kartą, todėl jums buvo sukurtas naujas failiukas jūsų vardu !");
            }
        }

        private void NewPswBtn_Click(object sender, EventArgs e)
        {
            newPswGroupBox.Visible = true;
            updatePswGroupBox.Visible = false;
            findPswGroupBox.Visible = false;
            deletePswGroupBox.Visible = false;
        }

        private void UpdatePswBtn_Click(object sender, EventArgs e)
        {
            newPswGroupBox.Visible = false;
            updatePswGroupBox.Visible = true;
            findPswGroupBox.Visible = false;
            deletePswGroupBox.Visible = false;
        }

        private void FindPswBtn_Click(object sender, EventArgs e)
        {
            newPswGroupBox.Visible = false;
            updatePswGroupBox.Visible = false;
            findPswGroupBox.Visible = true;
            deletePswGroupBox.Visible = false;
        }

        private void DeletePswBtn_Click(object sender, EventArgs e)
        {
            newPswGroupBox.Visible = false;
            updatePswGroupBox.Visible = false;
            findPswGroupBox.Visible = false;
            deletePswGroupBox.Visible = true;
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
                            string encryptedPassword = RSA.Encryption(pswTxt.Text);
                            string newText = ("\n" + userNameTxt.Text + "\t" + encryptedPassword + "\t" + urlAppTxt.Text + "\t" + additionalInfoTxt.Text);
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

        private void UpdatePsw_Click(object sender, EventArgs e)
        {
            if (updateUsernameTxt.Text != string.Empty)
                if (updatePswTxt.Text != string.Empty)
                    if (updateURLtxt.Text != string.Empty)
                    {
                        string dirPath = System.IO.Directory.GetCurrentDirectory();
                        string path = dirPath + "\\PasswordData\\" + user.UserName + ".txt";
                        if (File.Exists(path))
                        {
                            string encryptedPsw = RSA.Encryption(updatePswTxt.Text);
                            string newText = "\n" + updateUsernameTxt.Text.Trim() + "\t" + encryptedPsw + "\t" + updateURLtxt.Text.Trim() + "\t" + updateAdditionalInfoTxt.Text.Trim();
                            string[] lines = File.ReadAllLines(path);
                            foreach (string line in lines)
                            {
                                if (line.Contains(updateUsernameTxt.Text))
                                {
                                    var tempFile = Path.GetTempFileName();
                                    var linesToKeep = File.ReadAllLines(path).Where(l => l != updateUsernameTxt.Text);

                                    File.WriteAllLines(tempFile, linesToKeep);

                                    File.Delete(path);
                                    File.Move(tempFile, path);
                                }
                            }
                            File.AppendAllText(path, newText + Environment.NewLine);
                            MessageBox.Show("Slaptažodis sėkmingai atnaujintas !");
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

        private void FindPswBtn2_Click(object sender, EventArgs e)
        {
            if (findPswTxt.Text != string.Empty)
            {
                ReadAndFilter();

            }
            else
                MessageBox.Show("Įveskite norimo surasti slaptažodžio vartotojo vardą !");
        }

        private void ReadAndFilter()
        {
            try
            {
                dataGridView1.Rows.Clear();
                string dirPath = System.IO.Directory.GetCurrentDirectory();
                string path = dirPath + "\\PasswordData\\" + user.UserName + ".txt";

                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    string splitString = "\t";

                    string[] split = line.Split(new string[] { splitString }, StringSplitOptions.None);

                    if (findPswTxt.Text == split[0])
                    {
                        split[1] = RSA.Decryption(split[1]);
                        dataGridView1.Rows.Add(split);
                    }
                }
                //dataGridView1.Rows[0].Visible = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void showPsw_CheckedChanged(object sender, EventArgs e)
        {
            if (showPsw.Checked)
                dataGridView1.Columns[1].Visible = true;
            else
                dataGridView1.Columns[1].Visible = false;
        }
    }
}