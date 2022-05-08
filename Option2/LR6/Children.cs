using System;
using System.Collections.Generic;

namespace LR6
{
	class Children : Person
	{
		#region Поля
		/// <summary>
		/// Родители.
		/// </summary>
		protected List<Person> Parents;

		/// <summary>
		/// Средний балл в школе.
		/// </summary>
		protected double AverageEducationRate;
		#endregion

		#region Методы
		/// <summary>
		/// Специальная возможность - покурить в туалете.
		/// </summary>
		public override void UseSpecialAbilities()
		{
			Console.WriteLine("Вы успешно покурили в школьном туалете");
		}

		/// <summary>
		/// Начать учиться лучше.
		/// </summary>
		public void StartStudy()
		{
			AverageEducationRate += 0.1;

			Console.WriteLine($"Ваша успеваемость в школе улучшилась. " +
				$"Средний балл: {AverageEducationRate}");
		}

		/// <summary>
		/// Основная деятельность ребенка - учеба в школе.
		/// </summary>
		public override void CarryOutMainActivity()
		{
			Console.WriteLine("Вы пошли в школу.");
		}
		#endregion

		#region Конструкторы
		public Children(
			string Name,
			string Surname,
			int Age,
			bool Male,
			string Phone,
			List<Person> Parents)
			: base(Name, Surname, Age, Male, Phone)
		{
			this.Parents = Parents;
		}
		#endregion
	}
}
