using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPZ_l1_v1.task3
{
    class Task3
    {
        private static string NeedTo = "Преобразовать массив так, чтобы в первой половине располагались элементы, стоявшие в четных позициях, а во второй половине - в нечетных.";
        public static void Test()
        {
            Console.WriteLine(NeedTo);
            bool a = int.TryParse(Console.ReadLine(), out int N);
            int[] arr = new int[N];
           
            int[] goodArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = i + 1;
            int t = 0;
            for(int i = 1 , j = 0; i < arr.Length; i+=2 , j++)
            {
                goodArr[j] = arr[i];
                t = j;
            }
            ++t;
            for (int i = 0, j = t; i < arr.Length; i += 2, j++)
            {
                goodArr[j ] = arr[i];
            }

            for (int i = 0; i < goodArr.Length; i++)
                Console.WriteLine(goodArr[i]);
        }
    }
}
