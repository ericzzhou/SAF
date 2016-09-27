using SAF.Web.Data.Model;
using System.Web.Http;

namespace SAF.Web.Apis
{
    [RoutePrefix("api/hub")]
    public class HubController : ApiController
    {
        [Route("get/{id}/{age}")]
        public string Get(int id, int age)
        {
            return "hub value " + id + " - " + age;
        }

        public Eric Get()
        {
            return new Eric()
            {
                FirstName = "Eric",
                LastName = "Zhou",
                Age = 28
            };
        }
    }
}
