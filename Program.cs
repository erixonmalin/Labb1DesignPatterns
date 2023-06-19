using System;

namespace Labb1DesignPatterns
{
    // Abstrakt basklass som representerar en generisk servitör utifrån Factory method pattern
    public abstract class Server
    {
        internal string Name;
        public abstract string GetServerType();
    }

    class Program
    {
        static readonly TableServers tableList = TableServers.GetTableServers();

        static void Main(string[] args)
        {
            TableServers servers = TableServers.GetTableServers();

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Välj ett alternativ:");
                Console.WriteLine("1. Lägg till servitör enligt erfarenhet");
                Console.WriteLine("2. Skapa lista över servitörer utifrån antal bord");
                Console.WriteLine("3. Hälsningsfraser");
                Console.WriteLine("4. Avsluta");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        AddServer();
                        break;
                    case "2":
                        CreateTableServersList();
                        break;
                    case "3":
                        Console.WriteLine("Välj en hälsningsstrategi:");
                        Console.WriteLine("1. Formell hälsning");
                        Console.WriteLine("2. Vänlig hälsning");
                        string greetingChoice = Console.ReadLine();

                        IGreetingStrategy greetingStrategy;
                        if (greetingChoice == "1")
                        {
                            greetingStrategy = new FormalGreetingStrategy();
                        }
                        else if (greetingChoice == "2")
                        {
                            greetingStrategy = new FriendlyGreetingStrategy();
                        }
                        else
                        {
                            Console.WriteLine("Ogiltigt val. Försök igen.");
                            break;
                        }
                        Console.Clear();
                        Restaurant restaurant = new Restaurant(greetingStrategy);
                        string greeting = restaurant.GreetCustomer();
                        Console.WriteLine(greeting);
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Ogiltigt val. Försök igen.");
                        break;
                }
                Console.WriteLine();
            }
        }


        //Tillhör - factory method pattern
        private static void AddServer()
        {
            Console.Clear();
            Console.WriteLine("Lägg till servitör:");
            Console.WriteLine("Uppge erfarenhet. Välj mellan Hög eller Låg ");
            string serverType = Console.ReadLine().ToLower();

            //Hantera ogiltiga servitörtyper omedelbart innan man uppger namn
            Server newServer = CreateServer(serverType);

            if (newServer != null)
            {
                Console.WriteLine("Namn: ");
                string serverName = Console.ReadLine();

                newServer.Name = serverName;
                Console.WriteLine("Ny servitör av typ: \"" + newServer.GetServerType() + "\" med namn \"" + serverName + "\" har lagts till.");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Ogiltig servitörtyp.");
            }
        }


        //Tillhör - factory method pattern
        private static Server CreateServer(string serverType)
        {
            if (serverType == "hög")
            {
                // Returnerar en ny instans av ExperiencedServer för servitörer med hög erfarenhet.
                return new ExperiencedServer();
            }
            else if (serverType == "låg")
            {
                //Returnerar en ny instans av TraineeServer för servitörer med låg erfarenhet.
                return new TraineeServer();
            }
            return null;
        }


        //Tillhör - singelton pattern
        private static void CreateTableServersList()
        {
            Console.Clear();
            Console.WriteLine("Skapa lista över servitörer. Vänligen ange antal bord:");
            int tables = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Bordsfördelning:");
            Console.WriteLine();

            for (int i = 1; i <= tables; i++)
            {
                Console.WriteLine("Bord " + i + ":");
                Host1GetNextServer(); //Hämtar nästa servitör från listan och skriver ut den.
                Console.WriteLine();
            }
            Console.ReadLine();
        }


        //Tillhör - singelton pattern
        private static void Host1GetNextServer()
        {
            Console.WriteLine("Servitör: " + tableList.GetNextServer());
        }
    }
}


