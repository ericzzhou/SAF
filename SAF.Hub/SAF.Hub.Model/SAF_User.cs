using System;
namespace SAF.Hub.Model
{
	/// <summary>
	/// SAF_User:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SAF_User
	{
		public SAF_User()
		{}
		#region Model
		private Guid _id;
		private string _username;
		private string _password;
		private int _status=0;
		private DateTime _indate= DateTime.Now;
		private string _inuser;
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
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Password
		{
			set{ _password=value;}
			get{return _password;}
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
		#endregion Model

	}
}

