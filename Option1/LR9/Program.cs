using System;

namespace LR9
{
	class Program
	{
		static void Main(string[] args)
		{
			/// Количество квадратов (N).
			int squadCount = 5;

			/// Количество призм (M).
			int prismCount = 5;

			Random random = new Random();

			FindSquad(random, squadCount);
			FindPrism(random, prismCount);
		}

		static void FindPrism(Random random, int count)
		{
			var figure = new Prism(random.NextDouble(), random.NextDouble());
			figure.CalculateOptions();

			var findedFigure = figure;

			for (int prismNum = 1; prismNum < count; prismNum++)
			{
				figure = new Prism(random.NextDouble(), random.NextDouble());
				figure.CalculateOptions();

				if (findedFigure.GetCheckingParametrValue() 
					< figure.GetCheckingParametrValue())
				{
					findedFigure = figure;
				}
			}

			Console.WriteLine($"Призма с наибольшей диагональю:");
			findedFigure.GetSquadOptions();
		}

		static void FindSquad(Random random, int count)
		{
			var figure = new Squad(random.NextDouble());
			figure.CalculateOptions();

			var findedFigure = figure;

			for (int sqdNum = 1; sqdNum < count; sqdNum++)
			{
				figure = new Squad(random.NextDouble());
				figure.CalculateOptions();

				if (findedFigure.GetCheckingParametrValue()
					< figure.GetCheckingParametrValue())
				{
					findedFigure = figure;
				}
			}

			Console.WriteLine($"Квадрат с наибольшей площадью:");
			findedFigure.GetSquadOptions();
		}
	}
}
