using System;

namespace Operation_with_Massive
{
    class Program
    {
        static void Main(string[] args)
        {
            // Найдем количество положительных элементов одномерного массива
            int[] array = { -1, 2, 3, -5, 6, 7, 8, -9, 10, -11, 11, 0 };
            int numbers = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    numbers++;
                }
            }
            Console.WriteLine("Число положительных элементов одномерного массива равно: {0}", numbers);

            // Найдем количество положительных элементов многомерного массива 
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            int temp = 0;
            // Перебор чере for
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > 0)
                    {
                        temp++;
                    }
                }

            }
            Console.WriteLine("Число положительных элементов многомерного массива равно: {0} (перебор через for)", temp);

            // Перебор чере foreach
            temp = 0;
            foreach (var item in arr)
            {
                if (item > 0)
                {
                    temp++;
                }
            }
            Console.WriteLine("                                                          {0} (перебор через foreach)", temp);

            // Выполним сортировку многомерного массива от меньшего элемента к большему
            int variable;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = j + 1; k < arr.GetLength(1); k++)
                    {
                        if (arr[i, j] > arr[i, k])
                        {
                            variable = arr[i, k];
                            arr[i, k] = arr[i, j];
                            arr[i, j] = variable;
                        }
                    }
                }
            }


            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int k = 0; k < arr.GetUpperBound(1) + 1; k++)
                {
                    Console.Write(arr[i, k] + " ");
                }

                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
