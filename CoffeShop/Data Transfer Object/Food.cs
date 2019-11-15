using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop.Data_Transfer_Object
{
    public class Food
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int IDCategory { get; set; }
        public float Price { get; set; }
        public Food(int id, int iDCategory, float price, string name)
        {
            ID = id;
            IDCategory = iDCategory;
            Price = price;
            Name = name;
        }
        public Food(DataRow row)
        {
            ID = (int)row["id"];
            IDCategory = (int)row["idcategory"];
            Price = (float)Convert.ToDouble(row["price"]);
            Name = row["name"].ToString();
        }
    }
}
