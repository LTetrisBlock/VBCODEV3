/* Copyright (C) VirtualBrick.IO, Inc - All Rights Reserved
 * Unauthorized copying of this file, via any medium is strictly prohibited
 * Proprietary and confidential
 * Written by Kirk Montrose
 */

using System;
using System.Collections.Generic;
using System.Text;


namespace UserDefs
{
    /// <summary>
    /// This class will 
    /// </summary>
    public class TimeInfo
    {
        int _userStartTime = -1;
        int _userEndTime = -1;

         
        /// <summary>
        /// When creating a instance of this, a time must be speficed. 
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        public TimeInfo(int startTime, int endTime)
        {
            _userStartTime = startTime;
            _userEndTime = endTime;
        }

        /// <summary>
        /// This will collect the percent of time left in the users stated working day,.
        /// this will grab the current time and use the start time of the user to calculte the
        /// how much of they day has passed
        /// </summary>
        /// <returns></returns>
        public double PercentTimeFile()
        {
            double timeFilled = -1;
            string currentTime = DateTime.Now.ToString("HH:mm");
            string newtime = currentTime.Replace(":", "");
            int cTime = int.Parse(newtime);

            if (UserAtWork())
            {
                timeFilled = (((double)cTime - (double)_userStartTime)) / ((double)_userEndTime - (double)_userStartTime);
                Console.WriteLine(cTime - _userStartTime);
                Console.WriteLine(_userEndTime - _userStartTime);
                Console.WriteLine(timeFilled);

            }
            return timeFilled;
        }


        /// <summary>
        /// Shows that the current time is outside the user work day 
        /// </summary>
        /// <returns></returns>
        public bool UserAtWork()
        {
            bool atWork;
            string currentTime = DateTime.Now.ToString("HH:mm");
            string newtime = currentTime.Replace(":", "");

            int iStr = int.Parse(newtime);

            if (iStr > _userStartTime && iStr < _userEndTime)
            {
                atWork = true;
            }
            else
            {
                atWork = false;
            }

            return atWork;
        }



    }
}
