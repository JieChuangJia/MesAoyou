using System;
namespace AYDataAccess
{
	/// <summary>
    /// palletTraceModel:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class palletTraceModel
	{
        public palletTraceModel()
		{}
		#region Model
		private string _pallettraceid;
		private string _palletid;
		private string _eventcata;
		private string _eventdesc;
		private DateTime _eventtime;
		private string _tag1;
		private string _tag2;
		private string _tag3;
		private string _tag4;
		private string _tag5;
		/// <summary>
		/// 
		/// </summary>
		public string palletTraceID
		{
			set{ _pallettraceid=value;}
			get{return _pallettraceid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string palletID
		{
			set{ _palletid=value;}
			get{return _palletid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string eventCata
		{
			set{ _eventcata=value;}
			get{return _eventcata;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string eventDesc
		{
			set{ _eventdesc=value;}
			get{return _eventdesc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime eventTime
		{
			set{ _eventtime=value;}
			get{return _eventtime;}
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

