using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_4
{
    abstract class Figure
    {
        public Figure(string name)
        {
            this.name = name;
        }

        protected string name;

        // геттер для name
        public string Name => name;

        // абстрактные методы
        abstract public double Area();     // Площадь
        abstract public double Perimeter();     // Периметр
        abstract public void Inf();     //информация о фигуре
    }

    class Circle : Figure
    {
        // вызов конструктора базового класса
        public Circle(double radius) : base("Круг") 
        {
            this.radius = radius;
        }

        // свойство
        public double radius { get; set; }

        // переопределение абстрактных методов (виртуальные методы)
        public override double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }

        public override void Inf()
        {
            Console.WriteLine("Радиус = {0}", this.radius);
        }
    }

    class Rectangle : Figure
    {
        public Rectangle(double width, double height) : base("Прямоугольник")
        {
            this.width = width;
            this.height = height;
        }

        protected double width, height;

        public double Width
        {
            get => width;
            set => width = value;
        }

        public double Height
        {
            get => height;       //get { return height; }
            set => height = value; // set { height = value; }
        }

        public override double Area()
        {
            return width * height;
        }

        public override double Perimeter()
        {
            return 2 * width + 2 * height;
        }

        public double Diagonal()
        {
            return Math.Sqrt(width * width + height * height);
        }

        public override void Inf()
        {
            Console.WriteLine("Ширина={0}, Высота={1}", this.Width, this.Height);
        }
    }

    class Square : Rectangle
    {
        public Square(double a) : base(a, a)
        {
            name = "Квадрат";
        }

        public override double Area()
        {
            return base.Area();
        }

        public override double Perimeter()
        {
            return base.Perimeter();
        }

        public double N
        {
            get => base.height;
            set
            {
                base.width = value;
                base.height = value;
            }
        }

        public override void Inf()
        {
            Console.WriteLine("N={0}", this.N);
        }
    }

    class Triangle : Figure
    {
        public Triangle(double a, double b, double c) : base("Треугольник")
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }

        public override double Area()
        {
            double p = Perimeter();
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public override double Perimeter()
        {
            return a + b + c;
        }

        public override void Inf()
        {
            Console.WriteLine("A={0}, B={1}, C={2}", this.a, this.b, this.c);
        }
    }
   
    class EquilateralTriangle : Triangle
    {
        public EquilateralTriangle(double a) : base(a, a, a)
        {
            name = "Равносторонний треугольник";
        }
        
        public double N
        {
            get => base.a;
            set
            {
                base.a = value;
                base.b = value;
                base.c = value;
            }
        }

        public override void Inf()
        {
            Console.WriteLine("N={0}", this.N);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Figure[] i = new Figure[10];

            // инстанциация экземпляров классов (объектов)
            i[0] = new Circle(3);       // круг
            i[1] = new Circle(7);       // круг
            i[2] = new Rectangle(5, 8);       // прямоугольник
            i[3] = new Rectangle(5, 2);       // прямоугольник
            i[4] = new Square(2);       // квадрат
            i[5] = new Square(4);       // квадрат
            i[6] = new Triangle(1, 2, 3);     // треугольник
            i[7] = new Triangle(3, 4, 5);     // треугольник
            i[8] = new EquilateralTriangle(5);     // равносторонний треугольник
            i[9] = new EquilateralTriangle(10);      // равносторонний треугольник

            foreach (Figure f in i)       // цикл
            {
                Console.WriteLine(f.Name);
                f.Inf();

                // проверка типа 
                if (f is Circle)
                {
                    Console.WriteLine("Площадь={0}", ((Circle)f).Area());
                }

                else if (f is EquilateralTriangle)
                {
                    Console.WriteLine("Площадь={0}", ((EquilateralTriangle)f).Area());
                    Console.WriteLine("Периметр={0}", ((EquilateralTriangle)f).Perimeter());
                }

                else if (f is Triangle)
                {
                    Console.WriteLine("Периметр={0}", ((Triangle)f).Perimeter());
                }

                else if (f is Square)
                {
                    Console.WriteLine("Площадь={0}", ((Square)f).Area());
                    Console.WriteLine("Периметр={0}", ((Square)f).Perimeter());
                }

                else if (f is Rectangle)
                {
                    Console.WriteLine("Периметр={0}", ((Rectangle)f).Perimeter());
                    //Rectangle d = (Rectangle)f;
                    Console.WriteLine("Диагональ={0}", ((Rectangle)f).Diagonal());
                }

                //Console.WriteLine("Площадь={0}", f.Area());
                //Console.WriteLine("Периметр={0}", f.Perimeter());
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}