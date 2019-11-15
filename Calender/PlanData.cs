using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calender
{
    [Serializable]
    public class PlanData
    {
        public List<PlanItem> plans { get; set; }
        public static int notifyTime=10000;
    }
}
