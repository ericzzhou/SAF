using System;
namespace SAF.Hub.Model
{
	/// <summary>
	/// SAF_Permission:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SAF_Permission
	{
		public SAF_Permission()
		{}
		#region Model
		private Guid _id;
		private string _name;
		private string _code;
		private Guid? _parentid;
		private int _status=0;
		private int _sequence=0;
		private DateTime _indate= DateTime.Now;
		private string _inuser;
		private DateTime? _lastdate;
		private string _lastuser;
		/// <summary>
		/// 
		/// </summary>
		public Guid ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Code
		{
			set{ _code=value;}
			get{return _code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Guid? ParentId
		{
			set{ _parentid=value;}
			get{return _parentid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Status
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Sequence
		{
			set{ _sequence=value;}
			get{return _sequence;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime InDate
		{
			set{ _indate=value;}
			get{return _indate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string InUser
		{
			set{ _inuser=value;}
			get{return _inuser;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? LastDate
		{
			set{ _lastdate=value;}
			get{return _lastdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LastUser
		{
			set{ _lastuser=value;}
			get{return _lastuser;}
		}
		#endregion Model

	}
}

