using System;
using System.Collections.Generic;

namespace Lab_9
{
    class Program
    {
        // объявление делегата (T - тип значение, можно конвертировать в стандартные типы)
        delegate bool method<T>(T a) where T : struct, IConvertible;    
        
        // объявление нового метода Filter (статический, возвращает массив типа T)
        static T[] Filter<T>(T[] array, method<T> condition) where T : struct, IConvertible             
        {
            var temp = new List<T>();       // создаём новый список типа T
            foreach (T item in array)
            {
                if (condition(item)) 
                {
                    temp.Add(item);     // добавление элемента в список
                }
            }
            // преобразуем список в массив и возвращаем его 
            //(функция вернёт новый массив, в котором все элементы исходного удовлетворяют условию)
            return temp.ToArray();                  
        }

        static void Main(string[] args)
        {
            int[] array = { 45, 23, 899, 12, 12, 90 };
            Console.WriteLine("Изначальный: ");
            foreach (int el in array)
            {
                Console.Write("{0} ", el);
            }
            Console.WriteLine();

            var only_even = Filter<int>(array, x => x % 2 == 0);
            Console.WriteLine("Только чётные: ");
            foreach (int el in only_even)
            {
                Console.Write("{0} ", el);
            }
            Console.WriteLine();

            var only_odd = Filter<int>(array, x => x % 2 == 1);
            Console.WriteLine("Только нечётные: ");
            foreach (int el in only_odd)
            {
                Console.Write("{0} ", el);
            }
            Console.WriteLine();

            var from20to100 = Filter<int>(array, x => x >= 20 && x <= 100);
            Console.WriteLine("Только 20...100: ");
            foreach (int el in from20to100)
            {
                Console.Write("{0} ", el);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
