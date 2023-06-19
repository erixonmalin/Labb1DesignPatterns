using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1DesignPatterns
{
    //STRATEGY pattern
    //Konkret implementering av vänlig hälsningsstrategi
    public class FriendlyGreetingStrategy : IGreetingStrategy
    {
        public string Greet()
        {
            return "Välkommen till restaurangen! Hur kan jag hjälpa dig idag?";
        }
    }
}
