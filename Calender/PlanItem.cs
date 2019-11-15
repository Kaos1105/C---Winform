using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calender
{
    public class PlanItem
    {
        public DateTime planDate { get; set; }
        public string job { get; set; }
        public Point toTime { get; set; }
        public Point fromTime { get; set; }
        public string status { get; set; }
        public static List<string> listStatus = new List<string>() { "DONE", "DOING", "MISSED", "PASS" };
    }
}
