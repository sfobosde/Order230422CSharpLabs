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
			Console.WriteLine($"Категория товара:{product.GetProductCategory()}\n");
		}

		/// <summary>
		/// Функция для создания товаров.
		/// </summary>
		static void CreateItems()
		{
			/// Создадим пустой товар и выведем его данные.
			Cosmetics cosmetic = new Cosmetics();
			PrintProductDetails(cosmetic);

			Furniture furniture = new Furniture();
			PrintProductDetails(furniture);

			/// Создаем крем для рук.
			cosmetic = new Cosmetics(
				"Крем для рук",
				500,
				999,
				"Увлажняющий крем",
				(float)4.0,
				true,
				(float)0.33);

			/// Создаем письменный стол.
			furniture = new Furniture(
				"Стол письменный", 
				20, 3000, 
				"Для учебы и работы.", 
				(float)4.5,
				"В спальню.",
				24);

			/// Бонусные очки для оплаты товара.
			int bonusPoints = 350;

			/// Выводим информацию о обоих товарах.
			PrintProductDetails(cosmetic);
			cosmetic.BecomeAmbassador("8468441566");

			TestStocks(cosmetic, bonusPoints, "2+1");

			PrintProductDetails(furniture);
			Console.WriteLine($"Расстояние до магазина: 5 км. Стоимость доставки составит:" +
				$"{furniture.CalculateCargoTransporation(5)} руб.");

			TestStocks(furniture, bonusPoints, "Бесплатная доставка");
		}

		/// <summary>
		/// Проверка работы акций.
		/// Тестим работу интерфейса.
		/// </summary>
		/// <param name="stockProduct"></param>
		static void TestStocks(IStock stockProduct, int bonusPoints, string stock)
		{
			/// Проверяем наличие акций.
			stockProduct.GetStocks();

			/// Добавляем акцию.
			stockProduct.SetStock(stock);

			/// Проверяем наличие акций.
			stockProduct.GetStocks();

			/// Пробуем оплатить бонусами и узнаем цену.
			stockProduct.UsePointsToPay(bonusPoints);

			/// Убирвем акцию.
			stockProduct.SetStock("");
		}
	}
}
