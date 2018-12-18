using System;
using System.Collections.Generic;
using System.Text;
using UserDefs;
using UserDefs.DBManager;



namespace VBDefaultSession
{
    class VBSession
    {
   
        private ActiveUser _activeUser = new ActiveUser();
        private AuxUser[] _auxUsers;
     

        /// <summary>
        /// Constructor that builds things. 
        /// </summary>
        public VBSession(int userID)
        {
            //This will populate the given user with information from the database. 
            DbUtitlity.PullInformationForGivenUser(ref _activeUser, userID);


            //Pull out aux users. 
            _auxUsers = _activeUser.GetCurrentAuxUsers();
        }


    }
}
