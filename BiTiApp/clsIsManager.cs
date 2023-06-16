using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiTiApp
{
    public class clsIsManager
    {
        private static bool isManager = false;
        private static DataRow inforAcc;
        private static string OrderID;
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
        public static DataRow getAcc()
        {
            return inforAcc;
        }
        public static void saveAcc(DataRow inforAcc)
        {
            clsIsManager.inforAcc = inforAcc;
        }
        public static string getOrderID()
        {
            return OrderID;
        }
        public static void saveOrderID(string OrderID)
        {
            clsIsManager.OrderID = OrderID;
        }
    }
}
