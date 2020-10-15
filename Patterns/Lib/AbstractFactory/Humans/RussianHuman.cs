using System;

namespace Patterns.Lib.AbstractFactory.Humans
{
    public class RussianHuman: Human
    {
        public override string FirstWord()
        {
            return "Мама!";
        }
    }
}