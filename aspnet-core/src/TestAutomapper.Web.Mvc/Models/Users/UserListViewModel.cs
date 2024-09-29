using System.Collections.Generic;
using TestAutomapper.Roles.Dto;

namespace TestAutomapper.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
