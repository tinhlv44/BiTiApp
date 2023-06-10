using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiTiApp
{
    public class clsIsManager
    {
        private static bool isManager = false;
        public clsIsManager()
        {
        }
        public static bool getIsManager()
        {
            return isManager;
        }
        public static void setIsManager(bool isManager)
        {
            clsIsManager.isManager = isManager;
        }
    }
}
