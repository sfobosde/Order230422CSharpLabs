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
		/// Делегат для вычитания.
		/// </summary>
		/// <param name="firstArg"></param>
		/// <param name="secondArg"></param>
		/// <returns></returns>
		public delegate double Substraction(double firstArg, double secondArg);

		/// <summary>
		/// Делегат для умножения.
		/// </summary>
		/// <param name="firstArg"></param>
		/// <param name="secondArg"></param>
		/// <returns></returns>
		public delegate double Multiplication(double firstArg, double secondArg);

		/// <summary>
		/// Делегат для деления.
		/// </summary>
		/// <param name="firstArg"></param>
		/// <param name="secondArg"></param>
		/// <returns></returns>
		public delegate double Division(double firstArg, double secondArg);

		/// <summary>
		/// Прототип делегата сложения.
		/// </summary>
		public Adition adition;

		/// <summary>
		/// Прототип делегата вычитания.
		/// </summary>
		public Substraction substraction;

		/// <summary>
		/// Прототип делегата умножения.
		/// </summary>
		public Multiplication multiplication;

		/// <summary>
		/// Прототип делегата деления.
		/// </summary>
		public Division division;

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
				MessageLabel.Text = "Вычислено!";
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
				ResaultTextBox.Text = substraction(firstArg, secondArg).ToString();
				MessageLabel.Text = "Вычислено!";
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
				ResaultTextBox.Text = multiplication(firstArg, secondArg).ToString();
				MessageLabel.Text = "Вычислено!";
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
				ResaultTextBox.Text = division(firstArg, secondArg).ToString();
				MessageLabel.Text = "Вычислено!";
			}
			catch (Exception excp)
			{
				ResaultTextBox.Text = "";
				MessageLabel.Text = excp.Message;
			}
		}
	}
}
