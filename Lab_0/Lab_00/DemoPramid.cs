/*
   Дисциплина:  ИСРППС
   Группа:      8О-204Б
   Студент:     Шиляева Наталья Сергеевна
   Задача:      
		        Вычисление площади пирамиды и объёма пирамиды по заданному радиусу
   Дата:        06.09.19
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_00
{
    class DemoPyramid
    {
        public static void Main()
    {


        double sosn,        // площадь основания
               sbok,        // площадь боковая
               h,           // высота
               s,        	// Площадь пирамиды
               v;        	// Объём пирамиды
        char rep;      	// Признак повтора вычислений
        // 	Y или y - повторное выполнение,
        // 	любой другой символ - окончание
        do
        {
            Console.Write("Введите площадь основания: ");
            sosn = double.Parse(Console.ReadLine());  	//Читаем площадь основания
            Console.Write("Введите боковую площадь: ");
            sbok = double.Parse(Console.ReadLine());  	//Читаем боковую площадь
            Console.Write("Введите высоту: ");
            h = double.Parse(Console.ReadLine());  	//Читаем высоту

            Pyramid C = new Pyramid(sosn, sbok, h);
                      
            s = C.Area_Pyramid();                   		//Вычисляем площадь
            v = C.Volume_Pyramid();              		//Вычисляем длину

            Console.WriteLine("Площадь=" + s + "  Объём=" + v);

            C.InfoPyramid();                             // вывод информации об объекте

            Console.Write("Для повтора вычислений нажмите клавишу Y: ");
            rep = char.Parse(Console.ReadLine()); 	 //Вводим признак завершения
            Console.WriteLine();

        } while (rep == 'Y' || rep == 'y');

    } 	  //Конец определения метода
} 	//Конец объявления класса
}
