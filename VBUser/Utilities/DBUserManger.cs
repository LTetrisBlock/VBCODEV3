using System;
using System.Collections.Generic;
using UserDefs;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace UserDefs.DBManager
{
   public class DbUtitlity : IDisposable
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
        public DbUtitlity(string[] data)
        {
            _data = data;
        }

        public DbUtitlity()
        {
           
        }

        public void InputCreds(string userName, string password, string database)
        {
            _userName = userName;
            _password = password;
            _database = database;
        }



        /// <summary>
        /// Given a blank user, this will push information from the database to it.  
        /// </summary>
        /// <param name="givenUser"></param>
        /// <returns></returns>
        public static int PullInformationForGivenUser(ref AuxUser givenUser, int id)
        { 
            int code = 0;
            ActiveUserBuilder activeUserBuilder = new ActiveUserBuilder();

    
            return code; 
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="givenUser"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static int PullInformationForGivenUserActive(ref ActiveUser givenUser, int id)
        {
            int code = 0;




            return code;
        }

        /// <summary>
        /// With the data string, this will create a new user. 
        /// </summary>
        /// <returns></returns>
        public int CreateANewUser(string[] skills)
        {
            int code =  0;
            Login();

            object pullUserID = "";


            using (MySqlConnection mConnection = new MySqlConnection(_connectionString))
            {
                mConnection.Open();
                string Command = "INSERT INTO iconTable (userFirstName, userLastName ) VALUES (@FirstName, @LastName);";
                using (MySqlCommand myCmd = new MySqlCommand(Command, mConnection))
                {
                    myCmd.Parameters.AddWithValue("@FirstName", _data[0]);
                    myCmd.Parameters.AddWithValue("@LastName", _data[1]);
                    int result = myCmd.ExecuteNonQuery();
                    pullUserID = myCmd.LastInsertedId.ToString();
                }

                /*Command = "SELECT userID FROM iconTable ORDER BY userID desc LIMIT 1";


                using (MySqlCommand myCmd = new MySqlCommand(Command, mConnection))
                {

                    MySqlDataReader reader = myCmd.ExecuteReader();
                    while (reader.Read())
                    {
                        pullUserID = $"{reader.GetString("userID")}";
                    }
                    mConnection.Close();
                }
                */


            }
            

            for (int i = 0; i < skills.Length; i++)
            {
                using (MySqlConnection mConnection = new MySqlConnection(_connectionString))
                {
                    mConnection.Open();
                    string Command = "INSERT INTO userSkillTable (userID, skillID ) VALUES (@userID, @skillID);";
                    using (MySqlCommand myCmd = new MySqlCommand(Command, mConnection))
                    {
                        myCmd.Parameters.AddWithValue("@userID", pullUserID);
                        myCmd.Parameters.AddWithValue("@skillID", skills[i]);

                        int result = myCmd.ExecuteNonQuery();
                        mConnection.Close();
                    }
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
        public List<string[]> CollectDataFromDb()
        {
            Login();

            List<string[]> data = new List<string[]>();

            string Command = " SELECT * FROM iconTable"; ;
            using (MySqlConnection mConnection = new MySqlConnection(_connectionString))
            {
                mConnection.Open();

                using (MySqlCommand myCmd = new MySqlCommand(Command, mConnection))
                {
                    MySqlDataReader reader = myCmd.ExecuteReader();

            
                    while (reader.Read())
                    {
                        string[] test = new string[3];
                        test[0] = $"{reader.GetString("userID")};";
                        test[1] = $"{reader.GetString("UserFirstName")};";
                        test[2] = $"{reader.GetString("UserLastName")};";
                        data.Add(test);
                    }

                    mConnection.Close();
                    return data;
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