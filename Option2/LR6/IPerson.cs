using System;

namespace LR6
{
	interface IPerson
	{
		/// <summary>
		/// Вычисление возраста по дате рождения.
		/// </summary>
		/// <param name="birthDate"></param>
		void CalculateAge(DateTime birthDate);

		/// <summary>
		/// Заниматься основной деятельностью (работой).
		/// </summary>
		void CarryOutMainActivity();
	}
}
