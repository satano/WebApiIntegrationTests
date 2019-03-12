using Microsoft.AspNetCore.Hosting;

namespace InheritedStartupTests_WithVersion
{
    public class TestsStartup : DemoApi.Startup
    {
        public TestsStartup(IHostingEnvironment env) : base(env)
        {
        }
    }
}
