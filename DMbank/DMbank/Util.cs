using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMbank
{
    class Util
    {
        public static bool LogStatus(String statusText)
        {
            bool status = false;
            //Statement starts false
            try
            {
                System.IO.File.WriteAllText(Directory.GetCurrentDirectory() + "statuslog.txt", statusText);
                status = true;
                //Statement becomes true if the statuslog completes, if not it remains false
            }
            catch (Exception ex)
            {

            }
            finally
            {
                
            }
            return status;
            //returns either true or false depending on whether the statuslog completes
        }
    }
}
