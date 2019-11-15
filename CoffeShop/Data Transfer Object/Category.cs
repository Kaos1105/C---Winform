using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop.Data_Access_Object
{
    public class Category
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public Category(int id, string name)
        {
            ID = id;
            Name = name;
        }
        public Category(DataRow row)
        {
            ID = (int)row["id"];
            Name = row["name"].ToString();
        }
    }
}
