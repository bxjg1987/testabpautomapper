using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using TestAutomapper.Controllers;

namespace TestAutomapper.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : TestAutomapperControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
