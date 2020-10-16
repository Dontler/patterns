using Patterns.Lib.Observer.RuTube;

namespace Patterns.Lib.Observer
{
    public class ObserverTest
    {
        public static void Test()
        {
            var channel = new Channel("The First");
            var lyuba = new Subscriber();
            var mikhail = new Subscriber();

            lyuba.Subscribe(channel);
            mikhail.Subscribe(channel);
            
            channel.PublishNewVideo("The Time");
            mikhail.Unsubscribe();
            channel.PublishNewVideo("Let them talk");
            lyuba.ShowWatchedVideos();
            channel.DeleteChannel();
        }
    }
}