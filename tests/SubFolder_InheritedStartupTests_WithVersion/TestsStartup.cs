using Microsoft.AspNetCore.Hosting;

namespace SubFolder_InheritedStartupTests_WithVersion
{
    public class TestsStartup : DemoApi.Startup
    {
        public TestsStartup(IHostingEnvironment env) : base(env)
        {
        }
    }
}
