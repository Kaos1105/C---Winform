using CoffeShop.Data_Transfer_Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop.Data_Access_Object
{
    class TableDAO
    {
        private static TableDAO instance;

        internal static TableDAO Instance
        { get{ if(instance ==null) instance = new TableDAO();return instance; }
          private set => instance = value;
        }
        private TableDAO() { }
        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTableList");
            foreach(DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }
            return tableList;
        }
        public void Switchtable(int id1, int id2)
        {
            DataProvider.Instance.ExecuteQuery("USP_SwtichTable @idTable1 , @idTable2", new object[] { id1, id2 });
        }
    }
}
