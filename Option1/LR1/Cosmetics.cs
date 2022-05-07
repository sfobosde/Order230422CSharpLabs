using System;

namespace LR6
{
	/// <summary>
	/// Класс косметики.
	/// Дочерний класс от Product.
	/// </summary>
	class Cosmetics : Product
	{
		#region Поля
		/// <summary>
		/// Косметика, предназначеная для женщин.
		/// </summary>
		public bool ForWomen;

		/// <summary>
		/// Объем косметики.
		/// </summary>
		public float Volume;
		#endregion

		#region Собственные методы
		/// <summary>
		/// Отправить заявку на становления амбассадора бренда косметики.
		/// </summary>
		/// <param name="userId"> id пользователя. </param>
		public void BecomeAmbassador(string userId)
		{
			Console.WriteLine("Ваша заявка отправлена на рассмотрение оператору компании!");
		}

		/// <summary>
		/// Перегрузка метода родительского класса.
		/// </summary>
		/// <returns></returns>
		public override string GetProductCategory()
		{
			return ((ForWomen) ? "Женская " : "Мужская ") + "косметика.";
		}
		#endregion

		#region Унаследованные методы
		/// <summary>
		/// Использование бонусов при оплате.
		/// </summary>
		/// <param name="TotalPoints"></param>
		public override void UsePointsToPay(int TotalPoints)
		{
			/// Лимит для оплаты = 30% от стоимости.
			double limitToPay = 0.30;

			/// Если бонусов больше чем допустимый размер оплаты ими, то скидка будет 30%
			double discount = (TotalPoints > Price * limitToPay) ?
				Price * limitToPay
				: TotalPoints;

			/// Выведем информацию о скидке и цене с учетом скидки.
			Console.WriteLine($"Скидка составила:{discount} рублей. " +
				$"Итоговая стоимость товара:{Price - discount}");
		}
		#endregion

		#region Конструкторы
		/// <summary>
		/// Конструктор для класса.
		/// Поля из родительского класса передаются в родительский конструктор через base().
		/// </summary>
		public Cosmetics(
			string Name, 
			int Count, 
			float Price, 
			string Description, 
			float Grade, 
			bool ForWomen,
			float Volume) 
			: base(Name, Count, Price, Description, Grade)
		{
			/// Передаем значения полям дочернего класса.
			this.ForWomen = ForWomen;
			this.Volume = Volume;
		}

		/// <summary>
		/// При коснтрукторе по умолчанию вызовем такой же в родительском.
		/// </summary>
		public Cosmetics() : base()
		{
			/// Делаем поля пустыми.
			ForWomen = false;
			Volume = 0;
		}
		#endregion
	}
}
