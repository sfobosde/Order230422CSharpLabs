using System;
using System.Windows.Forms;

namespace LR10
{
	static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			/// Создаем форму и калькулятор в Program.
			var form = new Form1();
			var calculator = new Calculator();

			/// Подписываемся на делегаты и события.
			form.CalculateAvg += calculator.CalculateAvg;
			form.CalculateLcm += calculator.CalculateLcm;
			form.CalculateGcd += calculator.CalculateGcd;

			calculator.SendResponse += form.GetResponseFromCalculator;

			/// Подписываем функции на делегаты.

			calculator.SendResponse += form.GetResponseFromCalculator;

			/// Запускаем форму.
			Application.Run(form);
		}
	}
}
