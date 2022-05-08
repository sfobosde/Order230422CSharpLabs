using System;
using System.Windows.Forms;

namespace LR10
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Проверка исходных данных на корректность.
		/// </summary>
		private (double, double) ValidateInitialData()
		{
			/// Пытаемся перевести текст в double.
			if (Double.TryParse(FirstArgumentTextBox.Text, out double firstArgument)
				&& Double.TryParse(SecondArgumentTextBox.Text, out double secondArgument))
			{
				return (firstArgument, secondArgument);
			}

			/// Если перевести не удалось, кидаем исключение.
			throw new ArgumentException("Неккоретно введены данные.");
		}
	}
}
