using System;

namespace LR6
{
	/// <summary>
	/// Класс персона.
	/// </summary>
	abstract class Person : IPerson
	{
		#region Поля
		/// <summary>
		/// Имя.
		/// </summary>
		protected string Name;
		
		/// <summary>
		/// Возраст.
		/// </summary>
		protected int Age;
		
		/// <summary>
		/// Пол.
		/// </summary>
		protected bool Male;

		/// <summary>
		/// Дополнительное поле - Фамилия.
		/// </summary>
		protected string Surname;

		/// <summary>
		/// Дополнительное поле - номер телефона.
		/// </summary>
		protected string Phone;
		#endregion

		#region Методы
		/// <summary>
		/// Вывод данных объекта.
		/// </summary>
		public void GetPersonData()
		{
			Console.WriteLine($"Имя:{Name}");
			Console.WriteLine($"Фамилия:{Surname}");
			Console.WriteLine($"Пол:{Male}");
			Console.WriteLine($"Возраст:{Age}");
			Console.WriteLine($"Номер телефона:{Phone}");
		}

		/// <summary>
		/// Функция специальных возможностей.
		/// </summary>
		public virtual void UseSpecialAbilities()
		{
			Console.WriteLine("Пока что нет специальных возможностей.");
		}
		#endregion

		#region Конструкторы, деструкторы

		/// <summary>
		/// Конструктор по умолчанию.
		/// </summary>
		public Person()
		{
			Name = "Без имени";
			Surname = "Без фамилии";
			Age = 0;
			Male = true;
			Phone = "";
		}

		/// <summary>
		/// Конструктор с аргументами.
		/// </summary>
		/// <param name="Name"></param>
		/// <param name="Surname"></param>
		/// <param name="Age"></param>
		/// <param name="Male"></param>
		/// <param name="Phone"></param>
		public Person(
			string Name,
			string Surname,
			int Age, 
			bool Male,
			string Phone)
		{
			this.Name = Name;
			this.Surname = Surname;
			this.Age = Age;
			this.Male = Male;
			this.Phone = Phone;
		}

		/// <summary>
		/// Деструктор.
		/// </summary>
		~Person()
		{
			Console.WriteLine("Этот парень был из тех," +
				" кто просто любит жизнь.");
		}
		#endregion

		#region Унаследовано от интерфейса
		/// <summary>
		/// Вычисление возраста по дате рождения.
		/// </summary>
		/// <param name="birthDate"></param>
		public void CalculateAge(DateTime birthDate)
		{
			Age = (DateTime.Now - birthDate).Days / 365;
		}

		/// <summary>
		/// Заниматься основной деятельностью (работой).
		/// Реализуем в классе ребенка и родителя.
		/// </summary>
		public abstract void CarryOutMainActivity();
		#endregion
	}
}
