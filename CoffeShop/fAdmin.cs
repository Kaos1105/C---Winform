using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeShop.Data_Access_Object;

namespace CoffeShop
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
            //LoadAccountList();
            //LoadFoodList();
        }

        //void LoadFoodList()
        //{
        //    string query = "select * from Food";

        //    dGVAccount.DataSource = DataProvider.Instance.ExecuteQuery(query);
        //}

        //void LoadAccountList()
        //{
        //    string query = "EXEC dbo.USP_GetAccountByUserName @userName";
            
        //    dGVAccount.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] {"KaosLord"});
        //}
    }
}
