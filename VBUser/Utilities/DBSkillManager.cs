using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace VBUser.Utilities
{
   public class DBSkillManager : IDisposable
    {
        string[] _data;
        string _connectionString;
        string _table;

        string _userName;
        string _password;
        string _database;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        public DBSkillManager(string[] data)
        {
            _data = data;
        }

        public DBSkillManager()
        {

        }

        public void InputCreds(string userName, string password, string database)
        {
            _userName = userName;
            _password = password;
            _database = database;
        }

        /// <summary>
        /// With the data string, this will create a new user. 
        /// </summary>
        /// <returns></returns>
        public int CreateANewSkill(string skillN , string skillD)
        {
            int code = 0;
            Login();
            string Command = "INSERT INTO skillTable (skillName, skillDesc) VALUES (@SkillName, @SkillDesc);";

            using (MySqlConnection mConnection = new MySqlConnection(_connectionString))
            {
                mConnection.Open();

                using (MySqlCommand myCmd = new MySqlCommand(Command, mConnection))
                {
                    myCmd.Parameters.AddWithValue("@SkillName", skillN);
                    myCmd.Parameters.AddWithValue("@SkillDesc", skillD);

                    int result = myCmd.ExecuteNonQuery();
                    mConnection.Close();
                }
            }


            return code;
        }

        /// <summary>
        /// Creates the login string
        /// </summary>
        private void Login()
        {
            string server = "db-icon-r0d1.cxg8tgrsbrln.us-east-1.rds.amazonaws.com";
            string database = _database;
            string user = _userName;
            string password = _password;
            string port = "3306";
            string sslM = "none";

            _connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);

            MySqlConnection connection = new MySqlConnection(_connectionString);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string[] CollectDataFromDb()
        {
            Login();

            List<string> data = new List<string>();

            string Command = " SELECT * FROM skillTable"; ;
            using (MySqlConnection mConnection = new MySqlConnection(_connectionString))
            {
                mConnection.Open();

                using (MySqlCommand myCmd = new MySqlCommand(Command, mConnection))
                {
                    MySqlDataReader reader = myCmd.ExecuteReader();


                    while (reader.Read())
                    {
                        data.Add($"{reader.GetString("skillName")};");
                    }

                    mConnection.Close();
                    return data.ToArray();
                }
            }
        }





        /// <summary>
        /// Verifys the login informatio 
        /// </summary>
        /// <returns></returns>
        public bool VerifyLogin()
        {
            bool reVal = true;
            try
            {
                Login();
                using (MySqlConnection mConnection = new MySqlConnection(_connectionString))
                {
                    mConnection.Open();
                    mConnection.Close();
                }
            }
            catch
            {
                reVal = false;
            }
            return reVal;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            _userName = "000000000000000000000000";
            _password = "000000000000000000000000";
            _database = "000000000000000000000000";
        }

    }
}
