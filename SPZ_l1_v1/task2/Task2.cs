using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPZ_l1_v1.task2
{
    class Task2
    {
        private static string NeedTo = "Даны два целых числа: D (день) и M (месяц), определяющие правильную дату невисокосного года. Вывести значения D и M для даты, предшествующей указанной. Если пользователь вводит D и M несоответствующие календарю - выдать сообщение об ошибке. ";
        public static void Test()
        {
            Console.WriteLine(NeedTo);
            while (true)
            {
                Console.WriteLine("Enter day");
                bool t = Int32.TryParse(Console.ReadLine(), out int d);
                if (!t)
                    break;
                Console.WriteLine("Enter mounth");
                bool t2 = Int32.TryParse(Console.ReadLine(), out int m);
                if (!t2)
                    break;
                if (!t || !t2 || m > 12 || m < 1 || d < 1 || d > 31)
                    Console.WriteLine("Mistake");
                else
                {
                    switch (m)
                    {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                        case 12:
                            if (d == 31)
                                Console.WriteLine("Correct");
                            else Console.WriteLine("Uncorrect");
                            break;
                        case 2:
                            if (d == 29 || d == 28)
                                Console.WriteLine("Correct");
                            else Console.WriteLine("Uncorrect");
                            break;
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            if (d == 30)
                                Console.WriteLine("Correct");
                            else Console.WriteLine("Uncorrect");
                            break;
                    }
                }
            }
        }
    }
}
