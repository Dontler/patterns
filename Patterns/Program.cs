using System;
using Patterns.Lib;
using Patterns.Lib.AbstractFactory;
using Patterns.Lib.Factory;
using Patterns.Lib.Iterator;
using Patterns.Lib.Observer;
using Patterns.Lib.Proxy;
using Patterns.Lib.Singleton;

namespace Patterns
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "Patterns";
            var choose = "-1";
            while (choose != "0")
            {
                Console.Write("Выберите паттерн:\r\n1) Factory\r\n2) Abstract Factory\r\n" +
                              "3) Singleton\r\n4) Observer\n\r5) Iterator\r\n6) Proxy\r\n" +
                              "0) Выход.\r\n" +
                              "Выбор: ");
                choose = Console.ReadLine();
                switch (choose)
                {
                    case "1":
                        PresentPattern(new FactoryPresentation());
                        break;
                    case "2":
                        PresentPattern(new AbstractFactoryPresentation());
                        break;
                    case "3":
                        PresentPattern(new SingletonPresentation());
                        break;
                    case "4":
                        PresentPattern(new ObserverPresentation());
                        break;
                    case "5":
                        PresentPattern(new IteratorPresentation());
                        break;
                    case "6":
                        PresentPattern(new ProxyPresentation());
                        break;
                }
            }
        }

        private static void PresentPattern(IPresentation presentation)
        {
            presentation.Present();
        }
    }
}