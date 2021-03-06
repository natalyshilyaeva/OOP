using System;

namespace Lab_6
{
    class A
    {
        public A()
        {
            Console.WriteLine("Конструктор A");
        }
        public B B { set; get; }     // свойство класса B (можно читать и писать)

        public void print()
        {
            Console.WriteLine("Метод A");
        }
    }

    class B
    {
        public B()
        {
            Console.WriteLine("Конструктор B");
        }
        public A A { set; get; }    // свойство класса A (можно читать и писать)

        public void print()
        {
            Console.WriteLine("Метод B");
        }
    }

    class C
    {
        private int n;
        private D[] d;      // массив ссылок на объекты класса D

        public C(int n = 5)
        {
            Console.WriteLine("Конструктор C");
            this.n = n;     // присваиваем полю n значение n
            this.d = new D[n];      // создаём массив длины n
        }

        private int used = 0;       // индекс следующего элемента массива

        public void Add(D value)    // метод добавления элементов в массив
        {
            if (used < n)
            {
                this.d[used] = value;
                used++;
            }
        }

        public D GetByIndex(int i)      // метод возвращения элементов массива по индексу
        {
            if (i < used)
            {
                return d[i];
            }
            return null;
        }

        public void print()
        {
            Console.WriteLine("Метод C; n = {0}", n);
        }
    }

    class D
    {
        public C C { get; set; } // // свойство класса C (можно читать и писать)
        public D(C c = null)    // конструктор (если не передаётся ссылка на C, то считаем её равной null) 
        {
            Console.WriteLine("Конструктор D");
            this.C = c;         // присваивание переданной ссылки в поле типа C 
            if (c != null)
            {
                c.Add(this);     // добавляем данный экземпляр класса D во внутренний массив объекта класса C 
            }
        }

        public void print()
        {
            Console.WriteLine("Метод D");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 1 : 1
            A a = new A();
            B b = new B();    //в классе A есть поле под ссылку на экземпляр класса B 
            a.B = b;    // в ссылку на экземпляр класса B присваиваем ссылку на экземпляр класса B
            b.A = a;
            a.B.print();    // вызов методов
            b.A.print();

            // 1 : N
            C c1 = new C(23);   // создание объектов
            C c2 = new C();
            D d1 = new D();
            D d2 = new D(c2);
            c1.Add(d1);     // добавляем объекты класса D во внутренний массив класса C
            c1.Add(d2);
            d1.C = c1;      //в ссылку на экземпляр класса C присваиваем ссылку на экземпляр класса C 
            d1.C.GetByIndex(0).print();     // вызов метода нулевого элемента массива
            c1.GetByIndex(1).print();       // вызов метода первого элемента массива

            d1.C.print();  // вызов метода класса C
            d2.C.print();

            Console.ReadKey();
        }
    }
}

