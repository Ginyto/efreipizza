namespace Projet {

    public abstract class User
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Id { get; set; }


        public User(int id)
        {
            Console.WriteLine("\nNouvel utilisateur\n");
            Console.WriteLine("Name: ");
            Name = Console.ReadLine();

            Console.WriteLine("FirstName: ");
            FirstName = Console.ReadLine();

            Id = id;
        }

        public User (int id, string name, string firstname)
        {
            Name = name;
            FirstName = firstname;
            Id = id;
        }

        public abstract void PrintUser();
        public abstract void UpdateUser();


    }

}