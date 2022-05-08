using System;

namespace LR9
{
	class Program
	{
		static void Main(string[] args)
		{
			Random random = new Random();

			/// Количество треугольников (К).
			int trianglesCount = 5;

			/// Среднняя площадь.
			double averageSquare = 0;

			/// Количество равносторонних треугольников (L).
			int eqtriangleCount = 4;

			EqualliteralTriangle equalliteral = 
				new EqualliteralTriangle(random.Next(100));

			/// Нахождение средней площади для К треугольников.
			for (int triangleNum = 1; 
				triangleNum < eqtriangleCount; 
				triangleNum++)
			{
				try
				{
					var newTriangle = new Triangle(
					random.Next(100),
					random.Next(100),
					random.Next(100));

					averageSquare += newTriangle.Square;
				}
				catch (Exception e)
				{
					Console.WriteLine(e.Message);
				}
			}

			for (int eqtNum = 0;
				eqtNum < trianglesCount;
				eqtNum++)
			{
				var newTriangle = new EqualliteralTriangle(random.Next(100));

				if (newTriangle.Square > equalliteral.Square)
				{
					equalliteral = newTriangle;
				}
			}

			Console.WriteLine(averageSquare / trianglesCount);

			Console.WriteLine("Наибольший равносторонний треугольник");
			equalliteral.GetTriangleOptions();
		}
	}
}
