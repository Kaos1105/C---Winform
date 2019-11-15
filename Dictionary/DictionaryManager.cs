using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Dictionary
{
    class DictionaryManager
    {
        #region properties
        private string filePath = @"D:\Study\C#\K-Solution\Dictionary\data.xml";
        public DictionaryItem items
        {
            get;
            set;
        }
        #endregion
        #region method
        public DictionaryManager()
        {
            items = (DictionaryItem)DeserializeFromXML(filePath);
        }
        public void LoadDataToComboBox(ComboBox combo)
        {
            combo.DataSource = items.Items;
        }
        public void Serialize()
        {
            SerializeToXML(items, filePath);
        }
        private void SerializeToXML(object data, string filePath)
        {

            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xml = new XmlSerializer(typeof(DictionaryItem));
            xml.Serialize(fs, data);
            fs.Close();

        }
        public object DeserializeFromXML(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xml = new XmlSerializer(typeof(DictionaryItem));
            object obj= xml.Deserialize(fs);
            fs.Close();
            return obj;
        }
        #endregion
    }
}
