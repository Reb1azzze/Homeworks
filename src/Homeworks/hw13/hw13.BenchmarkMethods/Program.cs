using System.Reflection;
using BenchmarkDotNet.Running;

namespace hw13.BenchmarkMethods
{
	class Program
	{
		static void Main(string[] args)
		{
			BenchmarkRunner.Run<Benchmark>();
		}
	}
}