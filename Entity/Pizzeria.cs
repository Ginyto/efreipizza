using System;
using System.Collections;
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
        public ArrayList commands = new ArrayList();

        /// <summary>
        /// Liste des pizzas
        /// </summary>
        /// <returns></returns>
        public ArrayList pizzas = new ArrayList();

        /// <summary>
        /// Liste des drinks
        /// </summary>
        /// <returns></returns>
        public ArrayList drinks = new ArrayList();


        /// <summary>
        /// Constructeur de la pizzeria
        /// </summary>
        /// <param name="name"></param>
        public Pizzeria(string name)
        {
            Name = name;

            OpenRestaurant();
        }


        public void OpenRestaurant()
        {
            Pizza p1 = new Pizza("Margherita",7.99, "Tomato sauce, mozzarella, basil");
            pizzas.Add(p1);

            Pizza p2 = new Pizza("Napolitaine",8.99, "Tomato sauce, mozzarella, anchovies, olives");
            pizzas.Add(p2);

            Pizza p3 = new Pizza("Calzone",9.99, "Tomato sauce, mozzarella, ham, mushrooms");
            pizzas.Add(p3);

            Pizza p4 = new Pizza("Reine",10.99, "Tomato sauce, mozzarella, ham, mushrooms");
            pizzas.Add(p4);


            Drink d1 = new Drink("Coca", 2.00);
            drinks.Add(d1);

            Drink d2 = new Drink("Fanta", 2.00);
            drinks.Add(d2);

            Drink d3 = new Drink("Sprite", 2.00);
            drinks.Add(d3);

            Drink d4 = new Drink("7up", 2.00);
            drinks.Add(d4);
        }

        public string LaCarte(){

            string carte = "La carte v \n\n";

            foreach (Pizza p in pizzas)
            {
                carte += p.Name + " : " + p.Price + "$\n";

            }

            foreach (Drink d in drinks)
            {
                carte += d.Name + " : " + d.Price + "$\n";

            }

            carte += "\nSize ---> M + 1$ , L + 4$ , XL + 5$ <---\n";

            return carte;
        }



        public Client CreateClient(string name, string firstname, string address, string phone)
        {

            if (inside(phone))
            {
                // Console.WriteLine(name + " " + firstname + " is already a client");
            }
            else
            {
                // Console.WriteLine(name + " " + firstname + " is now a client");
                Client client = new Client(clients.Count + 1, name, firstname, address, phone);
                clients.Add(client);

                return client;
            }

            return null;
        }

        public Commis CreateCommis(string name, string firstname)
        {

            if (inside(commiss, name, firstname))
            {
                // Console.WriteLine(name + " " + firstname + " is already a commis");
            }
            else
            {
                // Console.WriteLine(name + " " + firstname + " is now a commis");
                Commis commis = new Commis(commiss.Count + 1, name, firstname);
                commiss.Add(commis);

                return commis;
            }

            return null;
        }

        public Deliver CreateDeliver(string name, string firstname)
        {
            
            if(inside(delivers, name, firstname))
            {
                // Console.WriteLine(name + " " + firstname + " is already a deliver");
            }
            else
            {
                // Console.WriteLine(name + " " + firstname + " is now a deliver");
                Deliver deliver = new Deliver(delivers.Count + 1, name, firstname);
                delivers.Add(deliver);

                return deliver;
            }

            return null;
        }

        public Command CreateCommand(Client client, Commis commis, Deliver deliver)
        {
            Command command = new Command(commands.Count + 1, client, commis, deliver);

            return command;
        }



        public bool inside(ArrayList list, string name, string firstname){

            foreach (User user in list)
            {
                // Console.WriteLine(user.Id + user.Name + " " + user.FirstName + " ??? " + name + " " + firstname);
                if (user.Name == name && user.FirstName == firstname)
                {
                    // Console.WriteLine(user.Name + " " + user.FirstName + " is already here");
                    return true;
                }
            }

            return false;
        }

        public bool inside(string phone)
        {

            foreach (Client user in clients)
            {
                
                if (user.Phone == phone)
                {
                    // Console.WriteLine(user.Name + " " + user.FirstName + " is already here");
                    return true;
                }
            }

            return false;
        }

        


        public void PrintUsers(ArrayList users)
        {
            Console.WriteLine("\nListe des utilisateurs v");
            foreach (User user in users)
            {
                user.PrintUser();
            }
        }


        public string PrintPizzeria()
        {
            // Console.WriteLine($"Pizzeria: {Name}");
            // Console.WriteLine($"Clients: {clients.Count}");
            // Console.WriteLine($"Delivers: {delivers.Count}");
            // Console.WriteLine($"Commiss: {commiss.Count}");
            // Console.WriteLine($"Commands: {commands.Count}");

            return $"Clients: {clients.Count} \nDelivers: {delivers.Count} \nCommiss: {commiss.Count} \nCommands: {commands.Count}";
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

        public Pizza PizzaById(int id)
        {
            return (Pizza) pizzas[id - 1];

        }

        public Drink DrinkById(int id)
        {
            return (Drink) drinks[id - 1];

        }

        public void TakeOrder(Command command, int IdItem, string size, string itemtype) {

            if (itemtype == "pizza")
            {
                
                PizzaById(IdItem).Size = size;

                command.addPizzas(PizzaById(IdItem));
                
            }
            else if (itemtype == "drink")
            {
                
                DrinkById(IdItem).Size = size;

                command.addDrinks(DrinkById(IdItem));
                
            }

        }

        public void RemoveOrder(Command command, int IdItem, string size,string itemtype)
        {

            if (itemtype == "pizza")
            {
                
                PizzaById(IdItem).Size = size;

                command.delPizzas(PizzaById(IdItem));
                
            }
            else if (itemtype == "drink")
            {

                DrinkById(IdItem).Size = size;

                command.delDrinks(DrinkById(IdItem));
                
            }

        }


    }



    // namespace Projet {
    //     public class Program
    //     {

    //         public static void Main(string[] args)
    //         {

    //             Pizzeria Luigi = new Pizzeria("Chez Luigi");

    //             Client Bowser = Luigi.CreateClient("Bowser", "King", "Paris", "06");

    //             Commis Toad = Luigi.CreateCommis("Mushroom", "Toad");

    //             Deliver Peach = Luigi.CreateDeliver("Peach", "Princess");

    //             Console.WriteLine(Luigi.LaCarte());

    //             Command command = Luigi.CreateCommand(Bowser, Toad, Peach);

    //             Luigi.TakeOrder(command, 1, "M", 2, "pizza");
    //             Luigi.TakeOrder(command, 2, "L", 1, "pizza");

    //             Luigi.TakeOrder(command, 1, "XL", 1, "drink");
    //             Luigi.TakeOrder(command, 2, "XL", 1, "drink");

    //             command.PrintCommand();

    //         }

    //     }
    // }
