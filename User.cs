namespace Projet {

    public abstract class User
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Id { get; set; }


        public User(string name, string firstname, int id)
        {
            Name = name;
            FirstName = firstname;
            Id = id;
        }

        public void PrintUser()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"FirstName: {FirstName}");
            Console.WriteLine($"Id: {Id}");
        }

        public abstract void UpdateUser(string name, string firstname);

    }

}