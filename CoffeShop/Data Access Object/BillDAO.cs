using CoffeShop.Data_Transfer_Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop.Data_Access_Object
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        { get { if (instance == null) instance = new BillDAO(); return instance; }
          private set => instance = value;
        }
        private BillDAO() { }
        public int GetUncheckedBillIDByTableID(int id) //trả về bill ID nếu chưa thanh toán ngược lại trả về -1
        {
            DataTable data = DataProvider.Instance.ExecuteQuery(" Select * from Bill where idTable = " + id +" and status = 0");
            if(data.Rows.Count > 0)   
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }
        public void InsertBill(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBill @idTable", new object[] { id });
        }
        public int GetLastestIDBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("select max(id) from Bill");
            }
            catch
            {
                return 1;
            }
                
        }
        public void CheckOut(int id, int discount)
        {
            string query = "update Bill set status = 1, " +"discount = " +discount+" where id = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
