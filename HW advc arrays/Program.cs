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

            #region ex5
            /*
            int[,] arr = new int[3, 3];
            Random rnd = new Random();
            int count = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (rnd.Next(0, 2) == 1)
                    {
                        arr[i, j] = 1;
                        count++;
                    }
                }
            }

            int attempts = 0;
            while (count > 0)
            {
                Console.Write("Enter index (1-3), (1-3): ");
				int x = (Console.ReadKey().KeyChar - '0') -1;
                Console.Write(", ");
				int y = (Console.ReadKey().KeyChar - '0') - 1;
				if (arr[x, y] == 1)
                {
                    Console.WriteLine("  Boom!");
					count--;
					attempts++;
					arr[x, y] = 0;
                }
				else
                {
                    Console.WriteLine("  Miss...");
					attempts++;
                }
			}
            Console.WriteLine($"\nyou tried {attempts} times.");
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

            #region ex9
			/*
            Console.Write("Enter number of classes: ");
			int classes = int.Parse(Console.ReadLine());
			int[][] scool = new int[classes][];
            for (int i = 0; i < scool.Length; i++)
            {
                Console.Write($"Enter the number of studnts in class {i+1}: ");
				int students = int.Parse(Console.ReadLine());
				scool[i] = new int[students];
            }

			for (int i = 0; i < scool.Length; i++)
			{
				for (int j = 0; j < scool[i].Length; j++)
				{
					Console.Write($"Enter the grades for student {j+1} in class {i+1}: ");
					scool[i][j] = int.Parse(Console.ReadLine());
				}
				Console.WriteLine();
			}

			float high_avg = 0;
			int win_class = -1;
            for (int i = 0; i < scool.Length; i++)
            {
				float avg = scool[i].Sum() / (float)scool[i].Length;
				if (avg > high_avg)
                {
					high_avg = avg;
					win_class = i;
                }
            }
            Console.WriteLine($"\nthe highst average grade is in class {win_class +1}. ({high_avg})");
			*/
			#endregion

			Console.WriteLine("Press any key to close...");
            Console.ReadKey();

            //by: t.me/yehuda100
			//test
        }
    }
}
