using System;

namespace LR6
{
	/// <summary>
	/// Класс товара.
	/// </summary>
	abstract class Product : IStock
	{
		#region Поля
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
		/// Скидки на данный товар.
		/// </summary>
		public string Stocks;

		#endregion

		#region Конструкторы, деструкторы
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
		#endregion

		#region Собственные методы.
		/// <summary>
		/// Получить категорию товара.
		/// Виртуальный метод.
		/// </summary>
		/// <returns> Категория товара. </returns>
		public virtual string GetProductCategory()
		{
			return "Категория не определена.";
		}
		#endregion

		#region Унаследовано от интерфейса
		/// <summary>
		/// Если введо пустое значение строки, то скидки не существует, значит ставим false, иначе true;
		/// </summary>
		/// <param name="StockInfo"></param>
		public void SetStock(string StockInfo)
		{
			Stocks = StockInfo;
		}

		/// <summary>
		/// Получить акции на товар.
		/// </summary>
		public void GetStocks()
		{
			if (!string.IsNullOrEmpty(Stocks))
			{
				Console.WriteLine(Stocks);
				return;
			}
			Console.WriteLine("Акций на данный товар нет.");
		}

		/// <summary>
		/// Не определяем тут, определим в дочерних классах.
		/// </summary>
		/// <param name="TotalPoints"></param>
		public abstract void UsePointsToPay(int TotalPoints);
		#endregion
	}
}
