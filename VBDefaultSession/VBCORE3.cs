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
            DbUtitlity.PullInformationForGivenUser(ref _activeUser, userID);    //This will populate the given user with information from the database. 
            ExtractAuxUsers();                                                  //Pull out aux users, this will be based on the users default. 
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
