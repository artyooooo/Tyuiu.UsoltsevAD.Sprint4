﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.UsoltsevAD.Sprint4.Task1.V24.Lib;
namespace Tyuiu.UsoltsevAD.Sprint4.Task1.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Усольцев А.Д. | АСОиУб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Усольцев Артём Денисович | АСОиУб-23-2                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Дан одномерный целочисленный массив на 16 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапозоне от 0 до 9.                          *");
            Console.WriteLine("* Необходимо подсчитать произведение нечётных элементов массива.          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите количество элементов в массиве:");
            int lenght = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[lenght];
            for (int i = 0; i < lenght; i++)
            {
                Console.WriteLine($"Введите значение элемента массива под номером {i + 1}:");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Получившийся массив:");
            foreach (int element in array)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Произведение нечётных элементов массива: {ds.Calculate(array)}");
            Console.ReadKey();
        }
    }
}
