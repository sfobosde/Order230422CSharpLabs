using System;

namespace LR9
{
	class Prism : Squad
	{
		#region Поля
		/// <summary>
		/// Высота призмы.
		/// </summary>
		protected double height;

		/// <summary>
		/// Объем призмы.
		/// </summary>
		protected double volume;
		#endregion

		#region Конструкторы
		/// <summary>
		/// В конструкторе передаем длину стороны и высоту.
		/// </summary>
		/// <param name="sideLength"></param>
		public Prism(double sideLength, double height) : base(sideLength)
		{
			this.height = height;
		}
		#endregion

		#region Методы
		/// <summary>
		/// Вычисление диагонали, площади, периметра, объема.
		/// </summary>
		public override void CalculateOptions()
		{
			/// Вычисление длины диагонали.
			diagonal = Math.Sqrt(2 * sideLength * sideLength + height * height);

			/// Вычисляем периметр.
			perimetr = sideLength * 8 + 4 * height;

			/// Вычисляем площадь.
			square = sideLength * sideLength * 2 + 4 * sideLength * height;

			/// Вычисляем объем.
			volume = sideLength * sideLength * height;
		}

		/// <summary>
		/// Выовод сведений о фигуре.
		/// </summary>
		public override void GetSquadOptions()
		{
			Console.WriteLine($"Длина стороны:{sideLength}");
			Console.WriteLine($"Длина диагонали:{diagonal}");
			Console.WriteLine($"Периметр:{perimetr}");
			Console.WriteLine($"Площадь:{square}");
			Console.WriteLine($"Объем:{volume}");
		}

		/// <summary>
		/// Получим значение площади.
		/// </summary>
		/// <returns></returns>
		public override double GetCheckingParametrValue()
		{
			return diagonal;
		}
		#endregion
	}
}
