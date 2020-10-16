using System;
using System.Collections.Generic;

namespace Patterns.Lib.Observer.RuTube
{
    public class Channel: IObservable<Video>
    {
        private readonly List<IObserver<Video>> _observers;
        private readonly List<Video> _videos;
        
        public string Name { get; }

        public Channel(string name)
        {
            _observers = new List<IObserver<Video>>();
            _videos = new List<Video>();
            Name = name;
        }
        
        public IDisposable Subscribe(IObserver<Video> observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);

                foreach (var video in _videos)
                {
                    observer.OnNext(video);
                }
            }
            
            return new Unsubscriber(_observers, observer);
        }

        public void PublishNewVideo(string videoName)
        {
            var video = new Video(videoName);
            _videos.Add(video);

            Console.WriteLine($"Прямо сейчас на канале \"{Name}\" вышло новое видео: \"{video.Name}\"");
            
            foreach (var observer in _observers)
            {
                observer.OnNext(video);
            }
        }

        public void DeleteChannel()
        {
            foreach (var observer in _observers)
            {
                observer.OnCompleted();
            }
            
            _observers.Clear();
        }
    }
}