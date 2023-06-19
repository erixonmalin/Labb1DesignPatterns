using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1DesignPatterns
{
    //STRATEGY pattern
    public class Restaurant
    {
        private IGreetingStrategy greetingStrategy;

        public Restaurant(IGreetingStrategy greetingStrategy)
        {
            this.greetingStrategy = greetingStrategy;
        }

        public void SetGreetingStrategy(IGreetingStrategy greetingStrategy)
        {
            this.greetingStrategy = greetingStrategy;
        }

        public string GreetCustomer()
        {
            return greetingStrategy.Greet();
        }
    }
}
