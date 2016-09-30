using System;
namespace SAF.Hub.Model
{
    /// <summary>
    /// SAF_Menu:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class SAF_Menu
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public Guid? ParentId { get; set; }
        public string Icon { get; set; }
        public string Url { get; set; }
        public int Sequence { get; set; }
        public int MenuType { get; set; }
        public int Status { get; set; }
        public Guid? Permission { get; set; }
        public DateTime InDate { get; set; }
        public string InUser { get; set; }
        public DateTime? LastDate { get; set; }
        public string LastUser { get; set; }

    }
}

