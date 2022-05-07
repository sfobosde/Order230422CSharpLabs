using System;

namespace LR1
{
	/// <summary>
	/// Класс товара.
	/// </summary>
	class Product
	{
		/// <summary>
		/// Имя товара.
		/// </summary>
		public string Name;

		/// <summary>
		/// Колличество.
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
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Не забудьте посмотреть похожие товары.");
		}

		/// <summary>
		/// Создадим функцию, которая впоследствие вызовет деструктор.
		/// </summary>
		/// <param name="similarItemsCount"></param>
		public void GetSimilarItems()
		{
			Product similarProduct = new Product(Name, Count, Price, Description, Grade);
		}
	}
}
