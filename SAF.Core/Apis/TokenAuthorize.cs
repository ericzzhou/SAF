using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace SAF.Core.Apis
{
    public class TokenAuthorizeAttribute: AuthorizeAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            bool isAuth = false;
            if (actionContext.Request.Headers.Any(x => x.Key == "token"))
            {
                var token = actionContext.Request.Headers.Where(x => x.Key == "token").FirstOrDefault().Value.FirstOrDefault();
                if (!string.IsNullOrWhiteSpace(token))
                {
                    //验证 token 有效期
                    isAuth = true;
                }
            }

            if (!isAuth)
            {
                base.HandleUnauthorizedRequest(actionContext);
            }

            base.OnAuthorization(actionContext);
        }

        protected override void HandleUnauthorizedRequest(HttpActionContext actionContext)
        {
            //base.HandleUnauthorizedRequest(actionContext);
        }
    }
}
