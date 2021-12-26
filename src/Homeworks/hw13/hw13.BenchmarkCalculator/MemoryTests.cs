using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web;
using JetBrains.dotMemoryUnit;
using Xunit;
using Xunit.Abstractions;

namespace hw13.BenchmarkCalculator
{
    public class MemoryTests : IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        private readonly HttpClient _client;
        private readonly ITestOutputHelper _testOutputHelper;
        private static readonly Random Random = new();
        private const string UrlFormat = "Calculator?expression={0}";

        public MemoryTests(CustomWebApplicationFactory<Startup> factory, ITestOutputHelper testOutputHelper)
        {
            _client = factory.CreateDefaultClient();
            var _ = _client.GetAsync(string.Format(UrlFormat, HttpUtility.UrlEncode("2 + 2"))).Result;
            _testOutputHelper = testOutputHelper;
            DotMemoryUnitTestOutput.SetOutputMethod(_testOutputHelper.WriteLine);
        }

        [DotMemoryUnit(FailIfRunWithoutSupport = false,CollectAllocations = true)]
        [Theory]
        [MemberData(nameof(GenerateExpressions))]
        public void MemoryTest(string url)
        {
            var memoryPoint = dotMemory.Check();

            // Act
            _client.GetAsync(url).GetAwaiter().GetResult();

            // Assert
            dotMemory.Check(memory =>
            {
                var collectedMemory = memory.GetTrafficFrom(memoryPoint).CollectedMemory.SizeInBytes;
                _testOutputHelper.WriteLine(collectedMemory.ToString());
                Assert.True(collectedMemory < 300_000);
            });
        }

        public static IEnumerable<object[]> GenerateExpressions()
        {
            const int count = 100;
            const int maxValue = 1000;
            var operations = new[] {"+", "-", "*", "/"};

            for (var i = 0; i < count; i++)
            {
                var val1 = Random.Next(maxValue);
                var val2 = Random.Next(maxValue);
                var op = operations[Random.Next(operations.Length)];
                yield return new object[] {string.Format(UrlFormat, HttpUtility.UrlEncode(val1 + op + val2))};
            }
        }
    }
}