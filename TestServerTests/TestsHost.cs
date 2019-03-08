using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Net.Http;

namespace TestServerTests
{
    public class TestsHost
    {
        public TestsHost()
        {
            var builder = new WebHostBuilder().UseStartup<TestsStartup>();
            Server = new TestServer(builder);
            Client = Server.CreateClient();
        }

        public TestServer Server { get; }
        public HttpClient Client { get; }
        public IServiceProvider ServiceProvider => Server.Host.Services;
    }
}
