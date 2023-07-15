using Microsoft.Data.Sqlite;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace project_deliverable_4
{
    
    
    public class Database
    {
        //private const string database_fp = "C:\\Users\\snipe\\OneDrive\\Documents\\GitHub\\swe6783-project-deliverable4-group2-sum2023\\project-deliverable-4\\storage\\database.db";
        private const string database_fp = "database.db";
        private const string login_table = "login";
        private const string login_table_name = "username";
        private const string login_table_pwd = "password";


        public Database()
        {
            InitializeDB();
            /*var new_acc = CreateNewAccount(username: "help2", password: "dont_help3");
            var valid_acc = CheckValidAccount(username: "help", password: "dont_help");
            MessageBox.Show(new_acc.ToString() + "\n" + valid_acc.ToString());*/
        }

        private void InitializeDB()
        {
            if (!File.Exists(database_fp))
            {
                File.Create(database_fp);
            }

            var conn = GetConnection();
            string createTable = "CREATE TABLE IF NOT EXISTS " + login_table + " (id INTEGER PRIMARY KEY, " + login_table_name + " TEXT, " + login_table_pwd + " TEXT)";

            using (SqliteCommand command = new SqliteCommand(createTable, conn))
            {
                command.ExecuteNonQuery();
            }
            conn.Close();
        }

        public SqliteConnection GetConnection()
        {
            var conn = new SqliteConnection("Data Source=" + database_fp);
            conn.Open();
            return conn;
        }

        public bool CreateNewAccount(string username, string password)
        {

            var conn = GetConnection();
            string accExists_query = "SELECT * FROM login WHERE username='" + username + "'";
            SqliteCommand accExists_cmd = new SqliteCommand(accExists_query, conn);
            using SqliteDataReader reader = accExists_cmd.ExecuteReader();
            bool accExists = reader.Read(); // 
            if (accExists) 
            {
                conn.Close();
                return false;
            }
            string accAdd_query = "insert into login(username, password) values('" + username + "','" + password + "')";
            SqliteCommand accAdd_cmd = new SqliteCommand(accAdd_query, conn);
            accAdd_cmd.ExecuteNonQuery();
            conn.Close();
            return true;
        }

        public bool CheckValidAccount(string username, string password)
        {
            var conn = GetConnection();
            string query = "SELECT * FROM login WHERE username='" + username + "' AND password='" + password + "'";
            SqliteCommand cmd = new SqliteCommand(query, conn);
            using SqliteDataReader reader = cmd.ExecuteReader();
            bool validAccount = reader.Read(); // 
            conn.Close();
            return validAccount;
        }

       
    }
}
