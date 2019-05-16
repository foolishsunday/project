using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Xml;
using System.IO.Ports;
using System.Threading;

namespace learn_com
{
    public class DataMessage
    {
        private List<DataModule> _DataModules = new List<DataModule>();
        public List<DataModule> DataModules
        {
            set { _DataModules = value; }
            get { return _DataModules; }
        }
        public void LoadData(string filePath)
        {
            this._DataModules = (List<DataModule>)Function.XmlDeserializeFromFile(typeof(List<DataModule>),filePath);

        }
        public string GetValue(string name)
        {
            foreach (var item in _DataModules)
            {
                if (item.Name == name) return item.Value;
            }
            return "No Found";
        }
        public void AddDataToXml(string filePath, DataModule module)
        {
            this._DataModules.Add(module);
            Function.XmlSerializeToFile(typeof(List<DataModule>), this._DataModules, filePath);
        }
        public bool RemoveNode(string filePath, DataModule module)
        {
            bool isRemoveSucceed=false;
            //isRemoveSucceed = this._DataModules.Remove(module);
            for (int i = 0; i < _DataModules.Count;i++ )
            {
                if (_DataModules[i].Name == module.Name && _DataModules[i].Value == module.Value)
                {
                    _DataModules.RemoveAt(i);
                    isRemoveSucceed = true;
                }
            }
            Function.XmlSerializeToFile(typeof(List<DataModule>), this._DataModules, filePath);
            return isRemoveSucceed;
        }
    }
}
