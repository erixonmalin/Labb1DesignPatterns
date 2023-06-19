using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1DesignPatterns
{
    //STRATEGY pattern
    //Konkret implementering av formell hälsningsstrategi
    public class FormalGreetingStrategy : IGreetingStrategy
    {
        public string Greet()
        {
            return "God dag! Välkommen till vår restaurang. Hur kan jag bistå er?";
        }
    }
}
