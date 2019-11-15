using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Calender
{
    public partial class Calender : Form
    {
        public List<List<Button>> Matrix { get; set; }
        private string filePath = "data.xml";
        public PlanData schedules { get; set; }
        private List<string> DayofWeek = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        public Calender()
        {
            InitializeComponent();
            RegistryKey regkey = Registry.CurrentUser.CreateSubKey("Software\\Calendar");
            RegistryKey regstart = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
            string keyvalue = "1";
            try
            {
                regkey.SetValue("Index", keyvalue);
                regstart.SetValue("Calendar", Application.StartupPath + "\\Calendar.exe");
                //regkey.Close();
            }
            catch (System.Exception ex)
            {
            }

            LoadMatrix();
            try
            {
                schedules = DeserializeFromXML(filePath) as PlanData;
            }
            catch (Exception ex)
            {
                SetDefaultValue();
            }
        }
        void SetDefaultValue()
        {
            schedules = new PlanData();
            schedules.plans = new List<PlanItem>();
            schedules.plans.Add(new PlanItem()
            {
                planDate = DateTime.Now,
                fromTime = new Point(0, 0),
                toTime = new Point(0, 0),
                job = "",
                status = PlanItem.listStatus[1]
            });
        }
        void LoadMatrix()
        {
            Matrix = new List<List<Button>>();
            Button pivot = new Button() { Width = 0, Height = 0, Location = new Point(-3, 0) };
            for (int i = 0; i < 6; ++i)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < 7; ++j)
                {
                    Button btn = new Button() { Width = button1.Width, Height = button1.Height };
                    btn.MouseClick += Btn_Click;
                    btn.Location = new Point(pivot.Location.X + pivot.Width + 3, pivot.Location.Y);
                    panel4.Controls.Add(btn);
                    btn.Tag = "null";
                    pivot = btn;
                    Matrix[i].Add(btn);
                }
                pivot = new Button() { Width = 0, Height = 0, Location = new Point(-3, pivot.Location.Y + button1.Height + 4) };
            }
            //AddNumberToMatrixByDate(dateTimePicker.Value);
            SetDefaultDate();
        }

        private void Btn_Click(object sender, MouseEventArgs e)
        {
            //throw new NotImplementedException();
            Button btn = sender as Button;
            DateTime dt = new DateTime(dateTimePicker.Value.Year, dateTimePicker.Value.Month, Convert.ToInt32(btn.Text));
            switch (btn.Tag.ToString())
            {
                case "frd":
                    DateTime temp = dateTimePicker.Value.AddMonths(1);
                    dt = new DateTime(temp.Year, temp.Month, Convert.ToInt32(btn.Text));
                    break;
                case "prev":
                    temp = dateTimePicker.Value.AddMonths(-1);
                    dt = new DateTime(temp.Year, temp.Month, Convert.ToInt32(btn.Text));
                    break;
                default:
                    temp = dateTimePicker.Value.AddMonths(0);
                    dt = new DateTime(temp.Year, temp.Month, Convert.ToInt32(btn.Text));
                    break;
            }
            dateTimePicker.Value = dt;
            //DailyPlan dailyPlan = new DailyPlan(dateTimePicker.Value, schedules);
            //dailyPlan.ShowDialog();
        }

        private void BtnPLan_Click(object sender, EventArgs e)
        {
            DailyPlan dailyPlan = new DailyPlan(dateTimePicker.Value, schedules);
            dailyPlan.ShowDialog();
        }

        int DayofMonth(DateTime date)
        {
            switch (date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if ((date.Year % 4 == 0 && date.Year % 100 != 0) || date.Year % 400 == 0)
                        return 29;
                    else return 28;
                default:
                    return 30;
            }
        }
        void AddNumberToMatrixByDate(DateTime time)
        {
            DateTime pivot = new DateTime(time.Year, time.Month, 1);
            int line = 0;
            Button btn = new Button();
            for (int i = 1; i <= DayofMonth(time); ++i)
            {
                int column = DayofWeek.IndexOf(pivot.DayOfWeek.ToString());
                btn = Matrix[line][column];
                btn.Text = i.ToString();
                btn.Tag = "curr";
                if (pivot == DateTime.Today)
                {
                    btn.BackColor = Color.Yellow;
                }
                if (pivot.Date == time.Date)
                {
                    btn.BackColor = Color.Aqua;
                    btn.Select();
                }
                if (column >= 6)
                    line++;
                pivot = pivot.AddDays(1);
            }
            for (int i = 1; ; pivot = pivot.AddDays(1))
            {
                int column = DayofWeek.IndexOf(pivot.DayOfWeek.ToString());
                if (line > 5)
                    break;
                btn = Matrix[line][column];
                btn.Text = i.ToString();
                btn.Tag = "frd";
                btn.BackColor = Color.Khaki;
                if (pivot == DateTime.Today)
                {
                    btn.BackColor = Color.Yellow;
                }
                if (pivot.Date == time.Date)
                {
                    btn.BackColor = Color.Aqua;
                    btn.Select();
                }
                ++i;
                if (column >= 6)
                    line++;
            }
            pivot = new DateTime(time.Year, time.Month, 1);
            pivot = pivot.AddDays(-1);
            for (int i = DayofMonth(pivot); ; pivot = pivot.AddDays(-1))
            {
                int column = DayofWeek.IndexOf(pivot.DayOfWeek.ToString());
                btn = Matrix[0][column];
                if (btn.Tag.ToString() != "null")
                    break;
                btn.Text = i.ToString();
                btn.Tag = "prev";
                btn.BackColor = Color.Khaki;
                if (pivot == DateTime.Today)
                {
                    btn.BackColor = Color.Yellow;
                }
                if (pivot.Date == time.Date)
                {
                    btn.BackColor = Color.Aqua;
                    btn.Select();
                }
                --i;
            }
        }
        void SetDefaultDate()
        {
            dateTimePicker.Value = DateTime.Now;
        }
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            ClearMatrix();
            AddNumberToMatrixByDate(((DateTimePicker)sender).Value);
        }
        void ClearMatrix()
        {
            for (int i = 0; i < Matrix.Count; ++i)
            {
                for (int j = 0; j < Matrix[i].Count; ++j)
                {
                    Button btn = Matrix[i][j];
                    btn.Text = "";
                    btn.Tag = "null";
                    btn.BackColor = Color.Cornsilk;
                }
            }
        }

        private void btnFwr_Click(object sender, EventArgs e)
        {
            dateTimePicker.Value = dateTimePicker.Value.AddMonths(1);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            dateTimePicker.Value = dateTimePicker.Value.AddMonths(-1);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            SetDefaultDate();
        }
        private void SerializeToXML(object data, string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer sr = new XmlSerializer(typeof(PlanData));
            sr.Serialize(fs, data);
            fs.Close();
        }
        private object DeserializeFromXML(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            XmlSerializer sr = new XmlSerializer(typeof(PlanData));
            object result = sr.Deserialize(fs);
            fs.Close();
            return result;
        }

        private void Calender_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerializeToXML(schedules, filePath);
        }

        private void timerNotify_Tick(object sender, EventArgs e)
        {
            if (schedules == null || schedules.plans == null || checkBoxNotify.Checked==false)
                return;
            DateTime curr = DateTime.Now;
            List<PlanItem> todayPlans = schedules.plans.Where(p => p.planDate.Year == curr.Year && p.planDate.Month == curr.Month && p.planDate.Day == curr.Day).ToList();
            Notify.ShowBalloonTip(PlanData.notifyTime, "Thông báo lịch", "Bạn có "+ todayPlans.Count +" việc trong ngày hôm nay", ToolTipIcon.Info);
        }

        private void numericUpDownNoti_ValueChanged(object sender, EventArgs e)
        {
            PlanData.notifyTime = (int)numericUpDownNoti.Value;
        }

        private void checkBoxNotify_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownNoti.Enabled = checkBoxNotify.Checked;
        }
    }
}
