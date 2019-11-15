using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop.Data_Transfer_Object
{
    public class BillInfo
    {
        public int ID { get; set; }
        public int BillID { get; set; }
        public int FoodID { get; set; }
        public int FoodCount { get; set; }
        public BillInfo(int iD, int billID, int foodID, int foodCount)
        {
            ID = iD;
            BillID = billID;
            FoodID = foodID;
            FoodCount = foodCount;
        }
        public BillInfo(DataRow row)
        {
            ID = (int)row["id"];
            BillID = (int)row["idBill"];
            FoodID = (int)row["idFood"];
            FoodCount = (int)row["count"];
        }
    }
}
