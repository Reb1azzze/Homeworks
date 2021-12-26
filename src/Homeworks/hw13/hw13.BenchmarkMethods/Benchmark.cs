using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

namespace hw13.BenchmarkMethods 
{
	[MemoryDiagnoser]
	[MedianColumn]
	[MinColumn]
	[MaxColumn]
	[MeanColumn]
	[StdDevColumn]
	public class Benchmark
    {
		private Tests test;
		private string testValue;
		private static MethodInfo ReflectionMethod;

		[GlobalSetup]
		public void Setup()
		{
			test = new Tests();
			testValue = "method";
			ReflectionMethod = typeof(Tests).GetMethod("ReflectionMethod");			
		}

		[Benchmark(Description = "Simple")]
		public void TestSimpleMethod()
		{
			test.SimpleMethod(testValue);
		}

		[Benchmark(Description = "Static")]
		public void TestStaticMethod()
		{
			Tests.StaticMethod(testValue);
		}

		[Benchmark(Description = "Virtual")]
		public void TestVirtualMethod()
		{
			test.VirtualMethod(testValue);
		}		

		[Benchmark(Description = "Dynamic")]
		public void TestDynamicMethod()
		{
			test.DynamicMethod(testValue);
		}

		[Benchmark(Description = "Generic")]
		public void TestGenericMethod()
		{
			test.GenericMethod<string>(testValue);
		}

		[Benchmark(Description = "Reflection")]
		public void TestReflectionMethod()
		{
			ReflectionMethod.Invoke(test, new object[] { testValue });
		}
	}
}
