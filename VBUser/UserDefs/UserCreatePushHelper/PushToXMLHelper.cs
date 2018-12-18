using System;
using System.Collections.Generic;
using System.IO;
using System.Text;



namespace VBUser.UserDefs.UserCreatePushHelper
{
    public class PushToXMLHelper
    {
        string _pathOfXml;
        string[]  _infoArray;

        /// <summary>
        /// Must place the user creator in this. 
        /// </summary>
        /// <param name="userCreator"></param>
        public PushToXMLHelper( UserCreator userCreator)
        {
            _infoArray = userCreator.GetUserInformation();
            _pathOfXml = "C:\\Users\\kirk\\Desktop\\PathToUsers\\"; //Default for testing purposes. 
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool  CreateUser()
        {
            bool results = false;

            using (var tw = new StreamWriter(_pathOfXml + CreateFileName(), true))
            {
                tw.WriteLine($"<USERID id = {CreateFileName()}>");
                tw.WriteLine($"     <FirstName>{_infoArray[0]}<\\FirstName>");
                tw.WriteLine($"     <LastName>{_infoArray[1] }<\\LastName>");
                tw.WriteLine($"     <MiddleInit>{_infoArray[2]}<\\MiddleInit>");
                tw.WriteLine($"<\\USERID >");
            }

            return results;
        }

        private string CreateFileName()
        {
            string fileName = "";

            string fname, lName, mName;
            fname = _infoArray[0];
            lName = _infoArray[1];
            mName = _infoArray[2];


            fileName = fname.Substring(0,1) + mName.Substring(0, 1) + lName.Substring(0, 1)+".usr";

            return fileName;
        }
        
    }
}
