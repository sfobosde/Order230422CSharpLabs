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
				"Петров",
				"Николай",
				45,
				true,
				"89654754251",
				childrens);

			Parent mother = new Parent(
				"Петрова",
				"Татьяна",
				45,
				false,
				"89654778951",
				childrens);

			father.MarryOn(mother);
			mother.MarryOn(father);

			var parents = new List<Person>()
			{
				mother,
				father
			};

			children = new Children(
				"Петров",
				"Иванов",
				13,
				true,
				"89654728651",
				parents);

			children.GetPersonData();
			father.GetPersonData();
			mother.GetPersonData();

			children.UseSpecialAbilities();
			father.UseSpecialAbilities();
		}
	}
}
