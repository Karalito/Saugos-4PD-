using _4PD_Saugumas.Models;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _4PD_Saugumas.Repositories
{
    internal class UserRepository
    {
        private string con = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ASUS\\Desktop\\VIKO\\2 Kursas\\S2\\Informacijos Saugumas\\4PD_Saugumas\\4PD_Saugumas\\PD4SaugumoDB.mdf";

        public User Login(string Username, string Password)
        {
            User user = new User();

            try
            {
                SqlConnection sqlCon = new SqlConnection(con);

                SqlCommand cmd = new SqlCommand("SELECT * FROM UserTbl WHERE UserName=@Username AND UserPassword=@Password", sqlCon);
                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.Parameters.AddWithValue("@Password", Password);

                sqlCon.Open();

                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    int id = int.Parse(dataReader["Id"].ToString());
                    string username = dataReader["UserName"].ToString();
                    string password = dataReader["UserPassword"].ToString();
                    string firstlogin = dataReader["FirstLogin"].ToString();

                    user.UserID = id;
                    user.UserName = username;
                    user.UserPassword = password;
                    user.FirstLogin = firstlogin;
                }

                sqlCon.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
            return user;
        }

        public User RegisterUser(User user)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(con);
                sqlCon.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM [UserTbl] WHERE UserName=@Username", sqlCon);
                cmd.Parameters.AddWithValue("@Username", user.UserName);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    MessageBox.Show("The Username you chosen already exists, please select different username !");
                    return null;
                }
                dr.Close();

                SqlCommand sql = new SqlCommand("INSERT INTO [UserTbl] (UserName,UserPassword, FirstLogin)" +
                    " VALUES (@Username,@Password, @Firstlogin)", sqlCon);


                sql.Parameters.AddWithValue("@Username", user.UserName);
                sql.Parameters.AddWithValue("@Password", user.UserPassword);
                sql.Parameters.AddWithValue("@Firstlogin", user.FirstLogin);

                sql.ExecuteNonQuery();
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return user;
        }

        public void UpdateFirstTimeLogin(string username)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(con);

                SqlCommand cmd = new SqlCommand("UPDATE UserTbl SET FirstLogin = @firstlogin WHERE UserName=@Username", sqlCon);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@firstlogin", "No");

                sqlCon.Open();

                cmd.ExecuteNonQuery();
                sqlCon.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
    }
}