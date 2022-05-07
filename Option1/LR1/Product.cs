using System;

namespace LR6
{
	/// <summary>
	/// Класс товара.
	/// </summary>
	abstract class Product
	{
		/// <summary>
		/// Имя товара.
		/// </summary>
		public string Name;

		/// <summary>
		/// Количество.
		/// </summary>
		public int Count;

		/// <summary>
		/// Стоимость.
		/// </summary>
		public float Price;

		/// <summary>
		/// Описание товара.
		/// Дополнительное поле.
		/// </summary>
		public string Description;

		/// <summary>
		/// Оценка товара.
		/// Дополнительное поле.
		/// </summary>
		public float Grade;

		/// <summary>
		/// Конструктор по умолчанию.
		/// </summary>
		public Product()
		{
			Name = "Без названия";
			Count = 0;
			Price = 0;
			Description = "Нет описания товара";
			Grade = 0;
		}

		/// <summary>
		/// Конструктор с аргументами.
		/// </summary>
		public Product(string Name, int Count, float Price, string Description, float Grade)
		{
			this.Name = Name;
			this.Count = Count;
			this.Price = Price;
			this.Description = Description;
			this.Grade = Grade;
		}
		
		/// <summary>
		/// Деструктор.
		/// </summary>
		~Product()
		{
			Console.WriteLine("Не забудьте добавить товар в корзину перед закрытием.");
		}

		/// <summary>
		/// Получить категорию товара.
		/// Виртуальный метод.
		/// </summary>
		/// <returns> Категория товара. </returns>
		public virtual string GetProductCategory()
		{
			return "Категория не определена.";
		}
	}
}
