using System;

namespace project2
{
    class Program
    {
        public static int Main()
        {
            Console.Write("Введіть кінець діапазону для виведення ряду Фібоначчі від 1 до : ");
            int end = int.Parse(Console.ReadLine());
            int j = 1;
            for (int k = 1; k <= end; k += j)
            {
                Console.Write("{0} ", k);
                j = k - j;
            }
            Console.ReadKey();
            return 0;
        }
    }
}
