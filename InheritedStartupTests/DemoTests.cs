using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace InheritedStartupTests
{
    public class DemoTests : TestsBase
    {
        public DemoTests(WebApplicationFactory<TestsStartup> factory) : base(factory)
        {
        }

        [Fact]
        public async Task CorrectEndpoint()
        {
            HttpResponseMessage response = await Client.GetAsync("/api/values");
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }

        [Fact]
        public async Task CorrectValue()
        {
            HttpResponseMessage response = await Client.GetAsync("/api/values/5");
            response.StatusCode.Should().Be(HttpStatusCode.OK);
            string data = await response.Content.ReadAsStringAsync();
            data.Should().Be("value-5");
        }

        [Fact]
        public async Task InvalidEndpoint()
        {
            HttpResponseMessage response = await Client.GetAsync("/api/invalid");
            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }
    }
}
