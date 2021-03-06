// Лабораторная работа 1
// Вариант 20
// Шиляева Наталья Сергеевна
// М8О-204Б-18
// 07.09.2019

using System;

namespace Lab_1 
{
    class Program
    {
        static void Main(string[] args)
        {
            // инстанциация экземпляров классов
            var k = new K();
            var d = new D();
            var e = new E();
            var f = new F();

            var j = new J(f);
            var b = new B(k, d);
            var c = new C(e);
            
            var a = new A(b, c, j);

            // вызовы методов объектов
            a.B.K.print();
            a.B.D.print();
            a.C.E.print();
            a.J.F.print();

            a.B.print();
            a.C.print();
            a.J.print();

            a.print();

            // чтобы окно не закрылось
            Console.ReadKey();
        }
    }

    class A
    {
        // конструктор
        public A(B b, C c, J j)
        {
            this.b = b;
            this.c = c;
            this.j = j;
        }

        // метод класса
        public void print()
        {
            Console.WriteLine("Hi, I'm A!");
        }

        // геттеры и сеттеры для приватных полей
        public B B
        {
            set
            {
                Console.WriteLine("A.B set");
                b = value;
            }
            get
            {
                Console.WriteLine("A.B get");
                return b;
            }
        }

        public C C
        {
            set
            {
                Console.WriteLine("A.C set");
                c = value;
            }
            get
            {
                Console.WriteLine("A.C get");
                return c;
            }
        }

        public J J
        {
            set
            {
                Console.WriteLine("A.J set");
                j = value;
            }
            get
            {
                Console.WriteLine("A.J get");
                return j;
            }
        }

        private B b = null;
        private C c = null;
        private J j = null;
    }

    class B
    {
        // конструктор
        public B(K k , D d)
        {
            this.k = k;
            this.d = d;            
        }

        // метод класса
        public void print()
        {
            Console.WriteLine("Hi, I'm B!");
        }

        // геттеры и сеттеры для приватных полей
        public K K
        {
            set
            {
                Console.WriteLine("B.K set");
                k = value;
            }
            get
            {
                Console.WriteLine("B.K get");
                return k;
            }
        }

        public D D
        {
            set
            {
                Console.WriteLine("B.D set");
                d = value;
            }
            get
            {
                Console.WriteLine("B.D get");
                return d;
            }
        }

        private K k = null;
        private D d = null;        
    }

    class C
    {
        // конструктор
        public C(E e)
        {
            this.e = e;            
        }

        // метод класса
        public void print()
        {
            Console.WriteLine("Hi, I'm C!");
        }

        // геттеры и сеттеры для приватных полей
        public E E
        {
            set
            {
                Console.WriteLine("C.E set");
                e = value;
            }
            get
            {
                Console.WriteLine("C.E get");
                return e;
            }
        }
                
        private E e = null;        
    }

    class J
    {
        // конструктор
        public J(F f)
        {
            this.f = f;
        }

        // метод класса
        public void print()
        {
            Console.WriteLine("Hi, I'm J!");
        }

        // геттеры и сеттеры для приватных полей
        public F F
        {
            set
            {
                Console.WriteLine("C.F set");
                f = value;
            }
            get
            {
                Console.WriteLine("C.F get");
                return f;
            }
        }

        private F f = null;
    }

    class K
    {
        // метод класса
        public void print()
        {
            Console.WriteLine("Hi, I'm K!");
        }
    }

    class D
    {
        // метод класса
        public void print()
        {
            Console.WriteLine("Hi, I'm D!");
        }
    }

    class E
    {
        // метод класса
        public void print()
        {
            Console.WriteLine("Hi, I'm E!");
        }
    }

    class F
    {
        // метод класса
        public void print()
        {
            Console.WriteLine("Hi, I'm F!");
        }
    }
        
}
 