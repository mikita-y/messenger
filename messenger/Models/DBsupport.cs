using System;
using System.Data.SqlClient;

namespace messenger.Models
{
    public class DBsupport
    {
        public static string search(string name)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-UV7D341\SQLEXPRESS;Initial Catalog=messenger;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand search = connect.CreateCommand();
            search.CommandText = @"SELECT Pass FROM Users WHERE Login = '" + name + @"'";
            connect.Open();
            string pass = "";
            using (SqlDataReader reader = search.ExecuteReader())
            {
                reader.Read();
                try
                {
                    pass = string.Format(reader.GetString(0));
                }
                catch (Exception)
                {
                    return pass;
                }
            }
            connect.Close();
            return pass;
        }
        public static void add(string name, string pass)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-UV7D341\SQLEXPRESS;Initial Catalog=messenger;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            
            var cmd = new SqlCommand("INSERT INTO [Users] ( [Login], [Pass]) VALUES (@login, @pass)", connect);
            cmd.Parameters.AddWithValue("@login", name);
            cmd.Parameters.AddWithValue("@pass", pass);
            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Close();
        }
        public static User GetUser(string name)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-UV7D341\SQLEXPRESS;Initial Catalog=messenger;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand getID = connect.CreateCommand();
            SqlCommand getPass = connect.CreateCommand();
            getID.CommandText = @"SELECT id FROM Users WHERE Login = '" + name + @"'";
            getPass.CommandText = @"SELECT Pass FROM Users WHERE Login = '" + name + @"'";
            User user = new User();
            user.Name = name;
            connect.Open();
            using (SqlDataReader reader = getPass.ExecuteReader())
            {
                reader.Read();
                user.Pass = string.Format(reader.GetString(0));
            }
            connect.Close();
            connect.Open();
            using (SqlDataReader reader = getID.ExecuteReader())
            {
                reader.Read();
                user.Id = reader.GetInt32(0);
            }
            connect.Close();
            return user;
        }
    }
}