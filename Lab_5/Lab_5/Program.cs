using System;
using System.Threading;

namespace Lab_5
{
    public interface IA
    {
        void ma();
    }

    public interface IC : IA
    {
        void m();
    }

    class B : IA
    {
        // метод класса B
        public void m()
        {
            Console.WriteLine("метод класса B");
        }

        public void ma()
        {
            Console.WriteLine();
        }
    }

    class D : B, IC
    {
        // реализация метода интерфейса IC
        void IC.m()
        {
            Console.WriteLine("метод интерфейса IC");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            D d = new D();      //создание ссылочной переменной d класса D, которая наследует класс D
            d.m();          //вызов метода класса D
            ((IC)d).m();        //преобразование типа, вызов метода

            Console.ReadKey();
        }
    }
}


