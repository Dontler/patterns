namespace Patterns.Lib.AbstractFactory.Humans
{
    public class AmericanMother: Mother
    {
        public override Human GiveBirth()
        {
            return new AmericanHuman();
        }
    }
}