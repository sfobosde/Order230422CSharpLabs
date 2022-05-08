using System;
using System.Windows.Forms;

namespace LR10
{
	public partial class Form1 : Form
	{
		/// <summary>
		/// Делегат для вычислений.
		/// </summary>
		/// <param name="firstArg"></param>
		/// <param name="secondArg"></param>
		public delegate void Calculating(double firstArg, double secondArg);

		/// <summary>
		/// Прототип делегата для вычисления СА.
		/// </summary>
		public Calculating CalculateAvg;

		/// <summary>
		/// Прототип делегата для вычисления НОК.
		/// </summary>
		public Calculating CalculateLcm;

		/// <summary>
		/// Прототип делегата для вычисления НОД.
		/// </summary>
		public Calculating CalculateGcd;

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
			if (int.TryParse(FirstArgumentTextBox.Text, out int firstArgument)
				&& int.TryParse(SecondArgumentTextBox.Text, out int secondArgument))
			{
				return (firstArgument, secondArgument);
			}

			if (string.IsNullOrEmpty(FirstArgumentTextBox.Text)
				|| string.IsNullOrEmpty(SecondArgumentTextBox.Text))
			{
				throw new Exception("Данные не введены.");
			}

			/// Если перевести не удалось, кидаем исключение.
			throw new Exception("Неккоретно введены данные." +
				"\nОжидалось целое число.");
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

		/// <summary>
		/// Вычисление среднего арифметичского.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AvgButton_Click(object sender, EventArgs e)
		{
			try
			{
				(double firstArg, double secondArg) = ValidateInitialData();
				CalculateAvg(firstArg, secondArg);
			}
			catch (Exception excp)
			{
				ResaultTextBox.Text = "";
				MessageLabel.Text = excp.Message;
			}
		}

		/// <summary>
		/// Вычисление НОК.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LcmButton_Click(object sender, EventArgs e)
		{
			try
			{
				(double firstArg, double secondArg) = ValidateInitialData();
				CalculateLcm(firstArg, secondArg);
			}
			catch (Exception excp)
			{
				ResaultTextBox.Text = "";
				MessageLabel.Text = excp.Message;
			}
		}

		/// <summary>
		/// Вычисление НОД.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GcdButton_Click(object sender, EventArgs e)
		{
			try
			{
				(double firstArg, double secondArg) = ValidateInitialData();
				CalculateGcd(firstArg, secondArg);
			}
			catch (Exception excp)
			{
				ResaultTextBox.Text = "";
				MessageLabel.Text = excp.Message;
			}
		}
	}
}
