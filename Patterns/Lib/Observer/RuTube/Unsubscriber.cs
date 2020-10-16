using System;
using System.Collections.Generic;

namespace Patterns.Lib.Observer.RuTube
{
    public class Unsubscriber: IDisposable
    {
        private List<IObserver<Video>> _observers;
        private IObserver<Video> _observer;
        
        public Unsubscriber(List<IObserver<Video>> observers, IObserver<Video> observer)
        {
            _observer = observer;
            _observers = observers;
        }
        
        public void Dispose()
        {
            if (_observers.Contains(_observer))
            {
                _observers.Remove(_observer);
            }
        }
    }
}