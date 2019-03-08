using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Net.Http;
using Xunit;

namespace InheritedWebApplicationFactoryTests
{
    public abstract class TestsBase : IClassFixture<TestsWebApplicationFactory>
    {
        private readonly TestsWebApplicationFactory _factory;

        public TestsBase(TestsWebApplicationFactory factory)
        {
            _factory = factory;
            Client = _factory.CreateClient();
        }

        protected HttpClient Client { get; }
        protected TestServer Server => _factory.Server;
        protected IWebHost Host => Server.Host;
        protected IServiceProvider ServiceProvider => Host.Services;
    }
}
