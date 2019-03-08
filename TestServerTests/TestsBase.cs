using Microsoft.AspNetCore.TestHost;
using System;
using System.Net.Http;
using Xunit;

namespace TestServerTests
{
    public abstract class TestsBase : IClassFixture<TestsHost>
    {
        public TestsBase(TestsHost host)
        {
            Host = host;
        }

        protected TestsHost Host { get; }
        protected TestServer Server => Host.Server;
        protected HttpClient Client => Host.Client;
        protected IServiceProvider ServiceProvider => Host.ServiceProvider;
    }
}
