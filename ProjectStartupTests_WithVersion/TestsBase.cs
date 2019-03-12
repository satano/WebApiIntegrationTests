using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Net.Http;
using Xunit;

namespace ProjectStartupTests_WithVersion
{
    public abstract class TestsBase : IClassFixture<WebApplicationFactory<DemoApi.Startup>>
    {
        private readonly WebApplicationFactory<DemoApi.Startup> _factory;

        public TestsBase(WebApplicationFactory<DemoApi.Startup> factory)
        {
            _factory = factory;
            string currentDir = System.Environment.CurrentDirectory;
            Client = _factory.CreateClient();
        }

        protected HttpClient Client { get; }
        protected TestServer Server => _factory.Server;
        protected IWebHost Host => Server.Host;
        protected IServiceProvider ServiceProvider => Host.Services;
    }
}
