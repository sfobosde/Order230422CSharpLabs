using System;
using System.Collections.Generic;

namespace LR6
{
	class Program
	{
		static void Main(string[] args)
		{
			CreatePersons();
		}

		static void CreatePersons()
		{
			Children children = null;

			var childrens = new List<Children>()
			{
				children
			};

			Parent father = new Parent(
				"Николай",
				"Петров",
				0,
				true,
				"89654754251",
				childrens);

			Parent mother = new Parent(
				"Татьяна",
				"Петрова",
				0,
				false,
				"89654778951",
				childrens);

			father.CalculateAge(new DateTime(1968, 01, 15));
			mother.CalculateAge(new DateTime(1966, 04, 23));

			father.MarryOn(mother);
			mother.MarryOn(father);

			var parents = new List<Person>()
			{
				mother,
				father
			};

			children = new Children(
				"Иван",
				"Петров",
				0,
				true,
				"89654728651",
				parents);

			children.CalculateAge(new DateTime(2008, 02, 03));

			children.GetPersonData();
			father.GetPersonData();
			mother.GetPersonData();

			children.UseSpecialAbilities();
			father.UseSpecialAbilities();

			CarryOutMainActivity(new List<Person>
			{
				children,
				father,
				mother
			});
		}

		static void CarryOutMainActivity(List<Person> family)
		{
			foreach(var person in family)
			{
				person.CarryOutMainActivity();
			}
		}
	}
}
