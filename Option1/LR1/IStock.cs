using System;

namespace LR6
{
	/// <summary>
	/// Интерфейс акции для класса Товара.
	/// </summary>
	interface IStock
	{
		/// <summary>
		/// Использовать бонусы для оплаты товара.
		/// </summary>
		/// <param name="TotalPoints"></param>
		void UsePointsToPay(int TotalPoints);

		/// <summary>
		/// Получить информацию о акции на данный товар.
		/// </summary>
		void GetStocks();

		/// <summary>
		/// Устновить акцию на товар.
		/// </summary>
		/// <param name="StockInfo"></param>
		void SetStock(string StockInfo);
	}
}
