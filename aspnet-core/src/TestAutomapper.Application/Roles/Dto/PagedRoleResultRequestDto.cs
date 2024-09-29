using Abp.Application.Services.Dto;

namespace TestAutomapper.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

