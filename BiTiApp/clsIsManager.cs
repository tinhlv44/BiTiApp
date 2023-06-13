using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BiTiApp
{
    public class clsIsManager
    {
        private static bool isManager = false;
        private static DataRow inforAcc;
        public clsIsManager()
        {
        }
        public static bool getIsManager()
        {
            return isManager;
        }
        public static DataRow getAcc()
        {
            return inforAcc;
        }
        public static void setIsManager(bool isManager)
        {
            clsIsManager.isManager = isManager;
        }
        public static void saveAcc(DataRow inforAcc)
        {
            clsIsManager.inforAcc = inforAcc;
        }
        
    }
}
