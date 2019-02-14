using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());// массив из n чисел 
            int[] arr = new int[n]; // создал новый массив
            for(int i=0; i < n; i++) 
            {
                arr [i] = Convert.ToInt32(Console.ReadLine()); // заполняю массив числами
            }
            //-------------------------------------------------
            int[] arr1 = new int[n];
            int b = 0;
            for (int i=0;i<n;i++)
            {
                int cnt = 0;
                if (arr[i] > 1)
                {
                    for(int j = 2; j < arr[i]; i++)
                    {
                        if(arr[i] % j != 0)
                        {
                            continue;
                        }
                        else {
                            cnt++;
                        }
                        if (cnt == 0)
                        {
                            arr1[b] = arr[i];
                            b++;
                        }
                    }
                }
            }
            Console.WriteLine(b);
            for(int i =0; i < b; i++)
            {
                Console.WriteLine(arr1[i]);

            }
            


                
        }
        
    }
}
