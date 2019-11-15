using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    [Serializable]
    public class DictionaryItem
    {
        public List<DictionaryData> Items
        {
            get;
            set;
        }
    }
}
