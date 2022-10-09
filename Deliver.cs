namespace Projet
{

    public class Deliver : User
    {


        public Deliver(string name, string firstname, int id) : base(name, firstname, id)
        {

        }

        public override void UpdateUser(string name, string firstname)
        {
            Name = name;
            FirstName = firstname;
        }

    }

}