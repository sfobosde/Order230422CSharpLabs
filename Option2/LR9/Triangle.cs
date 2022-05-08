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

		/// <summary>
		/// Площадь треугольника.
		/// </summary>
		protected double square;

		/// <summary>
		/// Углы треугольника.
		/// </summary>
		protected double[] angels;
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

			/// Находим полупериметр и площадь по формули герона.
			double halfPerimetr = perimetr / 2;
			square = Math.Sqrt(halfPerimetr 
				* (halfPerimetr - sidesLength[0])
				* (halfPerimetr - sidesLength[1])
				* (halfPerimetr - sidesLength[2]));

			CalculateAngels();
		}

		/// <summary>
		/// Вычисление углов.
		/// </summary>
		protected void CalculateAngels()
		{
			/// Вычисление углов треугольника.
			angels = new double[3];

			for (int sideNum = 0; sideNum < 3; sideNum++)
			{
				angels[sideNum] = Math.Acos((sidesLength[sideNum] * sidesLength[sideNum]
					+ sidesLength[(sideNum + 1) % 3] * sidesLength[(sideNum + 1) % 3]
					- sidesLength[(sideNum + 2) % 3] * sidesLength[(sideNum + 2) % 3])
					/ (2 * sidesLength[sideNum] * sidesLength[(sideNum + 1) % 3])) 
					* 180 
					/ Math.PI;
			}
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

			/// Площадь треугольника.
			Console.WriteLine($"Площадь треугольника:{square}");

			/// Углы треугольника.
			Console.WriteLine($"Угол треугольника:{angels[0]} градусов.");
			Console.WriteLine($"Угол треугольника:{angels[1]} градусов.");
			Console.WriteLine($"Угол треугольника:{angels[2]} градусов.");
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
