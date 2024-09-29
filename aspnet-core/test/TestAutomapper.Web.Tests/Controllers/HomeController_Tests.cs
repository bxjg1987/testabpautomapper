using System.Threading.Tasks;
using TestAutomapper.Models.TokenAuth;
using TestAutomapper.Web.Controllers;
using Shouldly;
using Xunit;

namespace TestAutomapper.Web.Tests.Controllers
{
    public class HomeController_Tests: TestAutomapperWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}