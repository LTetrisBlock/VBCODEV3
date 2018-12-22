using System;
using System.Collections.Generic;
using WorkGroup;

namespace UserDefs
{
   public abstract class UserConstruct
    {
        private int _userID;
        private string _userName;
        private string _userFName;
        private string _userLName;
    
        private double _userTimeZome;
        private int[] _skillsList;



        private double x;
        private double y;
        private TimeInfo _timeInfo; //Helps performe user time based functions. 


        /// <summary>
        /// Creates the time information class, This will peform all time calculations. 
        /// </summary>
        /// <param name="s"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public bool CreateTimeInformation(int s, int e )
        {
            bool r = false;

            //If time information is correct then run the function. 
            if (IsTimeInformationOk(s, e))
            {
                _timeInfo = new TimeInfo(s, e);
                r = true;
            }
            return r;
        }

       /// <summary>
       /// Checks to see if the user is at work based on 
       /// the current time 
       /// </summary>
       /// <returns></returns>
        public bool IsUserAtWork()
        {
            bool r = false;
            if (_timeInfo != null)
            {
                r = _timeInfo.UserAtWork();
            }

            return r;
        }


        //Todo: needs to include local timezones changes. 
        /// <summary>
        /// Checks to see if the user is at work based on 
        /// the current time 
        /// </summary>
        /// <returns></returns>
        public double PercentWorkComplete()
        {
            double r = -1;
            if (_timeInfo != null)
            {
                r = _timeInfo.PercentTimeFile();
            }

            return r;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private bool IsTimeInformationOk(int s, int e)
        {
            bool r = true;  //ToDo: make this work. 


            return r;

        }



        /// <summary>
        /// This may be moved later. 
        /// </summary>
        public enum TimeZone
        {
            gmt0,
            gmt1,
            gmt2,
            gmt3,
        }

        /// <summary>
        /// Determines were to send the data. 
        /// </summary>
        public enum PushType
        {
            debug,
            ProdDB,
            DebugDB,
            XMlFile,
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="groupId"></param>
        public void ChangeCurrentGroup(int groupId)
        {

        }


        



        public bool PushUserData(PushType pt)
        {
            bool successfullPush = false;

            switch (pt)
            {
                case (PushType.XMlFile):
                    successfullPush = PushUserDataToXMLFile();
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
            return successfullPush;
        }




        /// <summary>
        /// Pushes 
        /// </summary>
        /// <returns></returns>
        private bool PushUserDataToDB()
        {
            bool successfullPushToDB = false;


            return successfullPushToDB;
        }


        /// <summary>
        /// This will be pushed to a local xml file containing the users data, this will be usefull so a pull is not needced from the db as the time
        /// </summary>
        /// <returns></returns>
        public bool PushUserDataToXMLFile()
        {
            bool successfullPushToDB = false;


            return successfullPushToDB;
        }



    }
}