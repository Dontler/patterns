using System;

namespace Patterns.Lib.Proxy.Utils
{
    public class GreatClass: IGreatInterface
    {
        public void PrintHelloWorld()
        {
            Console.WriteLine("Hello, world!");
        }
    }
}