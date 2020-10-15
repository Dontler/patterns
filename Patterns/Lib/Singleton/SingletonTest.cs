using System;

namespace Patterns.Lib.Singleton
{
    public class SingletonTest
    {
        public static void Test()
        {
            var entity = Entity.GetInstance();
            Console.WriteLine(entity.Message);
            var anotherEntity = Entity.GetInstance();
            anotherEntity.Message = "Это сообщение повторится дважды.";
            Console.WriteLine(anotherEntity.Message);
            Console.WriteLine(entity.Message);
        }
    }
}