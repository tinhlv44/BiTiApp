using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiTiApp
{
    public class IsManager
    {
        private static bool isManager = false;
        public IsManager()
        {
        }
        public static bool getIsManager()
        {
            return isManager;
        }
        public static void setIsManager(bool isManager)
        {
            IsManager.isManager = isManager;
        }
    }
}
