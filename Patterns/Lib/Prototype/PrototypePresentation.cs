using System;
using Patterns.Lib.Prototype.Geometric;

namespace Patterns.Lib.Prototype
{
    public class PrototypePresentation : IPresentation
    {
        public void Present()
        {
            var originalCircle = new Circle(10, 0, 0);
            Console.WriteLine($"Original circle info: {originalCircle.GetPrintableInfo()}");
            var clonedCircle = originalCircle.Clone();
            Console.WriteLine($"Cloned circle info: {clonedCircle.GetPrintableInfo()}");
            var deepClonedCircle = originalCircle.DeepClone();
            Console.WriteLine($"Deep cloned circle info: {deepClonedCircle.GetPrintableInfo()}");
            
            originalCircle.Center.X = 10;
            Console.WriteLine($"Original circle after changing center point: {originalCircle.GetPrintableInfo()}");
            Console.WriteLine(
                $"Cloned circle after changing center point of original object: {clonedCircle.GetPrintableInfo()}"
            );
            Console.WriteLine(
                $"Deep cloned circle after changing center point of original object: {deepClonedCircle.GetPrintableInfo()}"
            );
        }
    }
}