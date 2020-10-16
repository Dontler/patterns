using System;
using Patterns.Lib.AbstractFactory;
using Patterns.Lib.Factory;
using Patterns.Lib.Observer;
using Patterns.Lib.Singleton;

namespace Patterns
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var choose = "-1";
            while (choose != "0")
            {
                Console.Write("Выберите паттерн:\r\n1) Factory\r\n2) Abstract Factory\r\n" +
                              "3) Singleton\r\n4) Observer\n\r" +
                              "0) Выход.\r\n" +
                              "Выбор: ");
                choose = Console.ReadLine();
                switch (choose)
                {
                    case "1":
                        FactoryTest.Test();
                        break;
                    case "2":
                        AbstractFactoryTest.Test();
                        break;
                    case "3":
                        SingletonTest.Test();
                        break;
                    case "4":
                        ObserverTest.Test();
                        break;
                }
            }
        }
    }
}