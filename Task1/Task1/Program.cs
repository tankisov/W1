using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //создаю переменную типа инт, для первого числа. Число элементов в массиве
            int n = Convert.ToInt32(Console.ReadLine());
            //создаю массив, чтобы вбить в неё "n" чисел через
            int[] arr = new int[n];
            //циклом заполняю массив
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            //--------------------------
            int counter = 0;//счётчик количества простых чисел в массиве
            int[] newarr = new int[n];//новый массив, куда буду добавлять простые числа

            //цикл для проверки каждого числа в массиве на простоту
            for (int i = 0; i < n; i++)
            {
                int notprime = 0;
                if (arr[i] > 1)
                {
                    for (int j = 2; j < arr[i]; j++)
                    {
                        if (arr[i] % j != 0)
                        {
                            continue;
                        }
                        else { notprime++; }
                    }
                    if (notprime == 0)
                    {
                        newarr[counter] = arr[i];
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);//вывод количества простых чисел
            for (int i = 0; i < counter; i++)//вывод каждого простого числа циклом из массива
            {
                Console.Write(newarr[i] + " ");
            }
        }
    }
}