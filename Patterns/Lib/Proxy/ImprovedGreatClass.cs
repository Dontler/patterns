using Patterns.Lib.Iterator.Logger;
using Patterns.Lib.Proxy.Utils;

namespace Patterns.Lib.Proxy
{
    public class ImprovedGreatClass: IGreatInterface
    {
        private readonly GreatClass _greatClass;
        private readonly GoodBadLogger _logger;

        public ImprovedGreatClass(GreatClass greatClass)
        {
            _greatClass = greatClass;
            _logger = new GoodBadLogger();;
            _logger.LoadLogs();
        }
        
        public void PrintHelloWorld()
        {
            _logger.WriteGoodLog("Был вызван метод PrintHelloWorld");
            
            _greatClass.PrintHelloWorld();
        }
    }
}