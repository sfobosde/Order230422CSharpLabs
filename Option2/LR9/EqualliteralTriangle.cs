using System;

namespace LR9
{
	class EqualliteralTriangle : Triangle
	{
		#region Методы
		/// <summary>
		/// Проверка на равносторонность треугольника.
		/// </summary>
		/// <returns></returns>
		protected override bool CheckTriangleParams()
		{
			return (sidesLength[0] == sidesLength[1]
				&& sidesLength[1] == sidesLength[2]
				&& sidesLength[2] == sidesLength[0]);
		}

		/// <summary>
		/// Вывод информации о треугольнике.
		/// </summary>
		public override void GetTriangleOptions()
		{
			/// Вывод длины сторон.
			Console.WriteLine($"Длина сторон:{sidesLength[0]}");

			/// Вывод периметра.
			Console.WriteLine($"Периметр:{perimetr}");

			/// Площадь треугольника.
			Console.WriteLine($"Площадь треугольника:{square}");

			/// Углы треугольника.
			Console.WriteLine($"Уголы треугольника:{angels[0]} градусов.");
		}
		#endregion

		#region Конструкторы
		public EqualliteralTriangle(double[] sidesLength) : base(sidesLength)
		{
			this.sidesLength = sidesLength;

			if (!CheckTriangleParams())
			{
				throw new Exception("Треугольник не равносторонний.");
			}
		}

		public EqualliteralTriangle(double firstSide, double secondSide, double thirdSide)
			: this(new double[] { firstSide, secondSide, thirdSide })
		{
		}

		public EqualliteralTriangle(double sideLength)
			: this(sideLength, sideLength, sideLength)
		{

		}
		#endregion
	}
}
