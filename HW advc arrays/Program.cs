using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_advc_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
			#region ex2
			/*
			//creating an array of 10 random numbers.
			int[] arr = new int[10];
			Random rnd = new Random();

			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = rnd.Next(1, 11);
			}

			//the player has to guess the numbers while we count the attempts.
			int sum = 0;
			bool game_over = false;
			for (int i = 0; i < arr.Length; i++)
			{
				int user_input, count = 0;
				do
				{
					Console.Write($"Enter your guess (1-10) for place {i + 1}: ");
					user_input = int.Parse(Console.ReadLine());
					count++;

					if (count == 30)
					{
						game_over = true;
						Console.WriteLine("the game is over!");
						break;
					}

				} while (user_input != arr[i]);
				if (game_over)
				{
					break;
				}
				Console.WriteLine($"Correct answer, took you {count} attempts.");
				sum += count;
			}
			if (!game_over)
			{
				Console.WriteLine($"done! all attempts: {sum}.");
			}

			Console.WriteLine();
			*/
			#endregion

			#region ex3
			/*
			int [,] TD_arr = new int [5, 5];
			Random rnd = new Random();
			for (int i = 0; i < TD_arr.GetLength(0); i++)
			{
				for (int j = 0; j < TD_arr.GetLength(1); j++)
				{
					TD_arr[i, j] = rnd.Next(1, 11);
				}
			}
			while (true)
			{
				Console.Write("Enter your guess (1-10) or Q to quit: ");
				int guess;
				bool quit = !int.TryParse(Console.ReadLine(), out guess);
				if (quit)
				{
					break;
				}
				string index = null;
				for (int i = 0; i < TD_arr.GetLength(0); i++)
				{
					for (int j = 0; j < TD_arr.GetLength(1); j++)
					{
						if (guess == TD_arr[i, j])
						{
							index = $"({i}, {j})";
							break;
						}
					}
					if (index != null)
					{
						Console.WriteLine($"number found at {index}.");
						break;
					}
				}
			}
			*/
			#endregion

			#region ex4
			/*
			int[,] mul_tab = new int[10, 10];
			for (int i = 0; i < mul_tab.GetLength(0); i++)
			{
				for (int j = 0; j < mul_tab.GetLength(1); j++)
				{
					mul_tab[i, j] = (i + 1) * (j + 1);
				}
			}

			for (int i = 0; i < mul_tab.GetLength(0); i++)
			{
				for (int j = 0; j < mul_tab.GetLength(1); j++)
				{
					Console.Write($"{mul_tab[i, j], -4}");
				}
				Console.WriteLine();
			}
			*/
			#endregion

			#region ex6
			/*
			int[,,] arr = new int[2, 2, 2];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        Console.Write($"Enter a number for position ({i}, {j}, {k}): ");
						arr[i, j, k] = int.Parse(Console.ReadLine());
                    }
                }
            }

			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					for (int k = 0; k < arr.GetLength(2); k++)
					{
						Console.Write($"{arr[i, j, k], 4}");
					}
                    Console.WriteLine();
				}
                Console.WriteLine();
			}
			*/
			#endregion

			#region ex7
			/*
			int[,] arr = new int[6, 4];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
			*/
			#endregion
			
			#region ex8
			/*
			Random rnd = new Random();
			int[][] jag_arr = new int[rnd.Next(2, 7)][];
            for (int i = 0; i < jag_arr.Length; i++)
            {
				int[] sub = new int[rnd.Next(2, 10)];
				jag_arr[i] = sub;
            }

			for (int i = 0; i < jag_arr.Length; i++)
			{
				for (int j = 0; j < jag_arr[i].Length; j++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
			*/
			#endregion


			Console.WriteLine("Press any key to close...");
			Console.ReadKey();

			//by: t.me/yehuda100
		}
	}
}
