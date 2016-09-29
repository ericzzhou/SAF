using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web.Http;

namespace SAF.CMS.Api
{
    /// <summary>
    /// 标签管理
    /// </summary>
    [RoutePrefix("api/cms/tag")]
    public class TagController : ApiController
    {
        /// <summary>
        /// 添加标签
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("add")]
        public HttpResponseMessage Add() {
            var tag = new
            {
                TagGroup = "GA",
                TagId = 1,
                TagName = "TagA"
            };
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, tag);
            return response;
        }
    }
}
