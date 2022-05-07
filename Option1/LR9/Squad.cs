using System;

namespace LR9
{
	/// <summary>
	/// Класс - квадрат.
	/// </summary>
	class Squad
	{
		#region Свойства
		/// <summary>
		/// Длина стороны.
		/// </summary>
		public double SideLength
		{
			get
			{
				return sideLength;
			}
			set
			{
				/// Проверка на неотрицательность значений.
				if (value>0)
				{
					sideLength = value;

					/// Перерассчитываем все свойства квадрата.
					CalculateOptions();
				}
			}
		}

		/// <summary>
		/// Диагональ квадрата.
		/// </summary>
		public double Diagonal
		{
			/// Только возвращаем значение длины диагонали.
			get
			{
				return diagonal;
			}
		}

		/// <summary>
		/// Периметр квадрата.
		/// </summary>
		public double Perimetr
		{
			/// Только возвращаем значение периметра.
			get
			{
				return perimetr;
			}
		}

		/// <summary>
		/// Площадь квадрата.
		/// </summary>
		public double Square
		{
			/// Только возвращаем значение периметра.
			get
			{
				return square;
			}
		}
		#endregion

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

			/// Рассчитываем все свойства квадрата.
			CalculateOptions();
		}
		#endregion

		#region Методы
		/// <summary>
		/// Вычисление свойств фигуры.
		/// </summary>
		protected virtual void CalculateOptions()
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
		#endregion 
	}
}
