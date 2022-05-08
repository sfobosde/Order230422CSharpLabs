using System;

namespace LR10
{
	/// <summary>
	/// Калькулятор.
	/// </summary>
	class Calculator
	{
		#region Calculations
		/// <summary>
		/// Сложение.
		/// </summary>
		/// <param name="firstArg"></param>
		/// <param name="secondArg"></param>
		/// <returns></returns>
		public void Addition(double firstArg, double secondArg)
		{
			SendResponse(firstArg + secondArg);
		}

		/// <summary>
		/// Вычитание.
		/// </summary>
		/// <param name="firstArg"></param>
		/// <param name="secondArg"></param>
		/// <returns></returns>
		public void Substraction(double firstArg, double secondArg)
		{
			SendResponse(firstArg - secondArg);
		}

		/// <summary>
		/// Умножение.
		/// </summary>
		/// <param name="firstArg"></param>
		/// <param name="secondArg"></param>
		/// <returns></returns>
		public void Multiplication(double firstArg, double secondArg)
		{
			SendResponse(firstArg * secondArg);
		}

		/// <summary>
		/// Деление.
		/// </summary>
		/// <param name="firstArg"></param>
		/// <param name="secondArg"></param>
		/// <returns></returns>
		public void Division(double firstArg, double secondArg)
		{
			SendResponse(firstArg / secondArg);
		}
		#endregion

		/// <summary>
		/// Делегат и событие передачи вычислений на форму.
		/// </summary>
		/// <param name="response"></param>
		public delegate void SendingCalculationResponse(double response);
		public event SendingCalculationResponse SendResponse;
	}
}
