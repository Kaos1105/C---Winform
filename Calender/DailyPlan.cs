using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calender
{
    public partial class DailyPlan : Form
    {
        public DateTime date { get; set; }
        public PlanData data { get; set; }
        public DailyPlan(DateTime Date, PlanData planData)
        {
            InitializeComponent();
            this.date = Date;
            this.data = planData;
            dateTimePicker.Value = date;
        }
        void ShowPlanByDate(DateTime date)
        {
            fPanel.Controls.Clear();
            if (data != null && data.plans != null)
            {
                List<PlanItem> todayPlan = GetPlanByDay(date);
                for (int i = 0; i < todayPlan.Count; ++i)
                {
                    AddPlanItem(todayPlan[i]);
                }
            }

        }
        void AddPlanItem(PlanItem item)
        {
            Plan plan = new Plan(item);
            plan.Edit += Plan_Edit;
            plan.Delete += Plan_Delete;
            fPanel.Controls.Add(plan);
        }
        private void Plan_Delete(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            Plan plan = sender as Plan;
            PlanItem item = plan.Item;
            fPanel.Controls.Remove(plan);
            data.plans.Remove(item);
        }

        private void Plan_Edit(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        List<PlanItem> GetPlanByDay(DateTime time)
        {
            return data.plans.Where(p => p.planDate.Year == time.Year && p.planDate.Month == time.Month && p.planDate.Day == time.Day).ToList();
        }
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            ShowPlanByDate((sender as DateTimePicker).Value);
        }

        private void btnFwr_Click(object sender, EventArgs e)
        {
            dateTimePicker.Value = dateTimePicker.Value.AddDays(1);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            dateTimePicker.Value = dateTimePicker.Value.AddDays(-1);
        }

        private void mnstripItemToday_Click(object sender, EventArgs e)
        {
            dateTimePicker.Value = DateTime.Now;
        }

        private void mnstripItemPlan_Click(object sender, EventArgs e)
        {
            PlanItem item = new PlanItem() { planDate= dateTimePicker.Value};
            data.plans.Add(item);
            AddPlanItem(item);
        }
    }
}
