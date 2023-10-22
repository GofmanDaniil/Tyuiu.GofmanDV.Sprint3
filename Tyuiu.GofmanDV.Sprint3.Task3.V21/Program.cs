using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GofmanDV.Sprint3.Task3.V21.Lib;

namespace Tyuiu.GofmanDV.Sprint3.Task3.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнила: Гофман Д. В. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнила: Гофман Даниил Викторович | СМАРТб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach заменить из строки все цифры 3 на e в строке:    *");
            Console.WriteLine("* f3g5ht g4j 34kg4                                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            string value = "f3g5ht g4j 34kg4";
            char item = '3';

            Console.WriteLine($"* Строка: {value}                                                        *");
            Console.WriteLine($"* Буква, которую нужно удалить: {item}                                   *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.ReplaceNumOnChar(value, item));
            Console.ReadKey();
        }
    }
}
