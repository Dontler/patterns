using Patterns.Lib.Proxy.Utils;

namespace Patterns.Lib.Proxy
{
    public class ProxyPresentation : IPresentation
    {
        public void Present()
        {
            var greatClass = InstantiateGreatClass();
            greatClass.PrintHelloWorld();
        }
        
        private IGreatInterface InstantiateGreatClass()
        {
            return new ImprovedGreatClass(new GreatClass());
        }
    }
}