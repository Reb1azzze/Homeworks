using System.Net.Http;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using hw6;
using hw8;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Hosting;

namespace hw12
{
    public class HostBuilderFSharp : WebApplicationFactory<App.Startup>
    {
        protected override IHostBuilder CreateHostBuilder() =>
            Host.CreateDefaultBuilder()
                .ConfigureWebHostDefaults(a =>
                    a.UseStartup<App.Startup>()
                        .UseTestServer());
    }

    public class HostBuilderCSharp : WebApplicationFactory<Startup>
    {
        protected override IHostBuilder CreateHostBuilder() =>
            Host.CreateDefaultBuilder()
                .ConfigureWebHostDefaults(a =>
                    a.UseStartup<Startup>()
                        .UseTestServer());
    }

    [MinColumn]
    [MaxColumn]
    public class Tests
    {
        private HttpClient fsC;
        private HttpClient csC;

        [GlobalSetup]
        public void Setup()
        {
            fsC = new HostBuilderFSharp().CreateClient();
            csC = new HostBuilderCSharp().CreateClient();
        }

        [Benchmark(Description = "FSharp")]
        public async Task FSharp()
        {
            await fsC.GetAsync("http://localhost:5000/calculate?v1=1&Operation=plus&v2=2");
        }
        [Benchmark(Description = "CSharp")]
        public async Task CSharp()
        {
            await csC.GetAsync("http://localhost:5001/calculator/calculate?val1=1&operation=plus&val2=2");
        }
    }
}