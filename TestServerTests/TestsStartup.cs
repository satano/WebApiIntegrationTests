using DemoApi;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace TestServerTests
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
