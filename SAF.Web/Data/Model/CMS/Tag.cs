using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SAF.Web.Data.Model.CMS
{
    /// <summary>
    /// 标签
    /// </summary>
    public class Tag
    {
        /// <summary>
        /// 标签编号
        /// </summary>
        public int TagId { get; set; }

        /// <summary>
        /// 标签名
        /// </summary>
        public string TagName { get; set; }

        /// <summary>
        /// 标签组
        /// </summary>
        public string TagGroup { get; set; }
    }
}