using System;

namespace LR6
{
	/// <summary>
	/// Класс мебели.
	/// Дочерний класс от Product.
	/// </summary>
	class Furniture : Product
	{
		/// <summary>
		/// Категория мебели.
		/// </summary>
		public string FurnitureCategory;

		/// <summary>
		/// Вес мебели.
		/// </summary>
		public float Weight;

		/// <summary>
		/// Функция расчета стоимость грузоперевозки (доставки до клиента).
		/// </summary>
		/// <param name="distance"> Дистанция до клиента в км. </param>
		/// <returns></returns>
		public float CalculateCargoTransporation(float distance)
		{
			/// За каждый килломентр 50 рублей.
			return distance * 50;
		}
	}
}
