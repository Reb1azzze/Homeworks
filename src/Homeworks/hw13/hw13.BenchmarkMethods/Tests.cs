using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw13.BenchmarkMethods
{
	class Tests
	{
		public string SimpleMethod(string num)
		{			
			return num + num + "-simple";
		}

		public static string StaticMethod(string num)
		{
			return num + num + "-static";
		}

		public virtual string VirtualMethod(string num)
		{
			return num + num + "virtual";
		}

		public string DynamicMethod(dynamic num)
		{
			return num + num.ToString() + "dynamic";
		}

		public string GenericMethod<T>(T num)
		{
			return num.ToString() + num + "generic";
		}		

		public string ReflectionMethod(string num)
		{
			return num + num + "reflect";
		}
	}
}
