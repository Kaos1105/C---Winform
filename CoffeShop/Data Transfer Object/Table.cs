using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop.Data_Transfer_Object
{
    public class Table
    {
        public Table (int id, string name, string status)
        {
            this.ID = id;
            this.Name = name;
            this.Status = status;
        }
        public static int tableWidth = 90;
        public static int tableHeight = 90;
        private int iD;
        public int ID { get => iD; set => iD = value; }

        private string name;
        public string Name { get => name; set => name = value; }

        private string status;
        public string Status { get => status; set => status = value; }
        public Table(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Status = row["status"].ToString();
        }
    }
}
