using System;

namespace LR10
{
	/// <summary>
	/// Калькулятор.
	/// </summary>
	class Calculator
	{
		/// <summary>
		/// Делегат и событие передачи вычислений на форму.
		/// </summary>
		/// <param name="response"></param>
		public delegate void SendingCalculationResponse(double response);
		public event SendingCalculationResponse SendResponse;

		#region Calculations
		/// <summary>
		/// Функция для вычисления СА.
		/// </summary>
		public void CalculateAvg(double firstArg, double secondArg)
		{
			SendResponse((firstArg + secondArg) / 2);
		}

		/// <summary>
		/// Функция для вычисления НОК.
		/// </summary>
		public void CalculateLcm(double firstArg, double secondArg)
		{
			double gcd = GetGcd(firstArg, secondArg);
			SendResponse(firstArg * secondArg / gcd);
		}

		/// <summary>
		/// Функция для вычисления НОД.
		/// </summary>
		public void CalculateGcd(double firstArg, double secondArg)
		{
			SendResponse(GetGcd(firstArg, secondArg));
		}

		/// <summary>
		/// Вычисление НОД.
		/// </summary>
		/// <param name="firstArg"></param>
		/// <param name="secondArg"></param>
		/// <returns></returns>
		private double GetGcd(double firstArg, double secondArg)
		{
			double divider = 1;
			double gcd = divider;
			int totalDividers = 0;

			while (divider <= Math.Min(firstArg, secondArg))
			{
				if (firstArg % divider == 0 && (secondArg % divider == 0))
				{
					gcd = divider;
				}

				totalDividers++;
				divider++;
			}

			return gcd;
		}
		#endregion
	}
}
