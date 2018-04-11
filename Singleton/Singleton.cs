namespace ConsoleApp1.Singleton
{
    public class Singleton
    {
        private static Singleton _uniqInstanse;

        private Singleton(){}

        public static Singleton GetInstanse()
        {
            return _uniqInstanse ?? (_uniqInstanse = new Singleton());
        }
    }
}