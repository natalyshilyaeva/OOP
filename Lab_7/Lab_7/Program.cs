using System;

namespace Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Server s = new Server();
            Client c = new Client();

            c.m(s);
            c.u();
            Console.WriteLine(Utility.f());
            Console.ReadKey();
        }
    }

    class Server
    {
        public string f()
        {
            return "Server status: OK";
        }
    }

    static class Utility
    {
        public static string f()
        {
            return "Utility status: OK";
        }
    }

    class Client
    {
        public void m(Server u)
        {
            Console.WriteLine(u.f());
        }
        public void u()
        {
            Console.WriteLine(Utility.f());
        }
    }
}
