using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    //Второй цикл выводит звездочку в один ряд
                    Console.Write("[*]");
                }
                //когда второй цикл заканчивается мы переносим следующую звездочку на следующую строку
                Console.WriteLine();
            }
        }
    }
}