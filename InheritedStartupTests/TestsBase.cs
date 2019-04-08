using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Net.Http;
using Xunit;

namespace InheritedStartupTests
{
    public abstract class TestsBase : IClassFixture<WebApplicationFactory<TestsStartup>>
    {
        protected readonly WebApplicationFactory<TestsStartup> _factory;

        public TestsBase(WebApplicationFactory<TestsStartup> factory)
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
