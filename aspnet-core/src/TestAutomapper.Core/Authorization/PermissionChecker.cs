using Abp.Authorization;
using TestAutomapper.Authorization.Roles;
using TestAutomapper.Authorization.Users;

namespace TestAutomapper.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
