using Abp.AutoMapper;
using Abp.Localization;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AutoMapper;
using TestAutomapper.Authorization;
using TestAutomapper.Authorization.Users;
using TestAutomapper.Users.Dto;

namespace TestAutomapper
{
    [DependsOn(
        typeof(TestAutomapperCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class TestAutomapperApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<TestAutomapperAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(TestAutomapperApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }

    public class AppProfile : Profile {
        public AppProfile() {
            CreateMap<User, UserDto>().ForMember(x=>x.TestMapper,x=>x.ConvertUsing<TestValueConvert,long>(x=>x.Id));
        }
    }

    public class TestValueConvert : IValueConverter<long, string>
    {
        private readonly ILocalizationManager localizationManager;

        public TestValueConvert(ILocalizationManager localizationManager)
        {
            this.localizationManager = localizationManager;
        }

        public string Convert(long sourceMember, ResolutionContext context)
        {
            return sourceMember.ToString();
        }
    }
}
