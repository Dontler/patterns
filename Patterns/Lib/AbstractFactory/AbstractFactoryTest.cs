using System;
using Patterns.Lib.AbstractFactory.Humans;

namespace Patterns.Lib.AbstractFactory
{
    public class AbstractFactoryTest
    {
        public static void Test()
        {
            var rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                var nationality = rand.Next(0, 2) == (int) Nationality.Russian ? Nationality.Russian : Nationality.American;
                var mother = GenerateMother(nationality);
                var human = mother.GiveBirth();
                Console.WriteLine(human.SayFirstWord());
            }
        }

        private static Mother GenerateMother(Nationality nationality)
        {
            switch (nationality)
            {
                case Nationality.American:
                    return new AmericanMother();
                case Nationality.Russian:
                    return new RussianMother();
                default:
                    throw new ArgumentException("Not supported entity type!");
            }
        }
    }
}