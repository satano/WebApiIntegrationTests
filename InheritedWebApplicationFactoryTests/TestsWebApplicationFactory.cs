using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;

namespace InheritedWebApplicationFactoryTests
{
    public class TestsWebApplicationFactory : WebApplicationFactory<TestsStartup>
    {
        protected override IWebHostBuilder CreateWebHostBuilder()
        {
            return WebHost.CreateDefaultBuilder()
                .UseContentRoot("D:\\Kros\\projekty\\TEST\\WebApiTests\\InheritedWebApplicationFactoryTests\\bin\\Debug\\netcoreapp2.2")
                .UseStartup<TestsStartup>();
        }

        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            string currentDir = System.Environment.CurrentDirectory;
            string startupDir = typeof(TestsStartup).Assembly.Location;
            //builder.UseContentRoot(".");
            base.ConfigureWebHost(builder);
        }
    }
}
