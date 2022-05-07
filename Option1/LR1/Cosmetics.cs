using System;

namespace LR6
{
	/// <summary>
	/// Класс косметики.
	/// Дочерний класс от Product.
	/// </summary>
	class Cosmetics : Product
	{
		/// <summary>
		/// Косметика, предназначеная для женщин.
		/// </summary>
		public bool ForWomen;

		/// <summary>
		/// Объем косметики.
		/// </summary>
		public float Volume;

		/// <summary>
		/// Отправить заявку на становления амбассадора бренда косметики.
		/// </summary>
		/// <param name="userId"> id пользователя. </param>
		public void BecomeAmbassador(string userId)
		{
			Console.WriteLine("Ваша заявка отправлена на рассмотрение оператору компании!");
		}
	}
}
