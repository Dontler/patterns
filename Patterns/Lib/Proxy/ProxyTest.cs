using Patterns.Lib.Proxy.Utils;

namespace Patterns.Lib.Proxy
{
    public static class ProxyTest
    {
        public static void Test()
        {
            var greatClass = InstantiateGreatClass();
            greatClass.PrintHelloWorld();
        }

        private static IGreatInterface InstantiateGreatClass()
        {
            return new ImprovedGreatClass(new GreatClass());
        }
    }
}