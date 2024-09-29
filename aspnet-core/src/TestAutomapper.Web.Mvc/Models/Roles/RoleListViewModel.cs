using System.Collections.Generic;
using TestAutomapper.Roles.Dto;

namespace TestAutomapper.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
