using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.UsoltsevAD.Sprint4.Task2.V28.Lib;
namespace Tyuiu.UsoltsevAD.Sprint4.Task2.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();
            Console.Title = "Спринт #4 | Выполнил: Мальсагов У.А. | АСОиУб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Мальсагов Умар Асланович | АСОиУб-23-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Дан одномерный целочисленный массив на 12 элементов, заполненный        *");
            Console.WriteLine("* случайными числами в диапозоне от 2 до 9.                               *");
            Console.WriteLine("* Необходимо подсчитать сумму нечётных элементов массива.                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int[] array = new int[12];
            for (int i = 0; i < 12; i++)
            {
                array[i] = rnd.Next(2, 10);
            }
            Console.WriteLine("Получившийся массив:");
            foreach (int element in array)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Сумма нечётных элементов массива: {ds.Calculate(array)}");
            Console.ReadKey();
        }
    }
}
