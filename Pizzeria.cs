using System.Collections;

namespace Projet {

    public class Pizzeria {

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
        /// Constructeur de la pizzeria
        /// </summary>
        /// <param name="name"></param>
        public Pizzeria(string name)
        {
            Name = name;
        }

        public void CreateUser(string user, string name, string firstname)
        {
            if (user == "Client")
            {
                clients.Add(new Client(name, firstname, clients.Count + 1));
            }
            else if (user == "Deliver")
            {
                delivers.Add(new Deliver(name, firstname, delivers.Count + 1));
            }
            else if (user == "Commis")
            {
                commiss.Add(new Commis(name, firstname, commiss.Count  + 1));
            }

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

        public void UpdateUser(ArrayList users, int id){

            foreach (User user in users)
            {
                if (user.Id == id)
                {   
                    Console.WriteLine("\nYou are updating the user: " + user.Name + " " + user.FirstName +"\nPress enter to skip" + "\n");

                    Console.WriteLine("Name: ");
                    string? name = Console.ReadLine();

                    Console.WriteLine("FirstName: ");
                    string? firstname = Console.ReadLine();

                    if (String.IsNullOrEmpty(name)) name = user.Name;
                    
                    if (String.IsNullOrEmpty(firstname)) firstname = user.FirstName;

                    user.UpdateUser(name, firstname);

                    Console.WriteLine("\n***User updated!***\n");

                    user.PrintUser();
                }

            }
        }

        public void DeleteUser(ArrayList users, int id)
        {
            object? userToDelete = null;

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



    public class Program {

        public static void Main(string[] args) {

            Pizzeria Luigi = new Pizzeria("Chez Luigi");

            Luigi.CreateUser("Client", "King", "Bowser");

            Luigi.CreateUser("Deliver", "Mushroom", "Toad");

            Luigi.CreateUser("Commis", "Bros", "Mario");


        }

    }


}