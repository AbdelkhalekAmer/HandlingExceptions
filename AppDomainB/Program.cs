using System;

namespace AppDomainB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            HandleData();
        }
        static void HandleData()
        {
            throw new NotImplementedException();
        }
    }
}
