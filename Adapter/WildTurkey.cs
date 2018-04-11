using System;

namespace ConsoleApp1.Adapter
{
    public class WildTurkey : ITurkey
    {
        public void Gobble()
        {
            Console.WriteLine("I'm gobbling");
        }

        public void Fly()
        {
            Console.WriteLine("I'm flying a short distance");
        }
    }
}