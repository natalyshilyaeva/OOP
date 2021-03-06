using System;
using System.Threading;

namespace lab_55
{
    public interface IA
    {
        void mIA();
    }

    class B : IA
    {
        // конструктор
        public B()
        {
            Console.WriteLine("Конструктор класса B");
        }

        // деструктор
        ~B()
        {
            Console.WriteLine("Деструктор класса B");
            Thread.Sleep(400);
        }

        // метод B
        public void mB()
        {
            Console.WriteLine("Метод класса B");
        }

        // реализация метода интерфейса IA
        public void mIA()
        {
            Console.WriteLine("Метод интерфейса IA реализован в классе B");
        }
    }

    public interface IC : IA
    {
        void mIC();
    }

    class D : B, IC
    {
        // конструктор
        public D()
        {
            Console.WriteLine("Конструктор класса D");
        }
        // деструктор
        ~D()

        {
            Console.WriteLine("Деструктор класса D");
            Thread.Sleep(400);
        }

        // метод D
        public void mD()
        {
            Console.WriteLine("Метод класса D");
        }

        // реализация метода интерфейса IC
        public void mIC()
        {
            Console.WriteLine("Метод интерфейса IC реализован в классе D");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // новый экземпляр класса D
            D d = new D();

            // вызовы методов базовых классов и интерфейсов
            d.mIA();
            d.mIC();
            d.mB();
            d.mD();

            Console.ReadKey();
        }
    }
}
