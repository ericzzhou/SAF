using System;
namespace SAF.Hub.Model
{
	/// <summary>
	/// SAF_Token:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SAF_Token
	{
		public SAF_Token()
		{}
		#region Model
		private Guid _id;
		private Guid _userid;
		private string _token;
		private string _platform;
		private DateTime? _expirationtime;
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
		public Guid UserId
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Token
		{
			set{ _token=value;}
			get{return _token;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Platform
		{
			set{ _platform=value;}
			get{return _platform;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? ExpirationTime
		{
			set{ _expirationtime=value;}
			get{return _expirationtime;}
		}
		#endregion Model

	}
}

