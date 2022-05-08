using System;

namespace LR10
{
	/// <summary>
	/// Калькулятор.
	/// </summary>
	class Calculator
	{
		/// <summary>
		/// Сложение.
		/// </summary>
		/// <param name="firstArg"></param>
		/// <param name="secondArg"></param>
		/// <returns></returns>
		public double Addition(double firstArg, double secondArg)
		{
			return firstArg + secondArg;
		}

		/// <summary>
		/// Вычитание.
		/// </summary>
		/// <param name="firstArg"></param>
		/// <param name="secondArg"></param>
		/// <returns></returns>
		public double Substraction(double firstArg, double secondArg)
		{
			return firstArg - secondArg;
		}

		/// <summary>
		/// Умножение.
		/// </summary>
		/// <param name="firstArg"></param>
		/// <param name="secondArg"></param>
		/// <returns></returns>
		public double Multiplication(double firstArg, double secondArg)
		{
			return firstArg * secondArg;
		}

		/// <summary>
		/// Деление.
		/// </summary>
		/// <param name="firstArg"></param>
		/// <param name="secondArg"></param>
		/// <returns></returns>
		public double Division(double firstArg, double secondArg)
		{
			return firstArg / secondArg;
		}
	}
}
