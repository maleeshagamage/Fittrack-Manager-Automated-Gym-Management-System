using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FittrackMS
{
    public static class UserSession
    {
        public static int UserID { get; set; }
        public static int StaffID { get; set; } 
        public static string Role { get; set; }
       

        public static void ClearSession()
        {
            UserID = 0;
            StaffID = 0;
            Role = null;
        
        }
    }


}
