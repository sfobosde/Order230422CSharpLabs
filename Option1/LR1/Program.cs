using System;

namespace LR1
{
	class Program
	{
		static void Main(string[] args)
		{
			Product emptyProduct = new Product();
			Product table = new Product("Стол письменный", 20, 3000, "Для учебы и работы", (float)4.5);

			PrintProductDetails(emptyProduct);
			PrintProductDetails(table);
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
	}
}
