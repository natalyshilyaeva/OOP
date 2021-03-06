using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Deque<T>
    {
        public Deque()      // конструктор
        {
            this.N = 100;       // количество элементов
            this.body = new T[N];     //тело
            this.head = 0;      // голова
            this.tail = 0;      // хвост
            this.size = 0;      // размер
        }

        ~Deque() { }       // деструктор

        public int Size()       // нахождение размера
        {
            return this.size;
        }

        public void PushFront(T value)      // добавление нового элемента в начало дека
        {
            if (this.size == this.N)
                Console.WriteLine("ДЕК ПЕРЕПОЛНЕН");
            else
            {
                this.head = (this.head - 1 + this.N) % this.N;
                this.body[this.head] = value;
                this.size++;
            }
        }

        public void PushBack(T value)       // добавдение нового элемента в конец дека
        {
            if (this.size == this.N)
                Console.WriteLine("ДЕК ПЕРЕПОЛНЕН");
            else
            {
                this.body[this.tail] = value;
                this.tail = (this.tail + 1) % this.N;
                this.size++;
            }
        }

        public T PopFront()         // извлечение из дека первого элемента
        {
            if (Empty())    // проверка на пустоту
            {
                Console.WriteLine("ДЕК ПУСТ");
                return default(T);
            }
            else
            {
                T x = this.body[this.head];
                this.head = (this.head + 1) % this.N;
                this.size--;
                return x;
            }
        }

        public T PopBack()          // извлечение из дека последнего элемента
        {
            if (Empty())
            {
                Console.WriteLine("ДЕК ПУСТ");
                return default(T);
            }
            else
            {
                this.tail = (this.tail - 1 + this.N) % this.N;
                T x = this.body[this.tail];
                this.size--;
                return x;
            }
        }

        public void Display()       // вывод на экран
        {
            Console.WriteLine();
            Console.Write("[ ");
            int i = this.head;
            while (i != this.tail)
            {
                Console.Write("{0} ", this.body[i]);
                i = (i + 1) % this.N;
            }
            Console.Write("]");
            Console.WriteLine();
        }

        private bool Empty()    // проверка на пустоту
        {
            return this.head == this.tail;
        }

        private T[] body = null;
        private int N;
        private int head;
        private int tail;
        private int size;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int N, i, x;
            char c;
            string str;

            Console.Write("Введите размер дека: ");

            N = Convert.ToInt32(Console.ReadLine());

            Deque<int> deque = new Deque<int>();

            for (i = 0; i < N; i++)
            {
                Console.Write("Введите место добавления (h - head, t - tail): ");
                c = Convert.ToChar(Console.ReadLine());
                if (c == 'h')
                {
                    Console.Write("Введите добавляемый элемент: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    deque.PushFront(x);
                }
                else
                {
                    Console.Write("Введите добавляемый элемент: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    deque.PushBack(x);
                }
            }

            deque.Display();
            Console.WriteLine("Размер deque: {0}", deque.Size());
            deque.PopBack();
            deque.Display();
            deque.PopFront();
            deque.Display();
            Console.WriteLine("Размер deque: {0}", deque.Size());
            Console.WriteLine("--------------------");
            Console.ReadKey();

            Deque<string> sdeque = new Deque<string>();
            Console.WriteLine("Размер sdeque: {0}", sdeque.Size());
            sdeque.PopFront();
            Console.Write("Введите добавляемый элемент: ");
            str = Convert.ToString(Console.ReadLine());
            sdeque.PushBack(str);
            sdeque.Display();
            Console.Write("Введите добавляемый элемент: ");
            str = Convert.ToString(Console.ReadLine());
            sdeque.PushBack(str);
            sdeque.Display();
            Console.Write("Введите добавляемый элемент: ");
            str = Convert.ToString(Console.ReadLine());
            sdeque.PushFront(str);
            sdeque.Display();

            Console.ReadKey();
        }
    }
}
