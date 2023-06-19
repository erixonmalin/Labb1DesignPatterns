using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1DesignPatterns
{
    //FACTORY METHOD pattern
    //Erfaren servitör
    public class ExperiencedServer : Server
    {
        public override string GetServerType()
        {
            return "Hög erfarenhet";
        }
    }
}
