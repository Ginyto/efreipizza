namespace Projet {

    public class Client : User
    {
        

        public Client(string name, string firstname, int id) : base(name, firstname, id)
        {
            
        }

        public override void UpdateUser(string name, string firstname)
        {
            Name = name;
            FirstName = firstname;
        }

    }

}

