using System;
namespace SAF.Hub.Model
{
	/// <summary>
	/// SAF_UserPermission:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SAF_UserPermission
	{
		public SAF_UserPermission()
		{}
		#region Model
		private Guid _userid;
		private Guid _permissionid;
		private DateTime _indate;
		private string _inuser;
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
		public Guid PermissionId
		{
			set{ _permissionid=value;}
			get{return _permissionid;}
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

