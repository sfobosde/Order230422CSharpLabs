using System;

namespace LR6
{
	class Program
	{
		static void Main(string[] args)
		{
			/// Вызовем функцию создания товаров.
			CreateItems();
		}

		/// <summary>
		/// Функция для вывода данных о товаре.
		/// </summary>
		/// <param name="product"></param>
		static void PrintProductDetails(Product product)
		{
			Console.WriteLine($"Наименование товара:{product.Name}.");
			Console.WriteLine($"Количество товара:{product.Count} штук.");
			Console.WriteLine($"Стоимость товара:{product.Price} руб.");
			Console.WriteLine($"Описание товара:{product.Description}.");
			Console.WriteLine($"Оценка товара:{product.Grade}/5,0");
		}

		/// <summary>
		/// Функция для создания товаров.
		/// </summary>
		static void CreateItems()
		{
			/// Создадим пустой товар и выведем его данные.
			//Product product = new Product();
			//PrintProductDetails(product);

			/// Создадим какой нибудь не пустой товар.
			//product = new Product("Стол письменный", 20, 3000, "Для учебы и работы", (float)4.5);
			//PrintProductDetails(product);
		}
	}
}
