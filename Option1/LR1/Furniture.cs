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

		/// <summary>
		/// Перегрузка родительского метода.
		/// </summary>
		/// <returns></returns>
		public override string GetProductCategory()
		{
			return "Мебель " + FurnitureCategory;
		}

		/// <summary>
		/// Конструктор для класса.
		/// Поля из родительского класса передаются в родительский конструктор через base().
		/// </summary>
		public Furniture(
			string Name,
			int Count,
			float Price,
			string Description,
			float Grade,
			string FurnitureCategory,
			float Weight)
			: base(Name, Count, Price, Description, Grade)
		{
			/// Передаем значения полям дочернего класса.
			this.FurnitureCategory = FurnitureCategory;
			this.Weight = Weight;
		}

		/// <summary>
		/// При коснтрукторе по умолчанию вызовем такой же в родительском.
		/// </summary>
		public Furniture() : base()
		{
			/// Делаем поля пустыми.
			FurnitureCategory = "Категория не определена";
			Weight = 0;
		}
	}
}
