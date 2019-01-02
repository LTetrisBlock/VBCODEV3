using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using UserDefs.DBManager;

namespace VBUser.UserDefs
{
    public class UserCreator : IDisposable
    {
        private string[] _inputArray = new string[12];
        private List<int> _skills;
        private List<int> _groups;

        private string _dbPass;
        private string _db;
        private string _dbUserName;




        public void SetFirstName(string str)
        {
            _inputArray[0] = str;

        }

        public void SetLastName(string str)
        {
            _inputArray[1] = str;
        }


        public void SetMiddleInit(string str)
        {
            _inputArray[2] = str;

        }

        public void DefaultGroup(string str)
        {
            _inputArray[3] = str;
        }


        public void StartWorkTime(string str)
        {
            _inputArray[4] = str;
        }


        public void EndWorkTime(string str)
        {
            _inputArray[5] = str;
        }


        public void Setdb(string str)
        {
            _db = str;
        }

        public void SetDbPass(string str)
        {
            _dbPass = str;

        }

        public void SetDbUser(string str)
        {
            _dbUserName = str;
        }


        /// <summary>
        /// Will add a new skill to the skils
        /// </summary>
        /// <param name="skill"></param>
        public void AddSkill(int skill)
        {
            _skills.Add(skill);
        }



        public int[] GetSkillsArray()

        {
            return _skills.ToArray();

        }

        /// <summary>
        /// Will add a new skill to the skils
        /// </summary>
        /// <param name="skill"></param>
        public string[] GetUserInformation()
        {
            return _inputArray;
        }

        /// <summary>
        /// Adds the new user to the database. 
        /// </summary>
        /// <returns></returns>
        public int AddNewUserToDatabase()
        {
            int code = 0;

            using (DbUtitlity dbUtil = new DbUtitlity(_inputArray))
            {
                dbUtil.InputCreds(_dbUserName, _dbPass, _db);
                dbUtil.CreateANewUser();
            }
            return code;
        }

        public void Dispose()
        {
            _dbPass = "000000000000";
            _db = "000000000000";
            _dbUserName = "000000000000";
        }
    }
}
