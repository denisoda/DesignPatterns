using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Expresso : Beverage
    {
        public Expresso()
        {
            Description = "Expresso";
        }

        public override string GetDescription()
        {
            return this.Description;
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
}
