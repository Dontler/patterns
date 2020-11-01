namespace Patterns.Lib.Prototype.Geometric
{
    public interface IFigure
    {
        IFigure Clone();

        IFigure DeepClone();
        
        string GetPrintableInfo();
    }
}