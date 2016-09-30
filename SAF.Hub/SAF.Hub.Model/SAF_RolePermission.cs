using System;
namespace SAF.Hub.Model
{
	/// <summary>
	/// SAF_RolePermission:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SAF_RolePermission
	{
		public SAF_RolePermission()
		{}
		#region Model
		private Guid _roleid;
		private Guid _permissionid;
		private DateTime _indate= DateTime.Now;
		private string _inuser;
		/// <summary>
		/// 
		/// </summary>
		public Guid RoleId
		{
			set{ _roleid=value;}
			get{return _roleid;}
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

