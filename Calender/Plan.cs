using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calender
{
    public partial class Plan : UserControl
    {
        public PlanItem Item { get; set; }
        public Plan(PlanItem item)
        {
            InitializeComponent();
            this.Item = item;
            comboBox1.DataSource = PlanItem.listStatus;
            ShowInfo();
        }
        void ShowInfo()
        {
            textBox1.Text = Item.job;
            numericUpDownFrHour.Value = Item.fromTime.X;
            numericUpDownFrMin.Value = Item.fromTime.Y;
            numericUpDownHour.Value = Item.toTime.X;
            numericUpDownMin.Value = Item.toTime.Y;
            comboBox1.SelectedIndex = PlanItem.listStatus.IndexOf(Item.status);
            checkBoxDone.Checked = PlanItem.listStatus.IndexOf(Item.status) == 0 ? true : false;
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            deleted?.Invoke(this, e);
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Item.job = textBox1.Text;
            Item.fromTime = new Point((int)numericUpDownFrHour.Value, (int)numericUpDownFrMin.Value);
            Item.toTime = new Point((int)numericUpDownHour.Value, (int)numericUpDownMin.Value);
            Item.status = comboBox1.SelectedItem.ToString();
            edited?.Invoke(this, e);
        }
        event EventHandler edited;
        public event EventHandler Edit
        {
            add { edited += value; }
            remove { edited -= value; }
        }
        event EventHandler deleted;
        public event EventHandler Delete
        {
            add { deleted += value; }
            remove { deleted -= value; }
        }
        private void checkBoxDone_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = checkBoxDone.Checked ? 0 : 1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != 0)
                checkBoxDone.Checked = false;
            else checkBoxDone.Checked = true;
        }
    }
}
