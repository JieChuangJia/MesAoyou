using System;
namespace AYDataAccess
{
	/// <summary>
    /// propertyModel:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class propertyModel
	{
        public propertyModel()
		{}
		#region Model
		private string _propertyid;
		private string _propertyname;
		private string _propertycata;
		private string _tag1;
		private string _tag2;
		private string _tag3;
		private string _tag4;
		private string _tag5;
		/// <summary>
		/// 
		/// </summary>
		public string propertyID
		{
			set{ _propertyid=value;}
			get{return _propertyid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string propertyName
		{
			set{ _propertyname=value;}
			get{return _propertyname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string propertyCata
		{
			set{ _propertycata=value;}
			get{return _propertycata;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tag1
		{
			set{ _tag1=value;}
			get{return _tag1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tag2
		{
			set{ _tag2=value;}
			get{return _tag2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tag3
		{
			set{ _tag3=value;}
			get{return _tag3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tag4
		{
			set{ _tag4=value;}
			get{return _tag4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tag5
		{
			set{ _tag5=value;}
			get{return _tag5;}
		}
		#endregion Model

	}
}

