namespace Patterns.Lib.AbstractFactory.Humans
{
    public class RussianMother: Mother
    {
        public override Human GiveBirth()
        {
            return new RussianHuman();
        }
    }
}