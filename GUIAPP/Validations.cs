using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GUIAPP
{
    class Validations
    {
        public static string errMsg= "Time is not set";
        /*  number validation*/
        public static bool numberVal(string val)
        {
            string pattern = @"\d+.";
            System.Text.RegularExpressions.Match m = Regex.Match(val, pattern);


            if (!m.Success)
            {

                errMsg = "*invalid entry.!";
                //errmsg["numberVal"]=errormsg_numberVal;
                return false;
            }
            else
            {
                errMsg = "Time is set";
                //errmsg["numberVal"] = errormsg_numberVal;
                return true;
            }

        }

    }
}
