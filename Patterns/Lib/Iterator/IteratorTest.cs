using System;
using Patterns.Lib.Iterator.Logger;

namespace Patterns.Lib.Iterator
{
    public static class IteratorTest
    {
        public static void Test()
        {
            var logger = LogGenerator();
            Console.WriteLine("Все логи:");
            foreach (var log in logger)
            {
                Console.WriteLine(log);
            }

            logger.SearchBy = LogType.Bad;
            Console.WriteLine("Плохие логи:");
            foreach (var log in logger)
            {
                Console.WriteLine(log);
            }

            logger.SearchBy = LogType.Good;
            Console.WriteLine("Хорошие логи:");
            foreach (var log in logger)
            {
                Console.WriteLine(log);
            }
        }

        private static GoodBadLogger LogGenerator()
        {
            var logger = new GoodBadLogger();
            logger.LoadLogs();
            var rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                var randomNumber = rand.Next(10);
                if (0 == randomNumber % 2)
                {
                    logger.WriteGoodLog("Сгенерировалось чётное число!");
                    continue;
                }
                logger.WriteBadLog("Сгенерировалось нечётное число!");
            }

            return logger;
        }
    }
}