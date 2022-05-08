using System;
using System.Windows.Forms;

namespace LR10
{
	public partial class Form1 : Form
	{
		/// <summary>
		/// Делегат для сложения.
		/// </summary>
		/// <param name="firstArg"></param>
		/// <param name="secondArg"></param>
		/// <returns></returns>
		public delegate double Adition(double firstArg, double secondArg);

		/// <summary>
		/// Прототип делегата сложения.
		/// </summary>
		public Adition adition;

		/// <summary>
		/// Конструктор формы.
		/// </summary>
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
		/// Нажата кнопка сложения.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AdditionButton_Click(object sender, EventArgs e)
		{
			try
			{
				(double firstArg, double secondArg) = ValidateInitialData();
				ResaultTextBox.Text = adition(firstArg, secondArg).ToString();
			}
			catch (Exception excp)
			{
				ResaultTextBox.Text = "";
				MessageLabel.Text = excp.Message;
			}
		}
	}
}
