using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.UsoltsevAD.Sprint4.Task0.V11.Lib;
namespace Tyuiu.UsoltsevAD.Sprint4.Task0.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[] array = new int[] { 8, 9, 5, 4, 3, 2, 1, 0, 5, 7 };
            Console.Title = "Спринт #4 | Выполнил: Усольцев А.Д. | АСОиУб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Усольцев Артём Денисович | АСОиУб-23-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапозоне от 0 до 9.                          *");
            Console.WriteLine("* Необходимо подсчитать произведение нечётных элементов массива.          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Исходный массив:");
            foreach (int element in array)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Произведение нечётных элементов массива: {ds.GetMultOddArrEl(array)}");
            Console.ReadKey();
        }
    }
}
