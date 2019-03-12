using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;

namespace InheritedWebApplicationFactoryTests_WithVersion
{
    public class TestsWebApplicationFactory : WebApplicationFactory<TestsStartup>
    {
        protected override IWebHostBuilder CreateWebHostBuilder()
        {
            return WebHost.CreateDefaultBuilder()
                .UseContentRoot(".")
                .UseStartup<TestsStartup>();
        }

        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            string currentDir = System.Environment.CurrentDirectory;
            string startupDir = typeof(TestsStartup).Assembly.Location;
            base.ConfigureWebHost(builder);
        }
    }
}
