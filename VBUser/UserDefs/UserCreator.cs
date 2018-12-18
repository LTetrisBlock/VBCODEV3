using System;
using System.Collections.Generic;
using System.Text;

namespace VBUser.UserDefs
{
    public class UserCreator
    {
        private string[] inputArray = new string[7];
        private List<int> _skills;
        private List<int> _groups;

        public void SetFirstName(string str)
        {
            inputArray[0] = str;

        }

        public void SetLastName(string str)
        {
            inputArray[1] = str;
        }


        public void SetMiddleInit(string str)
        {
            inputArray[2] = str;

        }

        public void DefaultGroup(string str)
        {
            inputArray[3] = str;
        }


        public void StartWorkTime(string str)
        {
            inputArray[4] = str;
        }


        public void EndWorkTime(string str)
        {
            inputArray[5] = str;
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
            return inputArray;
        }
    }
}
