using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using TestAutomapper.Controllers;

namespace TestAutomapper.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : TestAutomapperControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
