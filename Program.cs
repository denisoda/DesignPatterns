using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Adapter;
using ConsoleApp1.Singleton;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var duck = new MallardDuck();

            var turkey = new WildTurkey();
            
            IDuck turkeyAdapter = new TurkeyAdapter(turkey);
            
            TestDuck(turkeyAdapter);

            var uniqObject = Singleton.Singleton.GetInstanse();

        }

        public static void TestDuck(IDuck duck)
        {
            duck.Fly();
            duck.Quack();
        }
    }
}
