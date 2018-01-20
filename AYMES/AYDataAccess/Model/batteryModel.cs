using System;
namespace AYDataAccess
{
	/// <summary>
    /// batteryModel:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class batteryModel
	{
        public batteryModel()
		{}
		#region Model
		private string _batteryid;
		private string _productcata;
		private string _batchname;
		private string _palletid;
		private DateTime? _onlinetime;
		private int _channel;
		private bool _palletbinded;
		private string _tag1;
		private string _tag2;
		private string _tag3;
		private string _tag4;
		private string _tag5;
		/// <summary>
		/// 
		/// </summary>
		public string batteryID
		{
			set{ _batteryid=value;}
			get{return _batteryid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string productCata
		{
			set{ _productcata=value;}
			get{return _productcata;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string batchName
		{
			set{ _batchname=value;}
			get{return _batchname;}
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
		public DateTime? onlineTime
		{
			set{ _onlinetime=value;}
			get{return _onlinetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int channel
		{
			set{ _channel=value;}
			get{return _channel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool palletBinded
		{
			set{ _palletbinded=value;}
			get{return _palletbinded;}
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

