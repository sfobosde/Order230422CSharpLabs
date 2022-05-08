using System;

namespace LR10
{
	/// <summary>
	/// Калькулятор.
	/// </summary>
	class Calculator
	{
		#region Calculations
		
		#endregion

		/// <summary>
		/// Делегат и событие передачи вычислений на форму.
		/// </summary>
		/// <param name="response"></param>
		public delegate void SendingCalculationResponse(double response);
		public event SendingCalculationResponse SendResponse;
	}
}
