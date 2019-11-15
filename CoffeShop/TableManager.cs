using CoffeShop.Data_Access_Object;
using CoffeShop.Data_Transfer_Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu = CoffeShop.Data_Transfer_Object.Menu;

namespace CoffeShop
{
    public partial class fTableManager : Form
    {
        public fTableManager()
        {
            InitializeComponent();
            LoadTables();
            LoadCategory();
            LoadComboboxTable(cBSwitch);
        }

        #region Methods
        void LoadTables()
        {
            flPTable.Controls.Clear();
            List<Table> tableList= TableDAO.Instance.LoadTableList();
            foreach(Table item in tableList)
            {
                Button btn = new Button() { Width = Table.tableWidth, Height = Table.tableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += Btn_Click;
                btn.Tag = item;
                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }
                flPTable.Controls.Add(btn);
            }
        }
        //void LoadTable(FlowLayoutPanel fLP, Table table)
        //{
        //    TableDAO.Instance.LoadTableList();
        //    foreach (Control control in fLP.Controls)
        //    {
        //        if (control.Tag.Equals(table))
        //        {
        //            Button btn = (Button)control;
        //            btn.Text = table.Name + Environment.NewLine + table.Status;
        //            switch (table.Status)
        //            {
        //                case "Trống":
        //                    btn.BackColor = Color.Aqua;
        //                    break;
        //                default:
        //                    btn.BackColor = Color.LightPink;
        //                    break;
        //            }
        //        }
        //    }
        //}
        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cBCategory.DataSource = listCategory;
            cBCategory.DisplayMember = "Name";
        }
        void LoadFoodListByCategoryID(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetListFoodByCategoryID(id);
            cBFood.DataSource = listFood;
            cBFood.DisplayMember = "Name";
        }
        
        void LoadComboboxTable(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.LoadTableList();
            cb.DisplayMember = "Name";
        }

        void ShowBill(int id)
        {
            lvBill.Items.Clear();
            List<Menu> listBillInfo = MenuDAO.Instance.GetListMenuByBillID(BillDAO.Instance.GetUncheckedBillIDByTableID(id));
            float totalPrice = 0;
            foreach (Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                lvBill.Items.Add(lsvItem);
            }
            //listBillInfo.Add(new BillInfo(8, 2, 0, 1));
            CultureInfo culture = new CultureInfo("vi-VN");
            //Thread/CurrentThread.CurrentCulture = culture;
            txtBTotalPrice.Text = totalPrice.ToString("c", culture);
        }

        #endregion
        #region Events
        private void Btn_Click(object sender, EventArgs e)
        {
            //(sender as Button).BackColor = Color.Brown;
            int tableID = ((sender as Button).Tag as Table).ID;
            lvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }
        private void ĐăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThôngTinCáNhânToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile();
            f.ShowDialog();
        }

        private void AdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();
        }
        private void CBCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            Category selected = cb.SelectedItem as Category;
            id = selected.ID;
            LoadFoodListByCategoryID(id);
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Table table = lvBill.Tag as Table;
            int idBill = BillDAO.Instance.GetUncheckedBillIDByTableID(table.ID);
            int idFood = (cBFood.SelectedItem as Food).ID;
            int count = (int)nUDFoodCount.Value;
            if(idBill==-1)
            {
                BillDAO.Instance.InsertBill(table.ID);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetLastestIDBill(), idFood, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, idFood, count);
            }
            ShowBill(table.ID);
            //LoadTable(flPTable, table);
            LoadTables();
        }
        private void BtnCheckOut_Click(object sender, EventArgs e)
        {
            Table table = lvBill.Tag as Table;
            int idBill = BillDAO.Instance.GetUncheckedBillIDByTableID(table.ID);
            int disCount = (int)nUDSale.Value;
            double totalPrice = 1000 * Convert.ToDouble(txtBTotalPrice.Text.Split(',')[0]);
            if (idBill!=-1)
            {
                if (MessageBox.Show(string.Format("Bạn có muốn thanh toán hóa đơn cho bàn{0}\n Tổng tiền sau khi đã giảm giá {1}% là : {2} ", table.Name, disCount, totalPrice) , "Thông báo", MessageBoxButtons.OKCancel)==DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill, disCount);
                    ShowBill(table.ID);
                }

            }
            //LoadTable(flPTable, table);
            LoadTables();
        }
        private void BtnSale_Click(object sender, EventArgs e)
        {
            int disCount = (int)nUDSale.Value;
            double totalPrice = 1000 * Convert.ToDouble(txtBTotalPrice.Text.Split(',')[0]);
            double finalTotalPrice = totalPrice - (totalPrice / 100) * disCount;
            CultureInfo culture = new CultureInfo("vi-VN");
            txtBTotalPrice.Text = finalTotalPrice.ToString("c", culture);
        }
        private void BtnSwitch_Click(object sender, EventArgs e)
        {
            int id1 = (lvBill.Tag as Table).ID;
            int id2 = (cBSwitch.SelectedItem as Table).ID;
            if (MessageBox.Show(string.Format("Bạn có muốn chuyển bàn {0} qua bàn {1} ", id1-1, id2-1), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK) ;
            TableDAO.Instance.Switchtable(id1, id2);
            LoadTables();
        }

        #endregion


    }
}
