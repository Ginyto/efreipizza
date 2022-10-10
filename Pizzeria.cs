using System.Collections;

namespace Projet
{

    public class Pizzeria
    {

        public string Name { get; set; }

        /// <summary>
        /// Liste des clients
        /// </summary>
        public ArrayList clients = new ArrayList();

        /// <summary>
        /// Listes des livreurs
        /// </summary>
        /// <returns></returns>
        public ArrayList delivers = new ArrayList();

        /// <summary>
        /// Listes des commis
        /// </summary>
        /// <returns></returns>
        public ArrayList commiss = new ArrayList();


        /// <summary>
        /// Liste des commandes
        /// </summary>
        /// <returns></returns>
        public ArrayList commandlist = new ArrayList();


        /// <summary>
        /// Constructeur de la pizzeria
        /// </summary>
        /// <param name="name"></param>
        public Pizzeria(string name)
        {
            Name = name;
        }

        public void CreateClient()
        {
            Client client = new Client(clients.Count + 1);
            client.CreateUser();
            clients.Add(client);
        }

        public void CreateClient(string name, string firstname, string address, string phone)
        {
            clients.Add(new Client(clients.Count + 1, name, firstname, address, phone));
        }

        public void CreateCommis(string name, string firstname)
        {
            commiss.Add(new Commis(commiss.Count + 1, name, firstname));
        }



        public void PrintUsers(ArrayList users)
        {
            Console.WriteLine("\nListe des utilisateurs v");
            foreach (User user in users)
            {
                user.PrintUser();
            }
        }


        public void PrintPizzeria()
        {
            Console.WriteLine($"Pizzeria: {Name}");
            Console.WriteLine($"Clients: {clients.Count}");
            Console.WriteLine($"Delivers: {delivers.Count}");
            Console.WriteLine($"Commiss: {commiss.Count}");
        }

        public void UpdateUser(ArrayList users, int id)
        {

            foreach (User user in users)
            {
                if (user.Id == id)
                {
                    user.UpdateUser();
                }

            }
        }

        public void DeleteUser(ArrayList users, int id)
        {
            object userToDelete = null;

            foreach (User user in users)
            {
                if (user.Id == id)
                {
                    userToDelete = user;
                    Console.WriteLine($"\n***User {user.Name} {user.FirstName} deleted!***\n");
                }
            }

            users.Remove(userToDelete);

        }

    }


/**
    public class Program
    {

        public static void Main(string[] args)
        {

            Pizzeria Luigi = new Pizzeria("Chez Luigi");

            Luigi.CreateClient("Bowser", "King", "Paris", "06");

            Luigi.CreateCommis("Mushroom", "Toad");


        }

    }
**/

}