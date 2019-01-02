using System;
using System.Collections.Generic;
using System.Text;
using UserDefs.DBManager;
using VBUser.SkillsSets;

 namespace UserDefs
{
    /// <summary>
    /// This call is going to represent the active user.
    /// </summary>
   public  class ActiveUser : UserConstruct
    {
        private int _currentGroup;
        private SkillCollection _skillCollection;
        private int[] _userInGroup;


        /// <summary>
        /// This will return all the users groups 
        /// </summary>
        /// <returns></returns>
        public int[] GetUserGroups()
        {
            return _userInGroup;
        }

        /// <summary>
        /// This will set the current group to the given group. 
        /// </summary>
        /// <param name="groupId"></param>
        public void SetNewCurrentUserGroup(int groupId)
        {
            _currentGroup = groupId;
        }


        /// <summary>
        /// This will convert the list of int that represent aux users into a group. 
        /// </summary>
        /// <returns></returns>
        public AuxUser[] GetCurrentAuxUsers()
        {
            List<AuxUser> auxs = new List<AuxUser>();
            for (int i = 0; i < _userInGroup.Length; i++ )
            {

                AuxUser ax = new AuxUser();

                //Fill auz user with information from DB
                //DbUtitlity.PullInformationForGivenUser(ref ax, _userInGroup[i]);
                auxs.Add(ax);
            }
            return auxs.ToArray();
        }
            

        
       //public double GetPercentDayFinished()
       // {
       //  //   return base.PercentTimeFile();

       // }

        private bool BuildUserSKillSet()
        {
            bool results = false;



            return results;
        }

            




    }
}
