namespace Patterns.Lib.Singleton
{
    public class Entity
    {
        private static Entity _instance;

        public string Message { get; set; }

        private Entity()
        {
            Message = "Это стандартное сообщение!";
        }

        public static Entity GetInstance()
        {
            return _instance ?? (_instance = new Entity());
        }
    }
}