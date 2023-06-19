using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1DesignPatterns
{
    //STRATEGY pattern
    //Gränssnitt för hälsningsstrategi
    public interface IGreetingStrategy
    {
        string Greet();
    }
}
