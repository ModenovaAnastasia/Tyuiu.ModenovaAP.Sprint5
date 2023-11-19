using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ModenovaAP.Sprint5.Task1.V18.Lib;

namespace Tyuiu.ModenovaAP.Sprint5.Task1.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Моденова А. П. | ИИПб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнила: Моденова Анастасия Павловна | ИИПб-23-3                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция, F(x) = 3x+2 - (2*x-x)/(cos(x)+1)(произвести табулирование)*");
            Console.WriteLine("* f(x) на заданном диапазоне [-5;5] с шагом 1ю Произвести проверку деле - *");
            Console.WriteLine("* ния на ноль. При деление на ноль вернуть значение 0. Результат сохранить*");
            Console.WriteLine("* в текстовый файл OutPutFileTask1.txt и вывести на консоль в таблицу.    *");
            Console.WriteLine("* Значение округлить до двух знаков после запятой.*");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);


            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string result = ds.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine("Файл: " + result);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
