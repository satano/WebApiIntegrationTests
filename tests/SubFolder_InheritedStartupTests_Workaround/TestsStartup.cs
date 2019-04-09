using Microsoft.AspNetCore.Hosting;

namespace SubFolder_InheritedStartupTests_Workaround
{
    public class TestsStartup : DemoApi_Workaround.Startup
    {
        public TestsStartup(IHostingEnvironment env) : base(env)
        {
        }
    }
}
