using Microsoft.AspNetCore.Hosting;

namespace InheritedStartupTests_Workaround
{
    public class TestsStartup : DemoApi_Workaround.Startup
    {
        public TestsStartup(IHostingEnvironment env) : base(env)
        {
        }
    }
}
