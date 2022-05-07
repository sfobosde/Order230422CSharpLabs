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
		/// Длина стороны
		/// </summary>
		public int SideLength
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
				}
			}
		}
		#endregion

		#region Поля
		/// <summary>
		/// Длина стороны.
		/// </summary>
		private int sideLength;
		#endregion

		#region Конструкторы
		/// <summary>
		/// В конструкторе передаем длину стороны.
		/// </summary>
		/// <param name="sideLength"></param>
		public Squad(int sideLength)
		{
			this.sideLength = sideLength;
		}
		#endregion
	}
}
