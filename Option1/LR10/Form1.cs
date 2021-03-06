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
		public delegate void Calculating(double firstArg, double secondArg);

		/// <summary>
		/// Прототип делегата сложения.
		/// </summary>
		public Calculating adition;

		/// <summary>
		/// Прототип делегата вычитания.
		/// </summary>
		public Calculating substraction;

		/// <summary>
		/// Прототип делегата умножения.
		/// </summary>
		public Calculating multiplication;

		/// <summary>
		/// Прототип делегата деления.
		/// </summary>
		public Calculating division;

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
				adition(firstArg, secondArg);
			}
			catch (Exception excp)
			{
				ResaultTextBox.Text = "";
				MessageLabel.Text = excp.Message;
			}
		}

		/// <summary>
		/// Нажата кнопка Вычитание.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SubstractionButton_Click(object sender, EventArgs e)
		{
			try
			{
				(double firstArg, double secondArg) = ValidateInitialData();
				substraction(firstArg, secondArg);
			}
			catch (Exception excp)
			{
				ResaultTextBox.Text = "";
				MessageLabel.Text = excp.Message;
			}
		}

		/// <summary>
		/// Нажата кнопка умножения.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void MultiplicationButton_Click(object sender, EventArgs e)
		{
			try
			{
				(double firstArg, double secondArg) = ValidateInitialData();
				multiplication(firstArg, secondArg);
			}
			catch (Exception excp)
			{
				ResaultTextBox.Text = "";
				MessageLabel.Text = excp.Message;
			}
		}

		/// <summary>
		/// Нажата кнопка деления.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DivisionButton_Click(object sender, EventArgs e)
		{
			try
			{
				(double firstArg, double secondArg) = ValidateInitialData();
				division(firstArg, secondArg);
			}
			catch (Exception excp)
			{
				ResaultTextBox.Text = "";
				MessageLabel.Text = excp.Message;
			}
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
