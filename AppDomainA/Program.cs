using System;

namespace AppDomainA
{
    class Program
    {
        static void Main(string[] args)
        {
            var appDomainB = AppDomain.CreateDomain("App Domain B");
            appDomainB.ExecuteAssembly(@"C:\Users\AAmer\source\repos\HandlingExceptions\AppDomainB\bin\Debug\AppDomainB.exe");
        }
    }
}
