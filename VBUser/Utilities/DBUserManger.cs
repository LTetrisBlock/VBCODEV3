using System;
using System.Collections.Generic;
using UserDefs;
namespace UserDefs.DBManager
{
   public static class DbUtitlity
    {
        /// <summary>
        /// Given a blank user, this will push information from the database to it.  
        /// </summary>
        /// <param name="givenUser"></param>
        /// <returns></returns>
        public static int PullInformationForGivenUser(ref ActiveUser givenUser, int id)
        { 
            int code = 0;


            ActiveUserBuilder  activeUserBuilder = new ActiveUserBuilder()









            return code; 
        }


        public static int PullInformationForGivenUser(ref AuxUser givenUser, int id)
        {
            int code = 0;







            return code;
        }
    }
}