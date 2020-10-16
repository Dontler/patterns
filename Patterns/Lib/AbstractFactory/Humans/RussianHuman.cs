using System;

namespace Patterns.Lib.AbstractFactory.Humans
{
    public class RussianHuman: Human
    {
        public override string SayFirstWord()
        {
            return "Мама!";
        }
    }
}