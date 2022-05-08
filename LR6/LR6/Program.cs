using System;

namespace LR6
{
	class Program
	{
		static void Main(string[] args)
		{
			Person person = new Person();
			person.GetPersonData();

			person = new Person("Иван",	"Иванов", 18,true, "89654728651");
			person.GetPersonData();
		}
	}
}
