using System;

namespace Z
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.Write("m = ");
            int m = Int32.Parse(Console.ReadLine());
            Console.Write("n = ");
            int n = Int32.Parse(Console.ReadLine());
            int[,] a = new int[m, n];
            Random rd = new Random();
            Console.WriteLine("Заданный массив:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = rd.Next(-99, 100);
                    Console.Write("{0,5}", a[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Укажите позиции (индексы строки и столбца) элемента матрицы:");
            Console.Write("   строка: ");
            int r = Int32.Parse(Console.ReadLine());
            Console.Write("   столбец: ");
            int c = Int32.Parse(Console.ReadLine());
            if (r < 1 || r > m || c < 1 || c > n)
            {
                Console.WriteLine("Некорректный индекс");
            }
            else
            {
                Console.WriteLine("[{0}, {1}] -> {2}", r, c, a[r - 1, c - 1]);
            }
            Console.ReadKey();
        }
    }
}