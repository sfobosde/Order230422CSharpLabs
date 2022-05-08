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

			/// ������� ����� � ����������� � Program.
			var form = new Form1();
			var calculator = new Calculator();

			/// ����������� ������� �� ��������.

			calculator.SendResponse += form.GetResponseFromCalculator;

			/// ��������� �����.
			Application.Run(form);
		}
	}
}
