using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AYDataAccess
{
    /// <summary>
    /// View_batteryPropertyModel:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class View_batteryPropertyModel
    {
        public View_batteryPropertyModel()
        { }
        #region Model
        private string _batteryid;
        private string _propertyname;
        private string _propertycata;
        private string _batterypropertyvalueid;
        private string _propertyid;
        private string _propertyvalue;
        /// <summary>
        /// 
        /// </summary>
        public string batteryID
        {
            set { _batteryid = value; }
            get { return _batteryid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string propertyName
        {
            set { _propertyname = value; }
            get { return _propertyname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string propertyCata
        {
            set { _propertycata = value; }
            get { return _propertycata; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string batteryPropertyValueID
        {
            set { _batterypropertyvalueid = value; }
            get { return _batterypropertyvalueid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string propertyID
        {
            set { _propertyid = value; }
            get { return _propertyid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string propertyValue
        {
            set { _propertyvalue = value; }
            get { return _propertyvalue; }
        }
        #endregion Model

    }
}
