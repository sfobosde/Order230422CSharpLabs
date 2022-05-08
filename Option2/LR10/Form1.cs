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

			if (string.IsNullOrEmpty(FirstArgumentTextBox.Text)
				|| string.IsNullOrEmpty(SecondArgumentTextBox.Text))
			{
				throw new Exception("Данные не введены.");
			}

			/// Если перевести не удалось, кидаем исключение.
			throw new Exception("Неккоретно введены данные.");
		}

		/// <summary>
		/// Обработчик события.
		/// Вывод результата на форму.
		/// </summary>
		/// <param name="response"></param>
		public void GetResponseFromCalculator(double response)
		{
			ResaultTextBox.Text = response.ToString();
			MessageLabel.Text = "Вычислено!";
		}

		/// <summary>
		/// Кнопка отчистить форму.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ClearScreenButton_Click(object sender, EventArgs e)
		{
			FirstArgumentTextBox.Text = "";
			SecondArgumentTextBox.Text = "";
			ResaultTextBox.Text = "";
			MessageLabel.Text = "";
		}
	}
}
