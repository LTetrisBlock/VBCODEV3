using System;
using System.Collections.Generic;
using System.Text;
using UserDefs;
using UserDefs.DBManager;



namespace VBCORE3
{
    public class VBSession
    {

        private ActiveUser _activeUser = new ActiveUser();
        private AuxUser[] _auxUsers;


        /// <summary>
        /// Constructor that builds things. 
        /// </summary>
        public VBSession(int userID)
        {
                                                           //Pull out aux users, this will be based on the users default. 
        }

        /// <summary>
        /// This starts the session. This will be called by the application 
        /// </summary>
        /// <returns> 
        /// -1, This means there was an unknown error. 
        ///  1 means successful run.
        /// </returns>
        public int StartSession(int userID)
        {
            int code = -1;

            try
            {
                int extractMainCode = DbUtitlity.PullInformationForGivenUserActive(ref _activeUser, userID);    //This will populate the given user with information from the database. 
                ExtractAuxUsers();
            }

            catch (Exception e) //if anything goes wrong thats not accounted for then return -1
            {
                return -1;
            }


            return code;
        }

   
        /// <summary>
        /// With the given users it will extract all the users aux users in the group. 
        /// </summary>
        private void  ExtractAuxUsers()
        {
            _auxUsers = _activeUser.GetCurrentAuxUsers();
        }

    }
}
