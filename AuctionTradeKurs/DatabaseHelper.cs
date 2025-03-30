using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionTradeKurs
{
    internal class DatabaseHelper
    {
        private string connectionString = "Host=myserver;Username=mylogin;Password=mypass;Database=mydatabase";

        public void RegisterUser(string username, string password, string role)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("INSERT INTO Users (Username, Password, Role) VALUES (@Username, @Password, @Role)", conn))
                {
                    cmd.Parameters.AddWithValue("Username", username);
                    cmd.Parameters.AddWithValue("Password", password); // Хэширование пароля рекомендуется
                    cmd.Parameters.AddWithValue("Role", role);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool AuthenticateUser(string username, string password)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT COUNT(1) FROM Users WHERE Username = @Username AND Password = @Password", conn))
                {
                    cmd.Parameters.AddWithValue("Username", username);
                    cmd.Parameters.AddWithValue("Password", password);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}
