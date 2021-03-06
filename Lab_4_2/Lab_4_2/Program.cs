using System;
using System.Threading;

namespace Lab_4_2
{
    public interface IK
    {
        void mK();
    }

    public interface IE
    {
        void mE();
    }

    public interface IF
    {
        void mF();
    }

    class D
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
    }

    public interface IJ : IF
    {
        void mJ();
    }

    public interface IC : IE
    {
        void mC();
    }

    class B : D, IK
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

        // реализация метода интерфейса IK
        public void mK()
        {
            Console.WriteLine("Метод интерфейса K реализован в классе B");
        }
    }

    class A : B, IC, IJ
    {
        // конструктор
        public A()
        {
            Console.WriteLine("Конструктор класса A");
        }

        // деструктор
        ~A()
        {
            Console.WriteLine("Деструктор класса A");
            Thread.Sleep(400);
        }

        // метод A
        public void mA()
        {
            Console.WriteLine("Метод класса A");
        }

        // реализация метода интерфейса IC
        public void mC()
        {
            Console.WriteLine("Метод интерфейса C реализован в классе A");
        }

        // реализация метода интерфейса IJ
        public void mJ()
        {
            Console.WriteLine("Метод интерфейса J реализован в классе A");
        }

        // реализация метода интерфейса IE
        public void mE()
        {
            Console.WriteLine("Метод интерфейса E реализован в классе A");
        }

        // реализация метода интерфейса IF
        public void mF()
        {
            Console.WriteLine("Метод интерфейса F реализован в классе A");
        }
    }
                    
    class Program
    {
        static void Main(string[] args)
        {            
            // вызовы методов

            IE e = new A();     //создание ссылочной переменной е интерфейса IE класса A, которая реализует интерфейс IE
            e.mE();         //вызов метода интерфейса IE
            IC c = (IC)e;       //преобразование типа
            c.mC();
            //c.mE();
            
            A a = (A)c;
            a.mA();
            //IE x = (A)e;
            //a.mC();
            //a.mE();

            /*новый экземпляр класса A
            A a = new A();
            a.mK();
            a.mD();
            a.mE();
            a.mF();
            a.mB();
            a.mC();
            a.mJ();
            a.mA();*/

            Console.ReadKey();
        }
    }             
}

