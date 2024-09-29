using System.Collections.Generic;
using TestAutomapper.Roles.Dto;

namespace TestAutomapper.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}