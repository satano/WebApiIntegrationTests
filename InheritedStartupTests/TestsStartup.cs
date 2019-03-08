using Microsoft.AspNetCore.Hosting;

namespace InheritedStartupTests
{
    public class TestsStartup : DemoApi.Startup
    {
        public TestsStartup(IHostingEnvironment env) : base(env)
        {
        }
    }
}
