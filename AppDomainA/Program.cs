using System;

namespace AppDomainA
{
    class Program
    {
        static void Main(string[] args)
        {
            var appDomainB = AppDomain.CreateDomain("App Domain B",
                null,
                @"C:\Users\AAmer\source\repos\HandlingExceptions\AppDomainB\bin\Debug",
                "",
                false);
            try
            {
                appDomainB.ExecuteAssemblyByName("AppDomainB");
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
