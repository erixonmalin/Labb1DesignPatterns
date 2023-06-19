using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1DesignPatterns
{
    //FACTORY METHOD pattern
    //Trainee-servitör
    public class TraineeServer : Server
    {
        public override string GetServerType()
        {
            return "Låg erfarenhet";
        }
    }
}
