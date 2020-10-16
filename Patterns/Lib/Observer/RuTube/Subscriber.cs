using System;
using System.Collections.Generic;

namespace Patterns.Lib.Observer.RuTube
{
    public class Subscriber: IObserver<Video>
    {
        private List<Video> _watchedVideos;

        private IDisposable _disposable;

        public Subscriber()
        {
            _watchedVideos = new List<Video>();
        }

        public virtual void Subscribe(Channel channel)
        {
            _disposable = channel.Subscribe(this);
            Console.WriteLine($"Я подписался на канал \"{channel.Name}\".");
        }
        
        public void OnNext(Video video)
        {
            if (!_watchedVideos.Contains(video))
            {
                _watchedVideos.Add(video);
                Console.WriteLine($"Я только что посмотрел новое видео: \"{video.Name}\"");
                return;
            }

            Console.WriteLine($"Я пересмотрел старое видео: \"{video.Name}\"");
        }

        public void OnError(Exception error)
        {
            // Not used in Channel.
            throw new NotImplementedException();
        }

        public void Unsubscribe()
        {
            _disposable.Dispose();
        }

        public void OnCompleted()
        {
            Console.WriteLine($"Канал был удалён. Мне пришлось от него отписаться :(");
        }

        public void ShowWatchedVideos()
        {
            foreach (var watchedVideo in _watchedVideos)
            {
                Console.WriteLine($"\"{watchedVideo.Name}\"");
            }
        }
    }
}