using SAF.Core.Apis;
using SAF.MM.Model.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SAF.MM.Api
{
    /// <summary>
    /// 系统用户管理
    /// </summary>
    [TokenAuthorize]
    [RoutePrefix("api/mm/admin")]
    public class AdminController : ApiController
    {
        /// <summary>
        /// 系统用户登录
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        
        [Route("login"), HttpPost]
        public HttpResponseMessage Login(LoginModel model)
        {
            var result = new LoginResultModel()
            {
                Token = "123123123123123123123"
            };
            //throw new Exception("哈哈哈");
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, result);
            return response;
        }

    }
}