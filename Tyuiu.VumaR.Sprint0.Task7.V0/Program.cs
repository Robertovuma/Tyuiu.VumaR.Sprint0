
using Tyuiu.VumaR.Sprint0.Task7.V0.Lib;

namespace Tyuiu.VumaR.Sprint0.Task7.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #0 | Выполнил: Вума Р.Л | ИИПБ-24-2";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* спринт #0                                                              *");
            Console.WriteLine("* Тема: Сoздания итогового решения по спринту                             *");
            Console.WriteLine("Задание");
            Console.WriteLine("Вариант");
            Console.WriteLine("Выполнил: Вума Роберту Лазару  ИИПБ - 24 - 2");
            Console.WriteLine("******************************************************");
            Console.WriteLine("УСЛОВИЕ:");
            Console.WriteLine("* Написать консольную программу на C# , которая суммирует значения двух *");
            Console.WriteLine("одинаковых массивов по длине.");
            Console.WriteLine("*                                                                           *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                          *");
            Console.WriteLine("***************************************************************************");

            int[] arrayNums1 = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Значение элементов массива N1 ");
            for (int i = 0; i < arrayNums1.Length; i++)
            {
                Console.WriteLine(arrayNums1[i] + " , ");
            }

            Console.WriteLine();

            int[] arrayNums2 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Значение элементов массива N2 ");
            for (int i = 0; i < arrayNums2.Length; i++)
            {
                Console.Write(arrayNums2[i] + ",");
            }

            Console.WriteLine();
            Console.WriteLine("********************************************************************");
            Console.WriteLine("* Результат: *");
            Console.WriteLine("***************************************************************************");
            if (arrayNums1.Length == arrayNums2.Length)
            {
                int[] resultArray = DataService.AdditionArrays(arrayNums1, arrayNums2);

                Console.WriteLine("Сумма элементов массива равна:");
                for (int i = 0; i < resultArray.Length; i++)
                {
                    Console.Write(resultArray[i] + " , ");
                }
            }
            else
            {
                Console.WriteLine("ОШИБКА! ИСходные массивы имеют разное количество элементов");

            }
            Console.ReadKey();
        }
    }
    }
}
