using hw8.Interface;

namespace hw8
{
	public class NumericalCalculator : ICalculator
	{
		public double Add(double fVal, double sVal)
			=> fVal + sVal;

		public double Subtract(double fVal, double sVal)
			=> fVal - sVal;

		public double Divide(double fVal, double sVal)
			=> sVal == 0 ? 0 : fVal / sVal;

		public double Multiply(double fVal, double sVal)
			=> fVal * sVal;
	}
}