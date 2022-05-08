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

			var form = new Form1();
			var calculator = new Calculator();

			form.adition += calculator.Addition;

			Application.Run(form);
		}
	}
}
