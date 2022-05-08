using System;
using System.Collections.Generic;

namespace LR6
{
	/// <summary>
	/// Класс родителя в семье.
	/// </summary>
	class Parent : Person
	{
		#region Поля

		/// <summary>
		/// Супруг.
		/// </summary>
		public Person Spouse;

		/// <summary>
		/// Дети.
		/// </summary>
		protected List<Children> Childrens;
		#endregion

		#region Методы
		/// <summary>
		/// Выйти замуж/жениться.
		/// </summary>
		/// <param name="spouse"></param>
		public void MarryOn(Person spouse)
		{
			Spouse = spouse;
		}

		/// <summary>
		/// Специальная возможность - отказаться от детей.
		/// </summary>
		public override void UseSpecialAbilities()
		{
			Childrens = null;
			Console.WriteLine("Вы отказались от детей.");
		}
		#endregion

		#region Конструкторы
		public Parent(
			string Name,
			string Surname,
			int Age,
			bool Male,
			string Phone,
			List<Children> Childrens) 
			: base(Name, Surname, Age, Male, Phone)
		{
			this.Childrens = Childrens;
		}
		#endregion
	}
}
