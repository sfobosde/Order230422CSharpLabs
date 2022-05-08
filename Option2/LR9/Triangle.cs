using System;


namespace LR9
{
	/// <summary>
	/// Класс - треугольник
	/// </summary>
	class Triangle
	{
		#region Поля

		/// <summary>
		/// Массив длины сторон.
		/// </summary>
		protected double[] sidesLength;

		/// <summary>
		/// Периметр треугольника
		/// </summary>
		protected double perimetr;
		#endregion

		#region Методы

		/// <summary>
		/// Проверка на существование такого треуголника.
		/// </summary>
		/// <returns></returns>
		protected bool IsTriangleExists()
		{
			return (sidesLength[0] + sidesLength[1] > sidesLength[2]
				&& sidesLength[1] + sidesLength[2] > sidesLength[0]
				&& sidesLength[0] + sidesLength[2] > sidesLength[1]);
		}

		/// <summary>
		/// Вычисление периметра, углов, площади.
		/// </summary>
		protected void CalculateOptions()
		{
			/// Вычисление периметра.
			for (int sideNum = 0;
				sideNum < 3;
				perimetr += sidesLength[sideNum],
				sideNum++) ;
		}

		/// <summary>
		/// Вывод информации о треугольнике.
		/// </summary>
		public void GetTriangleOptions()
		{
			/// Вывод длины сторон.
			Console.WriteLine($"Длина стороны:{sidesLength[0]}");
			Console.WriteLine($"Длина стороны:{sidesLength[1]}");
			Console.WriteLine($"Длина стороны:{sidesLength[2]}");

			/// Вывод периметра.
			Console.WriteLine($"Периметр:{perimetr}");
		}
		#endregion

		#region Конструкторы

		public Triangle(double[] sidesLength)
		{
			this.sidesLength = sidesLength;

			if (!IsTriangleExists())
			{
				throw new Exception("Такой треугольник не может существовать.");
			}

			CalculateOptions();
		}

		public Triangle(double firstSide, double secondSide, double thirdSide)
			: this(new double[]{firstSide, secondSide, thirdSide})
		{
			
		}
		#endregion
	}
}
