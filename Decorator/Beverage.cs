#define Logging
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Beverage
    {
        protected string Description = "Unknown beverage";

        public virtual string GetDescription()
        {
            return this.Description;
        }

        public abstract double Cost();
    }
}
