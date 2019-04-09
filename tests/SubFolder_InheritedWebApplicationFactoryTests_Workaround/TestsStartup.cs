using DemoApi_Workaround;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace SubFolder_InheritedWebApplicationFactoryTests_Workaround
{
    public class TestsStartup : Startup
    {
        public TestsStartup(IHostingEnvironment env) : base(env)
        {
        }

        protected override IConfigurationBuilder CreateConfigurationBuilder(IHostingEnvironment env)
            => base.CreateConfigurationBuilder(env);
    }
}
