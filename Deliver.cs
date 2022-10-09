namespace Projet
{

    public class Deliver : User
    {


        public Deliver(int id) : base(id)
        {

        }
        public override void UpdateUser()
        {

        }

        public override void PrintUser()
        {
            Console.WriteLine($"Deliver: {Name} {FirstName} {Id}");
        }

    }

}