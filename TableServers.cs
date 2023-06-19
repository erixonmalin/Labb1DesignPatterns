using System;
using System.Collections.Generic;

namespace Labb1DesignPatterns
{
    //SINGELTON - Lazy Initialization Singleton i denna klass

    public class TableServers
    {
        //En statisk variabel för att hålla referensen till den enda instansen av TableServers
        private static TableServers _instance;
        private static readonly object _lockObject = new object(); //Objekt för låsning
        private List<string> servers = new List<string>();
        private int nextServer = 0;

        //Den privata konstruktorn säkerställer att klassen inte kan instansieras utanför sig själv
        private TableServers()
        {
            servers.Add("Marie");
            servers.Add("Karin");
            servers.Add("Jonas");
            servers.Add("Simon");
            servers.Add("Madde");
            servers.Add("Marcus");
            servers.Add("Lisa");
        }

        //En statisk metod för att få referensen till den enda instansen av TableServers
        public static TableServers GetTableServers()
        {
            if (_instance == null)
            {
                lock (_lockObject) //Låsning för att göra det trådsäkert
                {
                    if (_instance == null) //Dubbelkontroll inuti låset
                    {
                        //Skapar en ny instans av TableServers om det är första gången metoden anropas
                        _instance = new TableServers();
                    }
                }
            }
            //Returnera den befintliga instansen om det finns
            return _instance;
        }

        //Metod för att hämta nästa server i listan
        public string GetNextServer()
        {
            string output = servers[nextServer];
            nextServer += 1;

            if (nextServer >= servers.Count)
            {
                nextServer = 0;
            }

            return output;
        }
    }
}
