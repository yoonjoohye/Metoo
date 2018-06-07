using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ME_TOO.Models
{
    public class CInstance
    {
        public static CUserManager theUserManager;
        public static int bInit = 0;
        internal static void Initialize()
        {
            if (bInit == 0)
            {
                theUserManager = new CUserManager();
            }
            bInit = 1;
        }
    }
}