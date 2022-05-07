using System;

namespace LR9
{
	/// <summary>
	/// Класс - квадрат.
	/// </summary>
	class Squad
	{
		#region Поля
		/// <summary>
		/// Длина стороны.
		/// </summary>
		protected double sideLength;

		/// <summary>
		/// Диагональ квадрата.
		/// </summary>
		protected double diagonal;

		/// <summary>
		/// Периметр квадрата.
		/// </summary>
		protected double perimetr;

		/// <summary>
		/// Площадь квадрата.
		/// </summary>
		protected double square;
		#endregion

		#region Конструкторы
		/// <summary>
		/// В конструкторе передаем длину стороны.
		/// </summary>
		/// <param name="sideLength"></param>
		public Squad(double sideLength)
		{
			this.sideLength = sideLength;
		}
		#endregion

		#region Методы
		/// <summary>
		/// Вычисление свойств фигуры.
		/// </summary>
		public virtual void CalculateOptions()
		{
			/// Вычисление длины диагонали квадрата.
			diagonal = Math.Sqrt(2*sideLength*sideLength);

			/// Вычисляем периметр квадрата.
			perimetr = sideLength * 4;

			/// Вычисляем площадь квадрата.
			square = sideLength * sideLength;
		}

		/// <summary>
		/// Выовод сведений о фигуре.
		/// </summary>
		public virtual void GetSquadOptions()
		{
			Console.WriteLine($"Длина стороны:{sideLength}");
			Console.WriteLine($"Длина диагонали:{diagonal}");
			Console.WriteLine($"Периметр квадрата:{perimetr}"); 
			Console.WriteLine($"Площадь квадрата:{square}");
		}

		/// <summary>
		/// Получим значение площади.
		/// </summary>
		/// <returns></returns>
		public virtual double GetCheckingParametrValue()
		{
			return square;
		}
		#endregion 
	}
}
