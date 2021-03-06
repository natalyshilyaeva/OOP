// Лабораторная работа 2
// Вариант 20
// Шиляева Наталья Сергеевна
// М8О-204Б-18
// 14.09.2019

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{

    class A
    {
        public A() { }
        ~A() { }

        public void mA() { Console.WriteLine("method of A"); }

        public B bA { get { Console.Write("get b ->"); return b; }
            //set { }
        }
        public C cA { get { Console.Write("get c ->"); return c; } }
        public J jA { get { Console.Write("get j ->"); return j; } }

        private B b = new B();
        private C c = new C();
        private J j = new J();
    }

    class B
    {
        public B() { }
        ~B() { }new 
        public void mB() { Console.WriteLine("  method of B"); }
        public K kA { get { Console.Write("get k -> "); return k; } }
        public D dA { get { Console.Write("get d -> "); return d; } }
        
        private K k = new K();
        private D d = new D();
        
        public int bi { set; get; }
    }

    class C
    {
        public C() { }
        ~C() { }
        public void mC() { Console.WriteLine("method of C"); }
      
        public E eA
        {
            get { Console.Write("get e ->"); return e; }
        }

        private E e = new E();
    }

    class J
    {
        public J() { }
        ~J() { }
        public void mJ() { Console.WriteLine(" method of J"); }

        public F fA
        {
            get { Console.Write("get f ->"); return f; }
        }

        private F f = new F();
    }

    class D
    {
        public D() { }
        ~D() { }
        public void mD() { Console.WriteLine(" method of D"); }
    }

    class E
    {
        public E() { }
        ~E() { }
        public void mE() { Console.WriteLine(" method of E"); }
    }

    class F
    {
        public F() { }
        ~F() { }
        public void mF() { Console.WriteLine(" method of F"); }
    }
       
    class K
    {
        public K() { }
        ~K() { }
        public void mK() { Console.WriteLine(" method of K"); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.mA();
            a.bA.mB();
            //a.bA=new B() вызовется set
            a.cA.mC();
            a.jA.mJ();

            a.bA.kA.mK();
            a.bA.dA.mD();

            a.cA.eA.mE();

            a.jA.fA.mF();
            Console.ReadKey();

        }
    }
}
